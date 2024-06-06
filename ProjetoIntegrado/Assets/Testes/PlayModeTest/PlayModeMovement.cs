using System.Collections;
using NUnit.Framework;
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

    // Teste que simula a movimentação pressionando a tecla W
    [UnityTest]
    public IEnumerator PlayModeTestMoveUp()
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

        playerPosition = player.transform.position;

        // Simula o pressionamento da tecla W
        Press(keyboard.wKey);
        yield return new WaitForSeconds(2f); // Espera um segundo para aplicar a movimentação
        Release(keyboard.wKey);
        yield return new WaitForSeconds(2f);

        // Verifica se o jogador se moveu para cima
        Assert.AreNotEqual(playerPosition, player.transform.position, "Player did not move.");
        Assert.IsTrue(playerMovement.animator.GetBool("isUp"), "Animator did not update to isUp.");
    }

    // Teste que simula a movimentação pressionando a tecla S
    [UnityTest]
    public IEnumerator PlayModeTestMoveDown()
    {
        SceneManager.LoadScene("Assets/Scenes/StartZone.unity", LoadSceneMode.Single);
        yield return new WaitForSeconds(2f);

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

        // Verifica se o jogador se moveu para cima
        Assert.AreNotEqual(playerPosition, player.transform.position, "Player did not move.");
        Assert.IsTrue(playerMovement.animator.GetBool("isDown"), "Animator did not update to isDown.");
    }

    // Teste que simula a movimentação pressionando a tecla S
    [UnityTest]
    public IEnumerator PlayModeTestMoveLeft()
    {
        SceneManager.LoadScene("Assets/Scenes/StartZone.unity", LoadSceneMode.Single);
        yield return new WaitForSeconds(2f);

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

        // Simula o pressionamento da tecla W
        Press(keyboard.aKey);
        yield return new WaitForSeconds(1f); // Espera um segundo para aplicar a movimentação
        Release(keyboard.aKey);

        // Verifica se o jogador se moveu para cima
        Assert.AreNotEqual(playerPosition, player.transform.position, "Player did not move.");
        Assert.IsTrue(playerMovement.animator.GetBool("isLeft"), "Animator did not update to isLeft.");
    }

    // Teste que simula a movimentação pressionando a tecla S
    [UnityTest]
    public IEnumerator PlayModeTestMoveRight()
    {
        SceneManager.LoadScene("Assets/Scenes/StartZone.unity", LoadSceneMode.Single);
        yield return new WaitForSeconds(2f);

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

        // Simula o pressionamento da tecla W
        Press(keyboard.dKey);
        yield return new WaitForSeconds(1f); // Espera um segundo para aplicar a movimentação
        Release(keyboard.dKey);

        // Verifica se o jogador se moveu para cima
        Assert.AreNotEqual(playerPosition, player.transform.position, "Player did not move.");
        Assert.IsTrue(playerMovement.animator.GetBool("isRight"), "Animator did not update to isRight.");
    }

}
