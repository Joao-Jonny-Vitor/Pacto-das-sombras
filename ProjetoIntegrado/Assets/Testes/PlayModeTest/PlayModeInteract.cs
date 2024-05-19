using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;
using PlayerMovementScript;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class PlayModeInteract : InputTestFixture
{
    public Vector2 playerPosition;
    public Keyboard keyboard;
    public GameObject player;
    public Player_movement playerMovement;

    public override void TearDown()
    {
        base.TearDown();
    }

    // Teste que simula a movimentação pressionando a tecla W
    [UnityTest]
    public IEnumerator PlayModeTestInteract()
    {
        SceneManager.LoadScene("Assets/Scenes/StartZone.unity", LoadSceneMode.Single);
        yield return new WaitForSeconds(2f);

        // Configura o teclado virtual
        keyboard = InputSystem.AddDevice<Keyboard>();

        // Encontra o jogador na cena
        player = GameObject.Find("Player");
        Assert.IsNotNull(player, "Player not found in the scene.");

        // Configura a velocidade do jogador
        playerMovement = player.GetComponent<Player_movement>();
        playerMovement.speed = 5f;

        Debug.Log(playerMovement.interactingObject);
        // Simula o pressionamento da tecla W
        Press(keyboard.wKey);
        yield return new WaitForSeconds(1f);
        Release(keyboard.wKey);
        yield return new WaitForSeconds(1f);

        Press(keyboard.eKey);
        yield return new WaitForSeconds(2f);
        Release(keyboard.eKey);

        yield return new WaitForSeconds(2f);
    }
}
