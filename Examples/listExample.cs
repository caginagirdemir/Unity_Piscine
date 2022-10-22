using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listExample : MonoBehaviour
{
    void Start()
    {
        List<string> inventory = new List<string>();
        inventory.Add("Sword");
        inventory.Add("Helmet");
        inventory.Add("Axe");
        inventory.Add("Potion");
        print(inventory[0]);
        print(inventory.Count);
        inventory.Remove("Potion");
        print(inventory.Count);
        inventory.Insert(2, "Potion");
        inventory.Sort();
        inventory.Reverse();
        foreach (var item in inventory)
        {
            print(item);
        }
        inventory.Clear();
    }
}
