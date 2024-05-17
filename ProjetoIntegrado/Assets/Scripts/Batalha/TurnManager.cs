using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurnManager : MonoBehaviour
{

    [SerializeField] private PlayerInput playerInput;

    public PlayerManager playerManager;
    public EnemyManager enemyManager;

    //[SerializeField] private EffectManagerScript effectManager;

    [SerializeField] private TMP_Text turn;

    private bool HasTurn = true;

    private void Awake()
    {
        
    }

    private void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        enemyManager = GetComponent<EnemyManager>();
        TextTurn("Jogador");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager.hpSlider.GetValue() == 0 || enemyManager.hpSlider.GetValue() == 0)
        {
            Application.Quit();
            Disable();
            Debug.Log("Acabou");
        }

        if (HasTurn == false)
        {
            TextTurn("Inimigo");
            Disable();
            Invoke("AttackOption", 2.0f);
            HasTurn = true;
        }
    }

    public void AttackOption()
    {
        if (HasTurn == false)
        {
            playerManager.hpSlider.SetMinusValue(enemyManager.enemySO.ataque);
        }
        else
        {
            enemyManager.hpSlider.SetMinusValue(playerManager.playerSO.ataque);
            HasTurn = false;
        } 
    }

    public void DefenseOption()
    {
        Debug.Log("Defesa");
        HasTurn = false;
    }

    public void AbilityOption(int i)
    {
        switch (i)
        {
            case 1:
                enemyManager.hpSlider.SetMinusValue((playerManager.playerSO.ataque * playerManager.playerSO.skill1.multiplicador));
                playerManager.mpSlider.SetMinusValue(playerManager.playerSO.skill1.cost);
                break;
            case 2:
                enemyManager.hpSlider.SetMinusValue((playerManager.playerSO.ataque * playerManager.playerSO.skill2.multiplicador));
                playerManager.mpSlider.SetMinusValue(playerManager.playerSO.skill2.cost);
                break;
            case 3:
                enemyManager.hpSlider.SetMinusValue((playerManager.playerSO.ataque * playerManager.playerSO.skill3.multiplicador));
                playerManager.mpSlider.SetMinusValue(playerManager.playerSO.skill3.cost);
                break;
            case 4:
                enemyManager.hpSlider.SetMinusValue((playerManager.playerSO.ataque * playerManager.playerSO.skill4.multiplicador));
                playerManager.mpSlider.SetMinusValue(playerManager.playerSO.skill4.cost);
                break;
        }
        HasTurn = false;
    }

    public void ItemOption(int i)
    {
        switch (i)
        {
            case 1:
                playerManager.hpSlider.SetAddValue(50);
                break;
        }
        HasTurn = false;
    }

    public void TextTurn(string text)
    {
        turn.SetText("Turno: " + text);
    }
    public void Disable()
    {
        playerInput.currentActionMap.Disable();
    }

    public void Enable()
    {
        playerInput.currentActionMap.Enable();
    }
}
