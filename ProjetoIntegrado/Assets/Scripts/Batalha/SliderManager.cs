using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Slider slider;
    public SliderManager(Slider slider)
    {
        this.slider = slider;
    }

    public void SetMaxValue(float hp)
    {
        slider.maxValue = hp;
    }

    public void SetAddValue(float value)
    {
        slider.value += value;
    }

    public void SetMinusValue(float value)
    {
        slider.value -= value;
    }

    public float GetValue()
    {
        return slider.value;
    }

    public void SetValue(float value)
    {
        slider.value = value;
    }


}
