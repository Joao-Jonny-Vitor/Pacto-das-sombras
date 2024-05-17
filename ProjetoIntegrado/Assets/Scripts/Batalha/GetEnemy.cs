using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemy : MonoBehaviour
{
    public static CharacterSO EnemySO;

    private void Start()
    {
        EnemySO = GetComponent<GetCharacters>().enemySO;
    }
}
