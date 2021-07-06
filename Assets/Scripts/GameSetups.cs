using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSetups 
{
    // Setups
    // Maximum error of indicators when creating an animal
    public static float IndicatorsError = 0.2f;
    // Animals
    // Lion

    // Zebra
    public static float ZebraHP = 100f;
    public static float ZebraAGE = 20f;

    // Methods
    public static int SetGender()
    {
        return Random.Range(0, 1);
    }
}
