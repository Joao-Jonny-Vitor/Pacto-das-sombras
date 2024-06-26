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

    public AudioManager AudioManager;

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

        //GameManagerScript.Instance.AudioManager.StopSFX(SFX.EnvironmentAudioMusic);
        //GameManagerScript.Instance.AudioManager.PlaySFX(SFX.BattleAudio);

    }

    public void BattleOver(float hp, float mp)
    {
        battleOver = true;
        vida = hp;
        mana = mp;
        Debug.Log(mp);

        GameManagerScript.Instance.AudioManager.PlaySFX(SFX.EnemyDeath);
    }

    public void ExitBattle(CharacterSO player)
    {
        player.vida = vida;
        player.mana = mana;
        Debug.Log(mana);
        battleOver = false;
    }
}
