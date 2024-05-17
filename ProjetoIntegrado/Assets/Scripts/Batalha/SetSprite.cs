using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSprite : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetSpriteRenderer(GameObject gameObject,Sprite sprite)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    public Sprite GetSprite(CharacterSO character)
    {
        return character.sprite;
    }
}
