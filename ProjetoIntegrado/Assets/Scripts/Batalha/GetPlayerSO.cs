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
        CharacterSO player = GameObject.Find("GameManager").GetComponent<GameManagerScript>().battlePlayer;
        if (player != null)
        {
            battlePlayer = player;
            Debug.Log(battlePlayer.nome);
        }
        else if (player == null)
        {
            battlePlayer = DefaultPlayer;
        }
    }

}
