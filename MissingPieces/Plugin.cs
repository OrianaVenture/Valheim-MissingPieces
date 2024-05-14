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
        public const string PluginVersion = "2.2.0";

        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private static string Hammer = "Hammer";
        private static string Workbench = "piece_workbench";
        private static string Stonecutter = "piece_stonecutter";
        private static string CategoryBuildingWorkbench = "BuildingWorkbench";
        private static string CategoryBuildingStonecutter = "BuildingStonecutter";

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
        
        private void AddMissingPieces()
        {
            AssetBundle bundle = AssetUtils.LoadAssetBundleFromResources("missing_pieces", Assembly.GetExecutingAssembly());

            GameObject woodwallhalf = bundle.LoadAsset<GameObject>("wood_wall_half_upper");
            PieceConfig pc_woodwallhalf = new PieceConfig();
            pc_woodwallhalf.Name = "$piece_woodwallhalfupper";
            pc_woodwallhalf.Description = "$piece_woodwallhalfupper_description";
            pc_woodwallhalf.PieceTable = Hammer;
            pc_woodwallhalf.Category = CategoryBuildingWorkbench;
            pc_woodwallhalf.CraftingStation = Workbench;
            pc_woodwallhalf.AllowedInDungeons = false;
            pc_woodwallhalf.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(woodwallhalf, true, pc_woodwallhalf));

            GameObject woodwallquarter = bundle.LoadAsset<GameObject>("wood_wall_quarter_upper");
            PieceConfig pc_woodwallquarter = new PieceConfig();
            pc_woodwallquarter.Name = "$piece_woodwallquarterupper";
            pc_woodwallquarter.Description = "$piece_woodwallquarterupper_description";
            pc_woodwallquarter.PieceTable = Hammer;
            pc_woodwallquarter.Category = CategoryBuildingWorkbench;
            pc_woodwallquarter.CraftingStation = Workbench;
            pc_woodwallquarter.AllowedInDungeons = false;
            pc_woodwallquarter.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(woodwallquarter, true, pc_woodwallquarter));

            GameObject stonewall1X1Triangular = bundle.LoadAsset<GameObject>("stone_wall_1x1_triangular");
            PieceConfig stonewall1x1triangular = new PieceConfig();
            stonewall1x1triangular.Name = "$piece_stonewall1x1triangular";
            stonewall1x1triangular.Description = "$piece_stonewall1x1triangular_description";
            stonewall1x1triangular.PieceTable = Hammer;
            stonewall1x1triangular.Category = CategoryBuildingStonecutter;
            stonewall1x1triangular.CraftingStation = Stonecutter;
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
            stonewall2x1triangular.PieceTable = Hammer;
            stonewall2x1triangular.Category = CategoryBuildingStonecutter;
            stonewall2x1triangular.CraftingStation = Stonecutter;
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
            stonestaircorner.PieceTable = Hammer;
            stonestaircorner.Category = CategoryBuildingStonecutter;
            stonestaircorner.CraftingStation = Stonecutter;
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
            stonefloor1x1.PieceTable = Hammer;
            stonefloor1x1.Category = CategoryBuildingStonecutter;
            stonefloor1x1.CraftingStation = Stonecutter;
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
            woodfloortriangular1.PieceTable = Hammer;
            woodfloortriangular1.Category = CategoryBuildingWorkbench;
            woodfloortriangular1.CraftingStation = Workbench;
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
            woodfloortriangular2.PieceTable = Hammer;
            woodfloortriangular2.Category = CategoryBuildingWorkbench;
            woodfloortriangular2.CraftingStation = Workbench;
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
            finerstepladder.PieceTable = Hammer;
            finerstepladder.Category = CategoryBuildingWorkbench;
            finerstepladder.CraftingStation = Workbench;
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
            woodstair1m.PieceTable = Hammer;
            woodstair1m.Category = CategoryBuildingWorkbench;
            woodstair1m.CraftingStation = Workbench;
            woodstair1m.AllowedInDungeons = false;
            woodstair1m.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(woodStair1M,true, woodstair1m));

            GameObject woodRoof2m = bundle.LoadAsset<GameObject>("roof_wood_2m");
            PieceConfig pc_woodRoof2m = new PieceConfig();
            pc_woodRoof2m.Name = "$piece_roofwood2m";
            pc_woodRoof2m.Description = "$piece_roofwood2m_description";
            pc_woodRoof2m.PieceTable = Hammer;
            pc_woodRoof2m.Category = CategoryBuildingWorkbench;
            pc_woodRoof2m.CraftingStation = Workbench;
            pc_woodRoof2m.AllowedInDungeons = false;
            pc_woodRoof2m.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(woodRoof2m, true, pc_woodRoof2m));

            GameObject rightWoodRoof26Triangular = bundle.LoadAsset<GameObject>("roof_wood_26_right");
            PieceConfig rightwoodroof26triangular = new PieceConfig();
            rightwoodroof26triangular.Name = "$piece_rightwoodroof26triangular";
            rightwoodroof26triangular.Description = "$piece_rightwoodroof26triangular_description";
            rightwoodroof26triangular.PieceTable = Hammer;
            rightwoodroof26triangular.Category = CategoryBuildingWorkbench;
            rightwoodroof26triangular.CraftingStation = Workbench;
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
            leftwoodroof26triangular.PieceTable = Hammer;
            leftwoodroof26triangular.Category = CategoryBuildingWorkbench;
            leftwoodroof26triangular.CraftingStation = Workbench;
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
            rightwoodroof45triangular.PieceTable = Hammer;
            rightwoodroof45triangular.Category = CategoryBuildingWorkbench;
            rightwoodroof45triangular.CraftingStation = Workbench;
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
            leftwoodroof45triangular.PieceTable = Hammer;
            leftwoodroof45triangular.Category = CategoryBuildingWorkbench;
            leftwoodroof45triangular.CraftingStation = Workbench;
            leftwoodroof45triangular.AllowedInDungeons = false;
            leftwoodroof45triangular.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(leftWoodRoof45Triangular,true, leftwoodroof45triangular));

            GameObject darkwoodRoof2m = bundle.LoadAsset<GameObject>("roof_darkwood_2m");
            PieceConfig pc_darkwoodRoof2m = new PieceConfig();
            pc_darkwoodRoof2m.Name = "$piece_roofdarkwood2m";
            pc_darkwoodRoof2m.Description = "$piece_roofdarkwood2m_description";
            pc_darkwoodRoof2m.PieceTable = Hammer;
            pc_darkwoodRoof2m.Category = CategoryBuildingWorkbench;
            pc_darkwoodRoof2m.CraftingStation = Workbench;
            pc_darkwoodRoof2m.AllowedInDungeons = false;
            pc_darkwoodRoof2m.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true },
                new RequirementConfig() { Item = "Tar", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(darkwoodRoof2m, true, pc_darkwoodRoof2m));

            GameObject rightDarkwoodRoof26Triangular = bundle.LoadAsset<GameObject>("roof_darkwood_26_right");
            PieceConfig rightdarkwoodroof26triangular = new PieceConfig();
            rightdarkwoodroof26triangular.Name = "$piece_rightdarkwoodroof26triangular";
            rightdarkwoodroof26triangular.Description = "$piece_rightdarkwoodroof26triangular_description";
            rightdarkwoodroof26triangular.PieceTable = Hammer;
            rightdarkwoodroof26triangular.Category = CategoryBuildingWorkbench;
            rightdarkwoodroof26triangular.CraftingStation = Workbench;
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
            leftdarkwoodroof26triangular.PieceTable = Hammer;
            leftdarkwoodroof26triangular.Category = CategoryBuildingWorkbench;
            leftdarkwoodroof26triangular.CraftingStation = Workbench;
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
            rightdarkwoodroof45triangular.PieceTable = Hammer;
            rightdarkwoodroof45triangular.Category = CategoryBuildingWorkbench;
            rightdarkwoodroof45triangular.CraftingStation = Workbench;
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
            leftdarkwoodroof45triangular.PieceTable = Hammer;
            leftdarkwoodroof45triangular.Category = CategoryBuildingWorkbench;
            leftdarkwoodroof45triangular.CraftingStation = Workbench;
            leftdarkwoodroof45triangular.AllowedInDungeons = false;
            leftdarkwoodroof45triangular.Requirements = new RequirementConfig[]
            {
            new RequirementConfig() { Item = "Wood", Amount = 1, Recover = true },
            new RequirementConfig() { Item = "Tar", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(leftDarkwoodRoof45Triangular,true, leftdarkwoodroof45triangular));

            GameObject MPwoodendrawer = bundle.LoadAsset<GameObject>("piece_chest_wooden_drawer");
            PieceConfig mpwoodendrawer = new PieceConfig();
            mpwoodendrawer.Name = "$piece_mpwoodendrawer";
            mpwoodendrawer.Description = "$piece_mpwoodendrawer_description";
            mpwoodendrawer.PieceTable = Hammer;
            mpwoodendrawer.Category = "Furniture";
            mpwoodendrawer.CraftingStation = Workbench;
            mpwoodendrawer.AllowedInDungeons = true;
            mpwoodendrawer.Requirements = new RequirementConfig[]
            {
                new RequirementConfig() { Item = "FineWood", Amount = 10, Recover = true },
                new RequirementConfig() { Item = "Iron", Amount = 2, Recover = true },
                new RequirementConfig() { Item = "Coal", Amount = 1, Recover = true }
            };
            PieceManager.Instance.AddPiece(new CustomPiece(MPwoodendrawer, true, mpwoodendrawer));
        }
    }
}