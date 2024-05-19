using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using PlayerMovementScript;
using UnityEngine.SceneManagement;

public class MovementTest
{
    private GameObject player;
    private Player_movement playerMovement;
    public Rigidbody2D rb;
    private Vector2 direction;
    public Animator animator;

    [SetUp]
    public void SetUp()
    {
        player = new GameObject("Player");
        playerMovement = player.AddComponent<Player_movement>();
        rb = player.AddComponent<Rigidbody2D>();
        animator = player.AddComponent<Animator>();
    }

    // A Test behaves as an ordinary method
    [Test]
    public void MovementTestSimplePasses()
    {
        Assert.IsNotNull(rb, "Rigidbody2D is Null.");
        Assert.IsNotNull(animator, "animator is Null.");
        Assert.IsNotNull(playerMovement, "playerMovement is Null.");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MovementTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

}
