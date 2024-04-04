using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FighterAction : MonoBehaviour
{
    private GameObject hero;
    private GameObject enemy;

    [SerializeField]
    private GameObject meleePrefab;

    [SerializeField]
    private GameObject defensePrefab;

    [SerializeField]
    private GameObject abilityPrefab;

    [SerializeField]
    private GameObject magicPrefab;

    [SerializeField]
    private GameObject faceIcon;

<<<<<<< HEAD
    public void SelectAttack(string action){
=======
    private GameObject currentAttack;
    private GameObject meleeAttack;
    private GameObject abilityAttack;
    private GameObject magicAttack;
    private GameObject defensePosition;
    
   
    public void SelectAttack(string btn)
    {
        GameObject victim = hero;
        if(tag == "Hero")
        {
            victim = enemy;
        }
        if (btn.CompareTo("melee") == 0)
        {
            Debug.Log("Melle Attack!");
        }
        else if (btn.CompareTo("defense") == 0)
        {
            Debug.Log("Defense!");
        }
        else if (btn.CompareTo("ability") == 0)
        {
            Debug.Log("Ability Activate");
        }
        else if (btn.CompareTo("magic") == 0)
        {
            Debug.Log("Magic Attack!");
        }
>>>>>>> 6f0fb44bfe30157f684a81c6cd9a7c19e608e9d2

    }
}
