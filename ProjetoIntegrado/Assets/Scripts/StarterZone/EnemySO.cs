using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySO : MonoBehaviour
{
    [SerializeField] public CharacterSO enemySO;

    public CharacterSO GetCharacterSO(){
        return enemySO;
    }
}
