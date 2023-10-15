using System.Reflection;
using BepInEx;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
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
        public const string PluginVersion = "2.0.3";

        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        public void Awake()
        {
            //load the mod
            CreateConfigEntries();
            PrefabManager.OnVanillaPrefabsAvailable += AddMissingPieces;

            // load embedded localization
            string englishJson = AssetUtils.LoadTextFromResources("Localization.English.json", Assembly.GetExecutingAssembly());
            Localization.AddJsonFile("English", englishJson);

            //tell that the mod injection worked
            Jotunn.Logger.LogInfo("Missing Pieces landed!");
        }
        
        private void CreateConfigEntries()
        {
            Config.SaveOnConfigSet = true;

            var missingPieces = new MissingPieces(Config);
        }

        private void AddMissingPieces()
        {
            AssetBundle bundle = AssetUtils.LoadAssetBundleFromResources("missing_pieces", Assembly.GetExecutingAssembly());

            GameObject stonewall1X1Triangular = bundle.LoadAsset<GameObject>("stone_wall_1x1_triangular");
            PieceConfig stonewall1x1triangular = new PieceConfig();
            stonewall1x1triangular.Name = "$piece_stonewall1x1triangular";
            stonewall1x1triangular.Description = "$piece_stonewall1x1triangular_description";
            stonewall1x1triangular.PieceTable = "Hammer";
            stonewall1x1triangular.Category = "Building";
            stonewall1x1triangular.CraftingStation = "piece_stonecutter";
            stonewall1x1triangular.AllowedInDungeons = false;
            stonewall1x1triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Stone", Amount = 2, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(stonewall1X1Triangular,true, stonewall1x1triangular));

            GameObject stonewall2X1Triangular = bundle.LoadAsset<GameObject>("stone_wall_2x1_triangular");
            PieceConfig stonewall2x1triangular = new PieceConfig();
            stonewall2x1triangular.Name = "$piece_stonewall2x1triangular";
            stonewall2x1triangular.Description = "$piece_stonewall2x1triangular_description";
            stonewall2x1triangular.PieceTable = "Hammer";
            stonewall2x1triangular.Category = "Building";
            stonewall2x1triangular.CraftingStation = "piece_stonecutter";
            stonewall2x1triangular.AllowedInDungeons = false;
            stonewall2x1triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Stone", Amount = 2, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(stonewall2X1Triangular,true, stonewall2x1triangular));

            GameObject stoneStairCorner = bundle.LoadAsset<GameObject>("stone_stair_corner");
            PieceConfig stonestaircorner = new PieceConfig();
            stonestaircorner.Name = "$piece_stonestaircorner";
            stonestaircorner.Description = "$piece_stonestaircorner_description";
            stonestaircorner.PieceTable = "Hammer";
            stonestaircorner.Category = "Building";
            stonestaircorner.CraftingStation = "piece_stonecutter";
            stonestaircorner.AllowedInDungeons = false;
            stonestaircorner.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Stone", Amount = 6, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(stoneStairCorner,true, stonestaircorner));

            GameObject stoneFloor1x1 = bundle.LoadAsset<GameObject>("stone_floor_1x1");
            PieceConfig stonefloor1x1 = new PieceConfig();
            stonefloor1x1.Name = "$piece_stonefloor1x1";
            stonefloor1x1.Description = "$piece_stonefloor1x1_description";
            stonefloor1x1.PieceTable = "Hammer";
            stonefloor1x1.Category = "Building";
            stonefloor1x1.CraftingStation = "piece_stonecutter";
            stonefloor1x1.AllowedInDungeons = false;
            stonefloor1x1.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Stone", Amount = 2, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(stoneFloor1x1,true, stonefloor1x1));

            GameObject woodFloorTriangular1 = bundle.LoadAsset<GameObject>("wood_floor_triangular1");
            PieceConfig woodfloortriangular1 = new PieceConfig();
            woodfloortriangular1.Name = "$piece_woodfloortriangular1";
            woodfloortriangular1.Description = "$piece_woodfloortriangular1_description";
            woodfloortriangular1.PieceTable = "Hammer";
            woodfloortriangular1.Category = "Building";
            woodfloortriangular1.CraftingStation = "piece_workbench";
            woodfloortriangular1.AllowedInDungeons = false;
            woodfloortriangular1.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(woodFloorTriangular1,true, woodfloortriangular1));

            GameObject woodFloorTriangular2 = bundle.LoadAsset<GameObject>("wood_floor_triangular2");
            PieceConfig woodfloortriangular2 = new PieceConfig();
            woodfloortriangular2.Name = "$piece_woodfloortriangular2";
            woodfloortriangular2.Description = "$piece_woodfloortriangular2_description";
            woodfloortriangular2.PieceTable = "Hammer";
            woodfloortriangular2.Category = "Building";
            woodfloortriangular2.CraftingStation = "piece_workbench";
            woodfloortriangular2.AllowedInDungeons = false;
            woodfloortriangular2.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(woodFloorTriangular2,true, woodfloortriangular2));

            GameObject finerStepLadder = bundle.LoadAsset<GameObject>("wood_finerstepladder");
            PieceConfig finerstepladder = new PieceConfig();
            finerstepladder.Name = "$piece_finerstepladder";
            finerstepladder.Description = "$piece_finerstepladder_description";
            finerstepladder.PieceTable = "Hammer";
            finerstepladder.Category = "Building";
            finerstepladder.CraftingStation = "piece_workbench";
            finerstepladder.AllowedInDungeons = false;
            finerstepladder.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 3, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(finerStepLadder,true, finerstepladder));

            GameObject woodStair1M = bundle.LoadAsset<GameObject>("wood_stair_1m");
            PieceConfig woodstair1m = new PieceConfig();
            woodstair1m.Name = "$piece_woodstair1m";
            woodstair1m.Description = "$piece_woodstair1m_description";
            woodstair1m.PieceTable = "Hammer";
            woodstair1m.Category = "Building";
            woodstair1m.CraftingStation = "piece_workbench";
            woodstair1m.AllowedInDungeons = false;
            woodstair1m.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(woodStair1M,true, woodstair1m));

            GameObject rightWoodRoof26Triangular = bundle.LoadAsset<GameObject>("roof_wood_26_right");
            PieceConfig rightwoodroof26triangular = new PieceConfig();
            rightwoodroof26triangular.Name = "$piece_rightwoodroof26triangular";
            rightwoodroof26triangular.Description = "$piece_rightwoodroof26triangular_description";
            rightwoodroof26triangular.PieceTable = "Hammer";
            rightwoodroof26triangular.Category = "Building";
            rightwoodroof26triangular.CraftingStation = "piece_workbench";
            rightwoodroof26triangular.AllowedInDungeons = false;
            rightwoodroof26triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(rightWoodRoof26Triangular,true, rightwoodroof26triangular));

            GameObject leftWoodRoof26Triangular = bundle.LoadAsset<GameObject>("roof_wood_26_left");
            PieceConfig leftwoodroof26triangular = new PieceConfig();
            leftwoodroof26triangular.Name = "$piece_leftwoodroof26triangular";
            leftwoodroof26triangular.Description = "$piece_leftwoodroof26triangular_description";
            leftwoodroof26triangular.PieceTable = "Hammer";
            leftwoodroof26triangular.Category = "Building";
            leftwoodroof26triangular.CraftingStation = "piece_workbench";
            leftwoodroof26triangular.AllowedInDungeons = false;
            leftwoodroof26triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(leftWoodRoof26Triangular,true, leftwoodroof26triangular));

            GameObject rightWoodRoof45Triangular = bundle.LoadAsset<GameObject>("roof_wood_45_right");
            PieceConfig rightwoodroof45triangular = new PieceConfig();
            rightwoodroof45triangular.Name = "$piece_rightwoodroof45triangular";
            rightwoodroof45triangular.Description = "$piece_rightwoodroof45triangular_description";
            rightwoodroof45triangular.PieceTable = "Hammer";
            rightwoodroof45triangular.Category = "Building";
            rightwoodroof45triangular.CraftingStation = "piece_workbench";
            rightwoodroof45triangular.AllowedInDungeons = false;
            rightwoodroof45triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(rightWoodRoof45Triangular,true, rightwoodroof45triangular));

            GameObject leftWoodRoof45Triangular = bundle.LoadAsset<GameObject>("roof_wood_45_left");
            PieceConfig leftwoodroof45triangular = new PieceConfig();
            leftwoodroof45triangular.Name = "$piece_leftwoodroof45triangular";
            leftwoodroof45triangular.Description = "$piece_leftwoodroof45triangular_description";
            leftwoodroof45triangular.PieceTable = "Hammer";
            leftwoodroof45triangular.Category = "Building";
            leftwoodroof45triangular.CraftingStation = "piece_workbench";
            leftwoodroof45triangular.AllowedInDungeons = false;
            leftwoodroof45triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(leftWoodRoof45Triangular,true, leftwoodroof45triangular));

            GameObject rightDarkwoodRoof26Triangular = bundle.LoadAsset<GameObject>("roof_darkwood_26_right");
            PieceConfig rightdarkwoodroof26triangular = new PieceConfig();
            rightdarkwoodroof26triangular.Name = "$piece_rightdarkwoodroof26triangular";
            rightdarkwoodroof26triangular.Description = "$piece_rightdarkwoodroof26triangular_description";
            rightdarkwoodroof26triangular.PieceTable = "Hammer";
            rightdarkwoodroof26triangular.Category = "Building";
            rightdarkwoodroof26triangular.CraftingStation = "piece_workbench";
            rightdarkwoodroof26triangular.AllowedInDungeons = false;
            rightdarkwoodroof26triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true },
                new RequirementConfig() { Item = "Tar", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(rightDarkwoodRoof26Triangular,true, rightdarkwoodroof26triangular));

            GameObject leftDarkwoodRoof26Triangular = bundle.LoadAsset<GameObject>("roof_darkwood_26_left");
            PieceConfig leftdarkwoodroof26triangular = new PieceConfig();
            leftdarkwoodroof26triangular.Name = "$piece_leftdarkwoodroof26triangular";
            leftdarkwoodroof26triangular.Description = "$piece_leftdarkwoodroof26triangular_description";
            leftdarkwoodroof26triangular.PieceTable = "Hammer";
            leftdarkwoodroof26triangular.Category = "Building";
            leftdarkwoodroof26triangular.CraftingStation = "piece_workbench";
            leftdarkwoodroof26triangular.AllowedInDungeons = false;
            leftdarkwoodroof26triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true },
                new RequirementConfig() { Item = "Tar", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(leftDarkwoodRoof26Triangular,true, leftdarkwoodroof26triangular));

            GameObject rightDarkwoodRoof45Triangular = bundle.LoadAsset<GameObject>("roof_darkwood_45_right");
            PieceConfig rightdarkwoodroof45triangular = new PieceConfig();
            rightdarkwoodroof45triangular.Name = "$piece_rightdarkwoodroof45triangular";
            rightdarkwoodroof45triangular.Description = "$piece_rightdarkwoodroof45triangular_description";
            rightdarkwoodroof45triangular.PieceTable = "Hammer";
            rightdarkwoodroof45triangular.Category = "Building";
            rightdarkwoodroof45triangular.CraftingStation = "piece_workbench";
            rightdarkwoodroof45triangular.AllowedInDungeons = false;
            rightdarkwoodroof45triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true },
                new RequirementConfig() { Item = "Tar", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(rightDarkwoodRoof45Triangular,true, rightdarkwoodroof45triangular));

            GameObject leftDarkwoodRoof45Triangular = bundle.LoadAsset<GameObject>("roof_darkwood_45_left");
            PieceConfig leftdarkwoodroof45triangular = new PieceConfig();
            leftdarkwoodroof45triangular.Name = "$piece_leftdarkwoodroof45triangular";
            leftdarkwoodroof45triangular.Description = "$piece_leftdarkwoodroof45triangular_description";
            leftdarkwoodroof45triangular.PieceTable = "Hammer";
            leftdarkwoodroof45triangular.Category = "Building";
            leftdarkwoodroof45triangular.CraftingStation = "piece_workbench";
            leftdarkwoodroof45triangular.AllowedInDungeons = false;
            leftdarkwoodroof45triangular.Requirements = new RequirementConfig[]
            {
            new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true },
            new RequirementConfig() { Item = "Tar", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(leftDarkwoodRoof45Triangular,true, leftdarkwoodroof45triangular));

            GameObject MPwoodendrawer = bundle.LoadAsset<GameObject>("piece_chest_wooden_drawer");
            GameObject WoodOpenEffect = PrefabManager.Instance.GetPrefab("sfx_chest_open");
            GameObject WoodCloseEffect = PrefabManager.Instance.GetPrefab("sfx_chest_close");
            PieceConfig mpwoodendrawer = new PieceConfig();
            mpwoodendrawer.Name = "$piece_mpwoodendrawer";
            mpwoodendrawer.Description = "$piece_mpwoodendrawer_description";
            mpwoodendrawer.PieceTable = "Hammer";
            mpwoodendrawer.Category = "Furniture";
            mpwoodendrawer.CraftingStation = "piece_workbench";
            mpwoodendrawer.AllowedInDungeons = true;
            MPwoodendrawer.GetComponent<Container>().m_width = MissingPieces.WoodDrawerWidth.Value;
            MPwoodendrawer.GetComponent<Container>().m_height = MissingPieces.WoodDrawerHeight.Value;
            MPwoodendrawer.GetComponent<Container>().m_openEffects = new EffectList {
                m_effectPrefabs = new EffectList.EffectData[] {
                    new EffectList.EffectData() {
                        m_prefab = WoodOpenEffect,
                        m_enabled = true
                    }
                }
            };
            MPwoodendrawer.GetComponent<Container>().m_closeEffects = new EffectList {
                m_effectPrefabs = new EffectList.EffectData[] {
                    new EffectList.EffectData() {
                        m_prefab = WoodCloseEffect,
                        m_enabled = true
                    }
                }
            };
            mpwoodendrawer.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "FineWood", Amount = 10, Recover = true },
                new RequirementConfig() { Item = "Iron", Amount = 2, Recover = true },
                new RequirementConfig() { Item = "Coal", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(MPwoodendrawer, true, mpwoodendrawer));
            
            PrefabManager.OnVanillaPrefabsAvailable -= AddMissingPieces;
        }
    }
}