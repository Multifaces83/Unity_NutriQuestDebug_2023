using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;
public class PlayerJumpTests
{
    [UnityTest]
    public IEnumerator PlayerJumpTestsWithEnumeratorPasses()
    {
        GameObject go = new GameObject();
        PlayerJump jump = go.AddComponent<PlayerJump>();

        Rigidbody rb = go.AddComponent<Rigidbody>();
        IGrounded grounded = Substitute.For<IGrounded>();
        grounded.Grounded.Returns(true);
        jump.Initialize(rb);
        jump.Jump();

        yield return new WaitForSeconds(0.2f);
        Assert.IsTrue(rb.velocity.y > 0);
        Assert.Greater(rb.velocity.y, 0);

    }
}
