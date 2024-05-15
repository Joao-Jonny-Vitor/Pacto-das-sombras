using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemy : MonoBehaviour
{
    public static CharacterSO enemySO;
    public Player_movement PlayerMovemntScript;

    private void Start()
    {
        PlayerMovemntScript = GetComponent<Player_movement>();
        enemySO = PlayerMovemntScript.enemy;
        Debug.Log(enemySO.name);
    }
}
