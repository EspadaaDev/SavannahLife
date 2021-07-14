using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Herbivore : Animal
{
    protected override void FindingFood()
    {
        throw new System.NotImplementedException();
    }
    private void Start()
    {
        var a = StartCoroutine(Do.Invoke());
        
    }
    float aTime = 0;
    private void Update()
    {
        aTime += Time.deltaTime;
        if (aTime > 10f && aTime < 15f)
        {
            aTime = 100f;
        }
    }
}
