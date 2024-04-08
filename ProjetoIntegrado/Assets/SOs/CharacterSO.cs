using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "ScriptableObjects/CharacterSO", order = 2)]

public class CharacterSO : ScriptableObject
{
    public string nome;

    public float vida;
    public float mana;

    public float ataque;
    public int defesa;

    public SkillsSO skill1;
    public SkillsSO skill2;
}
