using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSO : MonoBehaviour
{
    [SerializeField] public CharacterSO playerSO;

    private void Start()
    {

        GameManagerScript gameObject = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        if (gameObject.battleOver == true)
        {
            gameObject.ExitBattle();
            Debug.Log(gameObject.battlePlayer.vida);
            Debug.Log(gameObject.battlePlayer.maxVida);
            Debug.Log("HP: " + playerSO.vida + "/" + playerSO.maxVida);
        }
    }
}
