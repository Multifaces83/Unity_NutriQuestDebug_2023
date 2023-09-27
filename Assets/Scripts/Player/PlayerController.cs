using UnityEngine;
using NaughtyAttributes;
using TNRD;

public class PlayerController : MonoBehaviour
{
    [Header("Mechanics")]
    [SerializeField, Label("Movement")] private SerializableInterface<IMove> _movementSerialized;
    [SerializeField, Label("Jump")] private SerializableInterface<IJump> _jumpSerialized;

    [Header("Input Parameters")]
    [SerializeField, InputAxis] private string _horizontalAxis;
    [SerializeField, InputAxis] private string _verticalAxis;
    [SerializeField, InputAxis] private string _jumpButton;

    // Properties for the interfaces
    private IMove _movement => _movementSerialized.Value;
    private IJump _jump => _jumpSerialized.Value;

    public void Initialize(IMove movement, IJump jump)
    {
        _movementSerialized = new SerializableInterface<IMove>();
        _jumpSerialized = new SerializableInterface<IJump>();

        _movementSerialized.Value = movement;
        _jumpSerialized.Value = jump;
    }
    private void Update()
    {
        // Movement
        // _movement.Move(new Vector2(Input.GetAxisRaw(_horizontalAxis), Input.GetAxisRaw(_verticalAxis)).normalized);
        MoveControlActivated(new Vector2(Input.GetAxisRaw(_horizontalAxis), Input.GetAxisRaw(_verticalAxis)).normalized);

        // Jump
        if (Input.GetButtonDown(_jumpButton))
        {
            //_jump.Jump();
            JumpControlActivated();
        }
    }

    public void JumpControlActivated()
    {
        _jumpSerialized.Value.Jump();
    }
    public void MoveControlActivated(Vector2 movement)
    {
        _movementSerialized.Value.Move(movement);
    }
}
