using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class TurnManager : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;

    [SerializeField] private ButtonMenuScript PlayerAction;
    [SerializeField] private EnemyActions enemyActions;

    [SerializeField] private CharacterManagerScript playerManager;
    [SerializeField] private CharacterManagerScript enemyManager;

    [SerializeField] private EffectManagerScript effectManager;

    [SerializeField] private TMP_Text turn;

    private void Start()
    {
        TextTurn("Jogador");
    }

    private void Update()
    {
        if (playerManager.GetValue(playerManager.hpSlider) == 0 || enemyManager.GetValue(enemyManager.hpSlider) == 0)
        {
            Application.Quit();
            Disable();
            Debug.Log("Acabou");
        }

        if (PlayerAction.hasTurn == false)
        {
            TextTurn("Inimigo");
            Disable();
            Invoke("EnemyAction", 2.0f);
            PlayerAction.hasTurn = true;
        }
    }

    public void TextTurn(string text)
    {
        turn.SetText("Turno: " + text);
    }

    public void EnemyAction()
    {
        if (PlayerAction.defenseActive == true)
        {
            effectManager.setDefense(true);
            enemyActions.AttackAction();
            effectManager.setDefense(false);
            PlayerAction.defenseActive = false;
        }
        else
        {
            enemyActions.AttackAction();
        }

        Enable();
        TextTurn("Jogador");

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
