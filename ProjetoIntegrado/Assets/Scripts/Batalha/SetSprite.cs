using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSprite : MonoBehaviour
{
    [SerializeField] private CharacterSO character;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = character.sprite;
    }

    
}
