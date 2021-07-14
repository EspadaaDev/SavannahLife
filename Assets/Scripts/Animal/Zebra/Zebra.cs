using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zebra : Herbivore
{

    private void Awake()
    {
        anim = GetComponent<Animation>();
        nvagent = GetComponent<NavMeshAgent>();

        gender = GameSetups.SetGender();
        maxHealth = GameSetups.ZebraHP * GameSetups.GetErrorValue();
        maxSpeed = GameSetups.ZebraSPEED * GameSetups.GetErrorValue();
        maxAge = GameSetups.ZebraAGE * GameSetups.GetErrorValue();

        health = maxHealth;
        age = 0;
        thirst = 100;
        hunger = 100;
        speed = 0;
        anxiety = 0;
    }
    
    // Die TODO:
    private void Die()
    {

    }

}
