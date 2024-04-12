using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour
{
    [SerializeField] private CharacterSO player;
    [SerializeField] private CharacterSO enemy;

    [SerializeField] private CharacterManagerScript playerManager;
    [SerializeField] private CharacterManagerScript enemyManager;

    private bool hasTurn = false;

    public void AttackAction()
    {
        Debug.Log("O " + player.nome + " Recebeu: " + enemy.ataque + " de dano");
        enemyManager.SetMinusValue(enemy.ataque, playerManager.hpSlider);
        hasTurn = false;
    }
}
