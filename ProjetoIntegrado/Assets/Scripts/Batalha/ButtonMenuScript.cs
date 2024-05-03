using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ButtonMenuScript : MonoBehaviour
{
    [SerializeField] private CharacterSO player;
    [SerializeField] private CharacterSO enemy;

    [SerializeField] private CharacterManagerScript playerManager;
    [SerializeField] private CharacterManagerScript enemyManager;

    [SerializeField] private GameObject AbilityButton1;
    [SerializeField] private GameObject itemButton1;
    [SerializeField] private GameObject mainButtons;

    private float potion = 50;

    public bool hasTurn = true;
    public bool defenseActive = false;
    public bool defenseEffect = false;

    private void Start()
    {
        playerManager.SetMaxValue(player.vida, playerManager.hpSlider);
        playerManager.SetMaxValue(player.mana, playerManager.manaSlider);
        playerManager.SetValue(player.vida, playerManager.hpSlider);
        playerManager.SetValue(player.mana, playerManager.manaSlider);

        enemyManager.SetMaxValue(enemy.vida, enemyManager.hpSlider);
        enemyManager.SetMaxValue(enemy.mana, enemyManager.manaSlider);
        enemyManager.SetValue(enemy.vida, enemyManager.hpSlider);
        enemyManager.SetValue(enemy.mana, enemyManager.manaSlider);
    }

    public void AttackButton(){
        Debug.Log("O " + enemy.nome + " Recebeu: " + player.ataque + " de dano");

        enemyManager.SetMinusValue(player.ataque, enemyManager.hpSlider);
        hasTurn = false;
    }

    public void DefenseButton()
    { 
        defenseActive = true;
        hasTurn = false;
    }

    public void BagButton()
    {
        if (playerManager.hpSlider.maxValue == playerManager.hpSlider.value)
        {
            Debug.Log("Vida cheia");
        }else
        {
            playerManager.SetAddValue(potion, playerManager.hpSlider);
            
            Debug.Log("Jogador usou uma po��o e recuperou " +  potion + " de vida"); 
        }
        hasTurn = false;
    }

    public void AbilityButton()
    {
        Debug.Log("Player usou " + player.skill1.cost + " de mana para usar " + player.skill1.name + " e dar " + 
            (player.ataque * player.skill1.multiplicador) + " de dano");

        enemyManager.SetMinusValue((player.ataque * player.skill1.multiplicador), enemyManager.hpSlider);
        playerManager.SetMinusValue(player.skill1.cost, playerManager.manaSlider);
        hasTurn = false;
    }

    public void ItemButtons()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(itemButton1, new BaseEventData(eventSystem));
    }

    public void AbilityButtons()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(AbilityButton1, new BaseEventData(eventSystem));
        
    }

    public void MainButtons()
    {
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(mainButtons, new BaseEventData(eventSystem));
    }
}
