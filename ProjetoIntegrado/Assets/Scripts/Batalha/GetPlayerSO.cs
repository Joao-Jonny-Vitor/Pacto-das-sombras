using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class GetPlayerSO : MonoBehaviour
{
    private GameManagerScript gameManagerScript;

    [SerializeField] public CharacterSO battlePlayer;
    [SerializeField] public CharacterSO DefaultPlayer;

    private void Start()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        if (gameObject != null)
        {
            battlePlayer = gameObject.GetComponent<GameManagerScript>().battleEnemy;
            Debug.Log(battlePlayer.nome);
        }
        else if (gameObject == null)
        {
            battlePlayer = DefaultPlayer;
        }
    }

}
