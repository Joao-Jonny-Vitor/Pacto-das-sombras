using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemySO : MonoBehaviour
{
    [SerializeField] public CharacterSO enemySO;

    public CharacterSO GetCharacterSO(){
        return enemySO;
    }
}
