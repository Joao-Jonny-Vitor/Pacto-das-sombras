using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class GetEnemySO : MonoBehaviour
{
    private GameManagerScript gameManagerScript;

    [SerializeField] public CharacterSO battleEnemy;
    [SerializeField] public CharacterSO DefaultEnemy;

    private void Start()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        if(gameObject != null)
        {
            battleEnemy = gameObject.GetComponent<GameManagerScript>().battleEnemy;
            Debug.Log(battleEnemy.nome);
        }else if (gameObject == null)
        {
            battleEnemy = DefaultEnemy;
        }

    }
}
