using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurnManager : MonoBehaviour
{
    private BattleControl battleControl;

    private void Start()
    {
        battleControl = new BattleControl();
    }

    public void disable()
    {
        battleControl.MoveMenu.Disable();
    }
}
