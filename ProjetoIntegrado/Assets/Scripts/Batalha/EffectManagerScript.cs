using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManagerScript : MonoBehaviour
{
    [SerializeField] private GetPlayerSO player;
    [SerializeField] private GetEnemySO enemy;

    public void setDefense(bool defenseActive)
    {
        if (defenseActive)
        {
            enemy.battleEnemy.ataque -= player.battlePlayer.defesa;
            Debug.Log("ataque do inimigo abaixou em " +  player.battlePlayer.defesa + " e ficou " + enemy.battleEnemy.ataque);
        }
        
        if (!defenseActive)
        {
            enemy.battleEnemy.ataque += player.battlePlayer.defesa;
            Debug.Log("ataque do inimigo voltou ao normal e ficou " + enemy.battleEnemy.ataque);
        }
    }
}
