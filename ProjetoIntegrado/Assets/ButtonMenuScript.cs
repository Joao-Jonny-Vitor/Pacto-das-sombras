using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuScript : MonoBehaviour
{
    public void AttackButton(){
        Debug.Log("Ataque");
    }

    public void DefenseButton()
    {
        Debug.Log("Defesa");
    }

    public void BagButton()
    {
        Debug.Log("Mochila Mochila");
    }

    public void AbilityButton()
    {
        Debug.Log("Habilidade");
    }
}
