using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetTextValues : MonoBehaviour
{
    [SerializeField] private SliderManager characterManager;

    [SerializeField] public TMP_Text hpText;
    [SerializeField] public TMP_Text manaText;

    // Update is called once per frame
    void Update()
    {
        hpText.SetText("HP: " + characterManager.GetMaxValue(characterManager.hpSlider) + "/" + characterManager.GetValue(characterManager.hpSlider));
        manaText.SetText("MP: " + characterManager.GetMaxValue(characterManager.manaSlider) + "/" + characterManager.GetValue(characterManager.manaSlider));
    }
}