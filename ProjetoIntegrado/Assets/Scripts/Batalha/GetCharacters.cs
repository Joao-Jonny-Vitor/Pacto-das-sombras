using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCharacters : MonoBehaviour
{
    public CharacterSO enemySO;
    public CharacterSO PlayerSO;

    private void Start()
    {
        enemySO = GetComponent<Player_movement>().enemy;
        PlayerSO = GetComponent<GetPlayerSO>().GetCharacterSO();
        Debug.Log(enemySO.name);
        Debug.Log(PlayerSO.name);
    }
}
