using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;
using UnityEngine.SceneManagement;
public class PlayerJumpTests
{
    [UnityTest]
    public IEnumerator PlayerJumpTestsWithEnumeratorPasses()
    {
        // GameObject go = new GameObject();
        // PlayerJump jump = go.AddComponent<PlayerJump>();
        // Rigidbody rb = go.AddComponent<Rigidbody>();
        // Debug.Log(rb);

        // IGrounded grounded = Substitute.For<IGrounded>();
        // Debug.Log(grounded);

        // grounded.Grounded.Returns(true);
        // Debug.Log(grounded.Grounded);
        // jump.Initialize(rb, grounded);
        // jump.Jump();

        // yield return new WaitForSeconds(0.2f);
        // Assert.IsTrue(rb.velocity.y > 0);
        // Assert.Greater(rb.velocity.y, 0);

        SceneManager.LoadScene("Assets/Scenes/GameScene.unity");
        yield return new WaitForSeconds(1f);
        GameObject tempGameObject = GameObject.Find("Player");
        PlayerJump playerjump = tempGameObject.GetComponentInChildren<PlayerJump>();
        Rigidbody rb = tempGameObject.GetComponent<Rigidbody>();
        float InitialYVelocity = rb.velocity.y;
        float InitialPosY = rb.position.y;

        playerjump.Jump();
        yield return new WaitForSeconds(0.2f);

        Assert.IsTrue(rb.velocity.y > 0);
        Assert.Greater(rb.velocity.y, 0);
        Assert.Greater(rb.position.y, InitialPosY);
        Assert.Greater(rb.velocity.y, InitialYVelocity);

    }
}