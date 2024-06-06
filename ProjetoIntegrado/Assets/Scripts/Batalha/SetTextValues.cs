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
        hpText.SetText("HP: " + characterManager.GetValue(characterManager.hpSlider) + "/" + characterManager.GetMaxValue(characterManager.hpSlider));
        manaText.SetText("MP: " + characterManager.GetValue(characterManager.manaSlider) + "/" + characterManager.GetMaxValue(characterManager.manaSlider));
    }
}