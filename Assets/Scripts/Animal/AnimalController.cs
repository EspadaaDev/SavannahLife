using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    // Fields
    private List<Animal> allAnimals;
    // Start is called before the first frame update
    private void Awake()
    {
        allAnimals = new List<Animal>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddAnimal(Animal animal)
    {
        allAnimals.Add(animal);
    }
}
