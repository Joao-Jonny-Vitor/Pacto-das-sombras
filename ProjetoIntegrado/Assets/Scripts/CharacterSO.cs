using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/CharacterSO", order = 2)]

public class CharacterSO : ScriptableObject
{
    public string nome;
    public Sprite sprite;

    public float vida;
    public float mana;

    public float ataque;
    public int defesa;

    public SkillsSO skill1;
    public SkillsSO skill2;
}
