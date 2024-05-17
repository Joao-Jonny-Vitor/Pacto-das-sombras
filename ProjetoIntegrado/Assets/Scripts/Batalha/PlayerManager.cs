using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] public TMP_Text hp;
    [SerializeField] public TMP_Text mp;

    [SerializeField] public Slider hpSliderObject;
    [SerializeField] public Slider mpSliderObject;

    [SerializeField] public GameObject sprite;

    public SetTextValues mpValue;
    public SetTextValues hpValue;
    public SliderManager hpSlider;
    public SliderManager mpSlider;

    public CharacterSO playerSO;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        playerSO = GetComponent<GetPlayerSO>().GetCharacterSO();
        hpSlider = new SliderManager(hpSliderObject);
        mpSlider = new SliderManager(mpSliderObject);
        hpValue = new SetTextValues();
        mpValue = new SetTextValues();
        SetTexts();
        sprite.GetComponent<SetSprite>().SetSpriteRenderer(sprite, sprite.GetComponent<SetSprite>().GetSprite(playerSO));
    }

    // Update is called once per frame
    void Update()
    {
        SetTexts();
    }

    private void SetTexts()
    {
        hpValue.SetText(hp, "HP: ", hpSlider.GetValue());
        mpValue.SetText(mp, "MP: ", mpSlider.GetValue());
    }
}
