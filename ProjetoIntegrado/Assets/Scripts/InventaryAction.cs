using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventaryAction : MonoBehaviour
{
    private GameObject hero;
    private GameObject enemy;
    

    public void SelectItem(string btn)
    {
        GameObject victim = hero;
        if(tag == "Hero")
        {
            victim = enemy;
        }
        if(btn.CompareTo("lifePotion") == 0)
        {
            Debug.Log("Life Potion Used!");
        }
        if (btn.CompareTo("manaPotion") == 0) 
        {
            Debug.Log("Mana Potion Used!");
        }


    }

}
