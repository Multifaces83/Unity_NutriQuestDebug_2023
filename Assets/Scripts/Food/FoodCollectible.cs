using NaughtyAttributes;
using TNRD;
using UnityEngine;

/// <summary>
/// Handles the collectible mechanic of foods.
/// </summary>
public class FoodCollectible : MonoBehaviour, ICollect
{
    [SerializeField, Label("Score Effect")] private SerializableInterface<IExecute> _scoreEffectSerialized = default;

    // Properties for the interfaces
    private IExecute _scoreEffect => _scoreEffectSerialized.Value;

    public void Initialize(IExecute scoreEffect)
    {
        _scoreEffectSerialized.Value = scoreEffect;
    }

    /// <summary>
    /// Collects the food.
    /// </summary>

    public void Collect()
    {
        _scoreEffect.Execute();
        gameObject.SetActive(false);
    }
}
