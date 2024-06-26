using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ActionsManager : MonoBehaviour
{

    GameManagerScript GameManagerScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();

    [SerializeField] public GetPlayerSO player;
    [SerializeField] private GetEnemySO enemy;

    [SerializeField] private SliderManager playerManager;
    [SerializeField] private SliderManager enemyManager;

    [SerializeField] private GameObject AbilityButton1;
    [SerializeField] private GameObject itemButton1;
    [SerializeField] private GameObject mainButtons;
    [SerializeField] private SetSprite spritePlayer;
    [SerializeField] private SetSprite spriteEnemy;

    private float potion = 50;

    public bool hasTurn = true;
    public bool defenseActive = false;
    public bool defenseEffect = false;

    private void Start()
    {
        playerManager.SetMaxValue(player.battlePlayer.maxVida, playerManager.hpSlider);
        playerManager.SetMaxValue(player.battlePlayer.maxMana, playerManager.manaSlider);
        playerManager.SetValue(player.battlePlayer.vida, playerManager.hpSlider);
        playerManager.SetValue(player.battlePlayer.mana, playerManager.manaSlider);
        spritePlayer.SetCharacterSprite(player.battlePlayer);

        enemyManager.SetMaxValue(enemy.battleEnemy.maxVida, enemyManager.hpSlider);
        enemyManager.SetMaxValue(enemy.battleEnemy.maxMana, enemyManager.manaSlider);
        enemyManager.SetValue(enemy.battleEnemy.vida, enemyManager.hpSlider);
        enemyManager.SetValue(enemy.battleEnemy.mana, enemyManager.manaSlider);
        spriteEnemy.SetCharacterSprite(enemy.battleEnemy);
    }

    public void AttackButton(bool i){
        if (i)
        {
            Debug.Log("O " + enemy.battleEnemy.nome + " Recebeu: " + player.battlePlayer.ataque + " de dano");
            enemyManager.SetMinusValue(player.battlePlayer.ataque, enemyManager.hpSlider);
            hasTurn = false;
            GameManagerScript.Instance.AudioManager.PlaySFX(SFX.PlayerAttack);

        }
        
        if(!i){
            Debug.Log("O " + player.battlePlayer.nome + " Recebeu: " + enemy.battleEnemy.ataque + " de dano");

            playerManager.SetMinusValue(enemy.battleEnemy.ataque, playerManager.hpSlider);
            GameManagerScript.Instance.AudioManager.PlaySFX(SFX.EnemyAttack);

        }
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

    public void AbilityButton(int num)
    {
        if (num == 1)
        {
            Debug.Log("Player usou " + player.battlePlayer.skill1.cost + " de mana para usar " + player.battlePlayer.skill1.name + " e dar " +
            (player.battlePlayer.ataque * player.battlePlayer.skill1.multiplicador) + " de dano");

            enemyManager.SetMinusValue((player.battlePlayer.ataque * player.battlePlayer.skill1.multiplicador), enemyManager.hpSlider);
            playerManager.SetMinusValue(player.battlePlayer.skill1.cost, playerManager.manaSlider);

            GameManagerScript.Instance.AudioManager.PlaySFX(SFX.PlayerAbility);
            GameManagerScript.Instance.AudioManager.PlaySFX(SFX.EnemyHurt);
        }
        else if (num == 2)
        {
            Debug.Log("Player usou " + player.battlePlayer.skill2.cost + " de mana para usar " + player.battlePlayer.skill2.name + " e dar " +
            (player.battlePlayer.ataque * player.battlePlayer.skill2.multiplicador) + " de dano");

            enemyManager.SetMinusValue((player.battlePlayer.ataque * player.battlePlayer.skill2.multiplicador), enemyManager.hpSlider);
            playerManager.SetMinusValue(player.battlePlayer.skill2.cost, playerManager.manaSlider);

            GameManagerScript.Instance.AudioManager.PlaySFX(SFX.PlayerAbility);
            GameManagerScript.Instance.AudioManager.PlaySFX(SFX.EnemyHurt);
        }
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
