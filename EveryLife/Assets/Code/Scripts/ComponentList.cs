using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class ComponentList : MonoBehaviour
{
    [SerializeField] private int animalQuantity;
    [SerializeField] private GameObject animalPrefab;
    private List<GameObject> animals;
    private GameObject animalsContainer;

    private void Start()
    {
        animalsContainer = GameObject.Find("Animals");

        for(int i = 0; i < animalQuantity; i++)
        {
            GameObject animalCopy = Instantiate<GameObject>(animalPrefab, new Vector3(i, 0, 0), Quaternion.identity);
            animalCopy.transform.parent = animalsContainer.transform;
            animals.Add(animalCopy);
        }
    }
}
