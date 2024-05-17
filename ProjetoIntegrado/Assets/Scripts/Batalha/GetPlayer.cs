using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer : MonoBehaviour
{
    public static CharacterSO PlayerSO;

    private void Start()
    {
        PlayerSO = GetComponent<GetCharacters>().PlayerSO;
    }
}
