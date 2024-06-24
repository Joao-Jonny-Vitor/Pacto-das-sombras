using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/CharacterSO", order = 2)]

public class CharacterSO : ScriptableObject
{
    public string nome;
    public Sprite sprite;
    public Sprite portrait;

    public float maxVida;
    public float vida;
    public float maxMana;
    public float mana;

    public float ataque;
    public int defesa;

    public SkillsSO skill1;
    public SkillsSO skill2;
    public SkillsSO skill3;
    public SkillsSO skill4;
}
