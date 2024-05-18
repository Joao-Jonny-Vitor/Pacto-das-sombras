using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class GetEnemySO : MonoBehaviour
{
    public GameManagerScript gameManagerScript;

    [SerializeField] public CharacterSO battleEnemy;

    private void Awake()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        battleEnemy = gameObject.GetComponent<GameManagerScript>().battleEnemy;
        
    }

    private void Start()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        battleEnemy = gameObject.GetComponent<GameManagerScript>().battleEnemy;
        Debug.Log(battleEnemy.nome);
    }
}
