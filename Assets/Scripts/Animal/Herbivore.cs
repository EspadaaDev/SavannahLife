using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Herbivore : Animal
{    
    public override IEnumerator FindingFood()        
    {
        throw new System.NotImplementedException();
    }

    private void Start()
    {
        Do  = new animalBehavior(Wander);
        var a = StartCoroutine(Do.Invoke());
        
    }
    float aTime = 0;
    private void Update()
    {
        aTime += Time.deltaTime;
        if (aTime > 10f && aTime < 15f)
        {
            SetBehaviour(new animalBehavior(FindingWater));
            aTime = 100f;
        }
    }

    private void SetBehaviour(animalBehavior _do)
    {
        StopCoroutine(Do.Invoke());
        Do = _do;
        StartCoroutine(Do.Invoke());
    }
}
