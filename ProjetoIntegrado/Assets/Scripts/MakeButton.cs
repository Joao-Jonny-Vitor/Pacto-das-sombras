using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;


public class MakeButton : MonoBehaviour
{
    [SerializeField]
    private int physical;

    private GameObject hero;


    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallback(temp));
        gameObject.GetComponent<Button>().onClick.AddListener(() => InventaryCallback(temp));

        hero = GameObject.FindGameObjectWithTag("Hero");
    }

    private void AttachCallback(string btn)
    {
        if (btn.CompareTo("MeleeBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("melee");

        }else if(btn.CompareTo("DefenseBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("defense");

        }else if(btn.CompareTo("AbilityBtn") ==0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("ability");
        }
        else if(btn.CompareTo("MagicBtn") ==0) 
        {
            hero.GetComponent<FighterAction>().SelectAttack("magic");
        }
    }

    private void InventaryCallback(string btn)
    {
        if (btn.CompareTo("LifePotionBtn") == 0)
        {
            hero.GetComponent<InventaryAction>().SelectItem("lifePotion");
        }
        else if (btn.CompareTo("ManaPotionBtn") == 0)
        {
            hero.GetComponent<InventaryAction>().SelectItem("manaPotion");
        }
        else if (btn.CompareTo("ReforcoStrgBtn") == 0)
        {
            hero.GetComponent<InventaryAction>().SelectItem("reforcoStrg");

        }else if (btn.CompareTo("BombItemBtn") == 0)
        {
            hero.GetComponent<InventaryAction>().SelectItem("bomb");
        }
    }

}