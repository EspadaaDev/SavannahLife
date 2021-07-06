using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion : IPredator
{
    float health = 100;
    float attackForce = 30f;
    public float Health
    {
        get
        {
            return health;
        }
    }

    public float Age => throw new System.NotImplementedException();

    public int Gender => throw new System.NotImplementedException();

    public float AttackForce
    {
        get
        {
            return attackForce;
        }
    }

    public void Attacked(float impactForce)
    {
        health -= impactForce;
    }

    public void ChooseTarget()
    {
        throw new System.NotImplementedException();
    }
}
