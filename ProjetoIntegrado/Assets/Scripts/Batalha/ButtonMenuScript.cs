using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuScript : MonoBehaviour
{
    [SerializeField] private CharacterSO player;
    [SerializeField] private CharacterSO enemy;

    [SerializeField] private CharacterManagerScript playerManager;
    [SerializeField] private CharacterManagerScript enemyManager;

    public void AttackButton(){
        //Debug.Log("O " + enemy.nome + "Recebeu: " + player.ataque + " de dano");
        enemyManager.SetMinusValue(player.ataque, enemyManager.hpSlider);
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
        Debug.Log("Player usou " + player.skill1.cost + " de mana para usar " + player.skill1.name + " e dar " + 
            (player.ataque * player.skill1.multiplicador) + " de dano");
        enemyManager.SetMinusValue((player.ataque * player.skill1.multiplicador), enemyManager.hpSlider);
        playerManager.SetMinusValue(player.skill1.cost, playerManager.manaSlider);
    }
}
