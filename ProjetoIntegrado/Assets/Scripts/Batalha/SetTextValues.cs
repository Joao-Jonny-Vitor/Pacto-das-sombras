using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetTextValues : MonoBehaviour
{
    public void SetText(TMP_Text textObject, string text, float value)
    {
        textObject.SetText(text, value);
    }
}
