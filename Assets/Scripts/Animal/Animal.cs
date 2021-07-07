using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // Fields
    [Header("Base values:")]
    [SerializeField] protected float maxHealth;      // Maximum health
    [SerializeField] protected float maxSpeed;       // Maximum speed of travel

    [Header("State:")]
    [SerializeField] protected float health;         // Current health
    [SerializeField] protected float thirst;         // Thirst
    [SerializeField] protected float hunger;         // Hunger
    [SerializeField] protected float age;            // Age
    [SerializeField] protected float speed;          // Current speed

    protected enum stateOfMind
    {
        Calm,
        Fear,
        Thrist,
        Hunger
    }

    // Components
    protected Animator animator;

    // Methods
    protected void InitializeComponents()
    {
        animator = GetComponent<Animator>();
    }
    protected IEnumerator Drink()
    {
        yield return null;
    }

    protected IEnumerator Eat()
    {
        yield return new WaitForSeconds(3);
    }

    protected abstract void FindTarget();

}
