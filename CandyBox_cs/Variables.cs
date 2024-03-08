using System;

public interface IVariables
{
    public static bool debugMode;
    public static int candies;
    public static bool[] unlockedMenus = [
        false, // 1. BoughtManuBar -> It get's some style and reveals that you will unlock more later
        false, // 2. Config
        false, // 3. Save? 
        false, // 4. HealthBar
        false, // 6. Inventory
        false, // 5. Map
        false, // 7. LollipopFarm
        false // 8. Cauldron
    ];
}