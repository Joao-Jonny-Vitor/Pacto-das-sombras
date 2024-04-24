using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManagerScript : MonoBehaviour
{
    [SerializeField] private CharacterSO player;
    [SerializeField] private CharacterSO enemy;

    public void setDefense(bool defenseActive)
    {
        if (defenseActive)
        {
            enemy.ataque -= player.defesa;
            Debug.Log("ataque do inimigo abaixou em " +  player.defesa + " e ficou " + enemy.ataque);
        }
        
        if (!defenseActive)
        {
            enemy.ataque += player.defesa;
            Debug.Log("ataque do inimigo voltou ao normal e ficou " + enemy.ataque);
        }
    }
}
