using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class FoodCollectibleTests
{
    [UnityTest]
    public IEnumerator FoodCollectibleTestsWithEnumeratorPasses()
    {
        GameObject goFood = new GameObject();

        FoodCollectible foodCollectible = goFood.AddComponent<FoodCollectible>();

        IExecute execute = Substitute.For<IExecute>();

        foodCollectible.Initialize(execute);
        foodCollectible.Collect();

        yield return new WaitForSeconds(0.5f);
        Assert.IsTrue(!goFood.activeSelf);
        execute.Received().Execute();
    }
}
