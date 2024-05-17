using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerSO : MonoBehaviour
{
    [SerializeField] public CharacterSO playerSO;

    public CharacterSO GetCharacterSO()
    {
        return playerSO;
    }
}
