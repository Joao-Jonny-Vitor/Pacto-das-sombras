using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetTextValues : MonoBehaviour
{
    [SerializeField] private CharacterManagerScript characterManager;

    [SerializeField] public TMP_Text hpText;
    [SerializeField] public TMP_Text manaText;

    // Update is called once per frame
    void Update()
    {
        hpText.SetText("HP: " + characterManager.GetValue(characterManager.hpSlider));
        manaText.SetText("MP: " + characterManager.GetValue(characterManager.manaSlider));
    }
}
