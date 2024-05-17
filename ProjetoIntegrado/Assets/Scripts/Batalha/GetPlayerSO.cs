using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class GetPlayerSO : MonoBehaviour
{
    public GameManagerScript gameManagerScript;

    [SerializeField] public CharacterSO battlePlayer;

    private void Awake()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        battlePlayer = gameObject.GetComponent<GameManagerScript>().battlePlayer;
        Debug.Log(battlePlayer.nome);
    }

    private void Start()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        battlePlayer = gameObject.GetComponent<GameManagerScript>().battlePlayer;
        Debug.Log(battlePlayer.skill1.name);
    }

}
