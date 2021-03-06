using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public abstract class Animal : MonoBehaviour
{
    // Fields
    protected float maxHealth;      // Maximum health
    protected float maxAge;         // Maximum age
    protected float declaredMaxSpeed;// Declared maximum speed of travel
    protected float maxSpeed;       // Real speed of travel from indicators
    protected int gender;           // Gender

    protected float health;         // Current health
    protected float thirst;         // Thirst
    protected float hunger;         // Hunger
    protected float age;            // Age
    protected float speed;          // Current speed
    protected float anxiety;        // Sense of anxiety
    protected float rageOfVision;   // Animal viewing distance

    float timeOfLife = 0;           // Time of life

    protected delegate IEnumerator animalBehavior();
    protected animalBehavior Do;

    // Components
    protected Animation anim;
    protected NavMeshAgent nvagent;

    // Properties
    public int GetGender { get { return gender; } }
    public float GetCurrentHealth { get { return health; } }
    public float GetAge { get { return age; } }
    public float GetHunger { get { return hunger; } }
    public float GetThirst { get { return thirst; } }

    // - - - PUBLIC METHODS - - -
    public void SetBehavior(string behavior)
    {
        StopCoroutine(Do.Invoke());
        switch (behavior)
        {
            case "Feeding Process":
                Do = new animalBehavior(FeedingProcess);
                break;
            case "Drinking Process":
                Do = new animalBehavior(DrinkingProcess);
                break;
            case "Wander":
                Do = new animalBehavior(Wander);
                break;
        }
        
        StartCoroutine(Do.Invoke());
    }

    // - - - PROTECTED METHODS - - -    
    protected IEnumerator Wander()
    {
        while (true)
        {
            nvagent.SetDestination(transform.position + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)));
            yield return new WaitForSeconds(7);
        }
    }
    protected IEnumerator FeedingProcess()
    {
        nvagent.SetDestination(transform.position + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)));
        yield return new WaitForSeconds(1);
    }
    protected IEnumerator DrinkingProcess()
    {
        while (true)
        {
            nvagent.SetDestination(transform.position + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)));
            yield return new WaitForSeconds(7);
        }
    }


    protected abstract void FindingFood();
    protected void FindingWater()
    {///
        
    }

    protected void Kill()
    {

    }

    protected void GetDamage(float damage)
    {
        health -= damage;
    }
    
    // Indicators of the animal from the course of life
    protected void CourseOfLife()
    {
        // Time of life
        timeOfLife += Time.deltaTime;

        // Age calulated
        age = timeOfLife / 60f;
        // Thirst calculated
        thirst -= GameSetups.thirstRate * Time.deltaTime * speed * GameSetups.movementImpact;
        // Hunger calculated
        hunger -= GameSetups.hungerRate * Time.deltaTime * speed * GameSetups.movementImpact;
        // Max speed calculated
        maxSpeed = declaredMaxSpeed * (health / maxHealth);

        // Diminishing life with hunger and thirst
        if (thirst <= 0)
        {
            thirst = 0;
            health -= Time.deltaTime;
        }
        if (hunger <= 0)
        {
            hunger = 0;
            health -= Time.deltaTime;
        }
        // Death from lack of health
        if (health <= 0)
        {
            Die();
        }
    }
    protected void Die()
    {

    }
}
