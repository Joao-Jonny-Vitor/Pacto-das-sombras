using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static GameManagerScript Instance;

    [SerializeField] public CharacterSO battlePlayer;
    [SerializeField] public CharacterSO battleEnemy;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SceneTransition(CharacterSO player, CharacterSO enemy)
    {
        battlePlayer = player;
        battleEnemy = enemy;
        Debug.Log(battlePlayer.name);
    }
}
