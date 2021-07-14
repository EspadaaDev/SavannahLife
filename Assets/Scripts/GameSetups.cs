using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSetups 
{
    // - - - SETUPS - - -
    // *GENERAL SETTINGS:

    // Length of day in seconds
    public static float dayLength = 300f;

    // Maximum error of indicators when creating an animal
    public static float IndicatorsError = 0.2f;


    // *ANIMAL SETTINGS:
    // General
    
    public static float hungerRate = 2f;        // Hunger rate vs time
    public static float thirstRate = 2f;        // Thirst rate vs time
    public static float movementImpact = 0.1f;  // Effect of speed on hunger and thirst 

    // Lion
    public static float LionHP = 100f;
    public static float LionAGE = 20f;
    public static float LionSPEED = 3.5f;
    public static float LionVISION = 15;
    public static float LionDAMAGE = 20f;

    // Zebra
    public static float ZebraHP = 100f;
    public static float ZebraAGE = 20f;
    public static float ZebraSPEED = 3.5f;
    public static float ZebraVISION = 15;

    // *METHODS:
    public static int SetGender()
    {
        return Random.Range(0, 1);
    }

    public static float GetErrorValue()
    {
        return Random.Range(-IndicatorsError, IndicatorsError);
    }
}
