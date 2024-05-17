using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSprite : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetCharacterSprite(CharacterSO character)
    {
        GetComponent<SpriteRenderer>().sprite = character.sprite;
    }

    
}
