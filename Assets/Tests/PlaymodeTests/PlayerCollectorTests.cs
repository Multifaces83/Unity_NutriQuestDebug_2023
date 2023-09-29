using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class PlayerCollectorTests
{
    [UnityTest]
    public IEnumerator PlayerCollectorTestsWithEnumeratorPasses()
    {
        GameObject goPlayer = new GameObject();
        GameObject goFood = new GameObject();
        Transform playerPosition = goPlayer.transform;
        Transform goFoodPosition = goFood.transform;

        goFoodPosition.position = new Vector3(0, 0, 1.2f);
        //goFoodPosition.position = playerPosition.position + new Vector3(0, 0, 1f);

        PlayerCollector playerCollector = goPlayer.AddComponent<PlayerCollector>();
        FoodCollectible foodCollectible = goFood.AddComponent<FoodCollectible>();
        Collider collider = goFood.AddComponent<BoxCollider>();
        collider.isTrigger = true;
        //playerCollector._detectorLength = 3f;

        Debug.Log(playerPosition.position);
        Debug.Log(goFoodPosition.position);
        playerCollector.RaycastToCollectible();

        yield return new WaitForSeconds(0.5f);

        Assert.IsTrue(!goFood.activeInHierarchy);
    }
}