using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class PlayerControllerTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerControllerTestsSimplePasses()
    {
        GameObject go = new GameObject();
        PlayerController controller = go.AddComponent<PlayerController>();

        IJump jump = Substitute.For<IJump>();
        IMove move = Substitute.For<IMove>();

        controller.Initialize(move, jump);
        controller.JumpControlActivated();
        controller.MoveControlActivated(Vector2.zero);

        move.Received().Move(Vector2.zero);
        jump.Received().Jump();


    }
}
