using System.Collections;
using NUnit.Framework;
using PlayerMovementScript;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class PlayModeMovement : InputTestFixture
{
    public Vector2 playerPosition;
    public Keyboard keyboard;
    public GameObject player;
    public Player_movement playerMovement;

    // Teste simples para garantir que a cena é carregada
    [Test]
    public void PlayModeMovementSimplePasses()
    {
        SceneManager.LoadScene("Assets/Scenes/StartZone.unity", LoadSceneMode.Single);
    }

    // Teste que simula a movimentação pressionando a tecla W
    [UnityTest]
    public IEnumerator PlayModeMovementWithEnumeratorPasses()
    {
        // Configura o teclado virtual
        keyboard = InputSystem.AddDevice<Keyboard>();

        // Encontra o jogador na cena
        player = GameObject.Find("Player");
        Assert.IsNotNull(player, "Player not found in the scene.");

        // Configura a velocidade do jogador
        playerMovement = player.GetComponent<Player_movement>();
        playerMovement.speed = 5f;

        playerPosition = player.transform.position;

        Debug.Log(keyboard.wKey);
        // Simula o pressionamento da tecla W
        Press(keyboard.wKey);
        yield return new WaitForSeconds(2f); // Espera um segundo para aplicar a movimentação
        Release(keyboard.wKey);
        yield return new WaitForSeconds(2f);

        Debug.Log(player.name);

        // Verifica se o jogador se moveu para cima
        Assert.AreNotEqual(playerPosition, player.transform.position, "Player did not move.");
        Assert.IsTrue(playerMovement.animator.GetBool("isUp"), "Animator did not update to isUp.");
    }

    // Teste que simula a movimentação pressionando a tecla S
    [UnityTest]
    public IEnumerator PlayModeMovementWithEnumeratorPasses2()
    {
        SceneManager.LoadScene("Assets/Scenes/StartZone.unity", LoadSceneMode.Single);
        // Configura o teclado virtual
        keyboard = InputSystem.AddDevice<Keyboard>();
        Assert.IsNotNull(keyboard, "Keyboard not found in the scene.");

        // Encontra o jogador na cena
        player = GameObject.Find("Player");
        Assert.IsNotNull(player, "Player not found in the scene.");

        // Configura a velocidade do jogador
        playerMovement = player.GetComponent<Player_movement>();
        playerMovement.speed = 5f;
        Debug.Log(playerMovement.speed);


        Debug.Log(keyboard.sKey);
        // Simula o pressionamento da tecla W
        Press(keyboard.sKey);
        yield return new WaitForSeconds(1f); // Espera um segundo para aplicar a movimentação
        Release(keyboard.sKey);
    }

}
