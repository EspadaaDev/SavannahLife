using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Animal
{
    // Fields
    protected float maxHealth;      // Maximum health
    protected float maxSpeed;       // Maximum speed of travel
    
    protected float health;         // Current health
    protected float thirst;         // Thirst
    protected float hunger;         // Hunger
    protected float age;            // Age
    protected float speed;          // Current speed

    protected IBehaviour behaviour;

    // Components
    protected GameObject animalUnit;
    protected Animation anim;
    protected NavMeshAgent nvagent;

    public Animal(GameObject _go)
    {
        animalUnit = _go;
        anim = animalUnit.GetComponent<Animation>();
        nvagent = animalUnit.GetComponent<NavMeshAgent>();
    }
}
