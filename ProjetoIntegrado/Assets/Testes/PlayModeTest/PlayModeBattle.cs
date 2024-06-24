using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class PlayModeBattle : InputTestFixture
{
    public Keyboard keyboard;

    public override void TearDown()
    {
        // Make sure to remove the device after the test
        if (keyboard != null)
        {
            Debug.Log("Removing keyboard device.");
            InputSystem.RemoveDevice(keyboard);
        }
        base.TearDown();
    }

    // Test that simulates movement by pressing the W key
    [UnityTest]
    public IEnumerator PlayModeTestBattleInteract()
    {
        Debug.Log("Loading scene...");
        SceneManager.LoadScene("Assets/Scenes/batalha.unity", LoadSceneMode.Single);
        yield return new WaitForSeconds(2f);

        Debug.Log("Disabling unpaired device activity listening.");
        InputUser.listenForUnpairedDeviceActivity = 0;

        Debug.Log("Scene loaded. Configuring the virtual keyboard.");
        keyboard = InputSystem.AddDevice<Keyboard>();
        Assert.IsNotNull(keyboard, "Failed to add keyboard device.");
        Debug.Log("Keyboard device added successfully.");

        // Simulate pressing the D key
        Debug.Log("Pressing the D key.");
        Press(keyboard.dKey);
        yield return new WaitForSeconds(3f);
        Release(keyboard.dKey);
        Debug.Log("Released the D key.");
    }
}
