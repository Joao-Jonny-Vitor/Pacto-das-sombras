using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSO : MonoBehaviour
{
    [SerializeField] public CharacterSO playerSO;

    private void Start()
    {

        GameManagerScript gameManager = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        if (gameManager.battleOver == true)
        {
            gameManager.ExitBattle(playerSO);
            Debug.Log("MP: " + playerSO.mana + "/" + playerSO.maxMana);
            Debug.Log("HP: " + playerSO.vida + "/" + playerSO.maxVida);
        }
    }
}
