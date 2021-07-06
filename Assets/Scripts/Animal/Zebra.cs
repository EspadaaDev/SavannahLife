using UnityEngine;

public class Zebra : MonoBehaviour, IHerbivorous
{
    // Fields
    float maxHealth;
    float health;
    float age;
    int gender;
    // Components
    
    // 
    public float Health
    {
        get
        {
            return health;
        }
    }

    public float Age
    {
        get
        {
            return age;
        }
    }

    public int Gender
    {
        get
        {
            return gender;
        }
    }
    // Methods
    private void Awake()
    {
        gender = GameSetups.SetGender();
        maxHealth = GameSetups.ZebraHP * Random.Range(-GameSetups.IndicatorsError, GameSetups.IndicatorsError);
        age = GameSetups.ZebraAGE * Random.Range(-GameSetups.IndicatorsError, GameSetups.IndicatorsError);
        health = maxHealth;
    }
    public void Attacked(float impactForce)
    {
        health -= impactForce;
    }
}
