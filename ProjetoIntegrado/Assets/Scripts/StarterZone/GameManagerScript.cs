using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static GameManagerScript Instance;

    [SerializeField] public CharacterSO battlePlayer;
    [SerializeField] public CharacterSO battleEnemy;
    private float vida;
    private float mana;

    public bool battleOver = false;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SceneTransition(CharacterSO player, CharacterSO enemy)
    {
        battlePlayer = player;
        battleEnemy = enemy;
        Debug.Log(battlePlayer.name);
    }

    public void BattleOver(float hp, float mp)
    {
        battleOver = true;
        vida = hp;
        mana = mp;
    }

    public void ExitBattle(CharacterSO player)
    {
        player.vida = vida;
        player.mana = mana;
        battleOver = false;
    }
}
