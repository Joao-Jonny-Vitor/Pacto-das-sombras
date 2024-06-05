using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static GameManagerScript Instance;

    [SerializeField] public CharacterSO battlePlayer;
    [SerializeField] public CharacterSO battleEnemy;

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

    public void BattleOver(float vida, float mana)
    {
        battleOver = true;
        battlePlayer.vida = vida;
        battlePlayer.mana = mana;
    }

    public void ExitBattle()
    {
        GameObject player = GameObject.Find("Player");
        PlayerSO playerScript = player.GetComponent<PlayerSO>();

        playerScript.playerSO.vida = battlePlayer.vida;
    }
}
