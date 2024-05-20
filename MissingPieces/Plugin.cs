using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BepInEx;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using Newtonsoft.Json;
using UnityEngine;

namespace MissingPieces
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Major)]
    internal class MissingPiecesPlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.Bento.MissingPieces";
        public const string PluginName = "MissingPieces";
        public const string PluginVersion = "2.2.1";

        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        [Serializable]
        public struct PieceConfiguration
        {
            public string Prefab;
            public PieceConfig Config;
        }

        public void Awake()
        {
            // load the mod
            AddMissingPieces();

            // load embedded localization
            string localizedJson = AssetUtils.LoadTextFromResources("Localization.Chinese.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("Chinese", localizedJson);
            Localization.AddJsonFile("Chinese_Trad", localizedJson);

            localizedJson = AssetUtils.LoadTextFromResources("Localization.English.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("English", localizedJson);

            localizedJson = AssetUtils.LoadTextFromResources("Localization.French.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("French", localizedJson);

            localizedJson = AssetUtils.LoadTextFromResources("Localization.German.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("German", localizedJson);

            localizedJson = AssetUtils.LoadTextFromResources("Localization.Polish.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("Polish", localizedJson);

            localizedJson = AssetUtils.LoadTextFromResources("Localization.Korean.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("Korean", localizedJson);

            localizedJson = AssetUtils.LoadTextFromResources("Localization.Russian.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("Russian", localizedJson);

            // tell that the mod injection worked
            Jotunn.Logger.LogInfo("Missing Pieces landed!");
        }

        private List<PieceConfiguration> LoadJsons()
        {
            // TODO
            var json = AssetUtils.LoadTextFromResources("Configurations.json", Assembly.GetExecutingAssembly());
            try
            {
                var config = JsonConvert.DeserializeObject<List<PieceConfiguration>>(json);
                return config;
            }
            catch
            {
                Jotunn.Logger.LogError("Issue loading pieces! Contact the mod author.");
            }

            return new List<PieceConfiguration>();
        }
        
        private void AddMissingPieces()
        {
            AssetBundle bundle = AssetUtils.LoadAssetBundleFromResources("missing_pieces", Assembly.GetExecutingAssembly());

            List<PieceConfiguration> pieces = LoadJsons();

            foreach (PieceConfiguration piece in pieces)
            {
                GameObject go = bundle.LoadAsset<GameObject>(piece.Prefab);
                PieceManager.Instance.AddPiece(new CustomPiece(go, true, piece.Config));
            }
        }
    }
}