using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderManager : MonoBehaviour
{
    [SerializeField] public Slider hpSlider;
    [SerializeField] public Slider manaSlider;

    public void SetMaxValue(float hp, Slider slider)
    {
        slider.maxValue = hp;
    }

    public void SetAddValue(float value, Slider slider)
    {
        slider.value += value;
    }

    public void SetMinusValue(float value, Slider slider)
    {
        slider.value -= value;
    }

    public float GetValue(Slider slider)
    {
        return slider.value;
    }

    public float GetMaxValue(Slider slider)
    {
        return slider.maxValue;
    }


    public void SetValue(float value, Slider slider)
    {
        slider.value = value;
    }


}
