using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Skill", menuName = "ScriptableObjects/SkillSO", order = 1)]
public class SkillsSO : ScriptableObject
{
    public string name;
    public int cost;
    public float multiplicador;
    public Sprite imagemSkill;
}
