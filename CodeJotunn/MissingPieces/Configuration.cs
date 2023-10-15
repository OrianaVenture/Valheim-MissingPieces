using BepInEx.Configuration;

namespace MissingPieces; 

public class MissingPieces {
    public static ConfigEntry<int> WoodDrawerWidth;
    public static ConfigEntry<int> WoodDrawerHeight;
    
    internal MissingPieces(ConfigFile config) {
        WoodDrawerWidth = config.Bind("Chests", "Wooden Drawer Columns", 6, new ConfigDescription("Wooden Drawer Columns", null, new ConfigurationManagerAttributes {IsAdminOnly = true}));
        WoodDrawerHeight = config.Bind("Chests", "Wooden Drawer Rows", 4, new ConfigDescription("Wooden Drawer Rows", null, new ConfigurationManagerAttributes {IsAdminOnly = true}));
    }
}