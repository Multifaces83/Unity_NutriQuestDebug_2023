using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;
public class PlayerJumpTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerJumpTestsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayerJumpTestsWithEnumeratorPasses()
    {

        yield return new WaitForSeconds(0.1f);
    }
}
