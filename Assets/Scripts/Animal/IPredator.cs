using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPredator : IAnimal
{
    public float AttackForce { get; }
    public void ChooseTarget();
}
