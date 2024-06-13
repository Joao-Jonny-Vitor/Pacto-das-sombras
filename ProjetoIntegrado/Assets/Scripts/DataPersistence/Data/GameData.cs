using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public Vector3 PlayerPosition;
    public bool FirstStart;
    public Dictionary<string, bool> enemyDefeted;
    public GameData()
    {
        PlayerPosition = new Vector3(0.84f, -1.5f, -1.2f);
        FirstStart = true;
        enemyDefeted = new Dictionary<string, bool>();
    }
}