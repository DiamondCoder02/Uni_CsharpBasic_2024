public interface IVariables
{
    public static bool debugMode = false;
    public static int candies = 0;
    public static int candyMultip = 1;
    public static int lollipops = 0;
    public static double loliMultip = 0.01;
    public static int chocolate = 0;
    public static int painsAuChocolat = 0;
    public static string currentLocation = "clicker";
    public static int maxHealth = 100;
    public static int currentHealth = 100;
    public static bool[] unlockedMenus = [
        false, //1 1. BoughtManuBar -> It get's some style and reveals that you will unlock more later
        false, //8 2. Config
        false, //7 3. Save? 
        false, //2 4. HealthBar
        false, //3 6. Inventory
        false, //4 5. Map
        false, //5 7. LollipopFarm
        false //6 8. Cauldron
    ];
    // This is used if the control is discovered
    // If not, on the left side it shows "? - ???"
    // If one is discovered it will be true and show "M - Main map"
    public static bool[][] foundControls = {
        // - Side Scrolling fight
        // + Special, choose but also fight
        // | Lot of choices

        [ // Main Map
            //Special || ACTIVATE ONLY ONCE
            false, // Gazing Mountain (PogoStick)
            false, // 3 chocolate under tree
            // Level 1
            false, // Squirel Tree
            false, // Lonely house (Giant Candy Box)
            false, // - Desert
            // Level 2
            false, // + The Desert Fortress
            false, // The Lollipop farm
            false, // - The bridge
            false, // + The Cave entrance
            false, // The Wishing Well
            false, // Sorceress' Hut
            // Level 3
            false, // + The Pier
            false, // - The forest
            false, // | The Lighthouse
            // Level 4
            false, // + The (deep) hole
            false, // - Castle Enterance
            false, // The Castle
            false, // | Dragon
        ],
        [ // Village
            false, // Third house (Kex Needed)
        ],
        [ // Castle
            false, // Stomper Room
            false, // Dark Room
            false, // Spiky Room
            false, // Furnace
            false, // Giant Mouse
            false, // Tower
            false, // Stairs
        ]
    };
}