using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private Rigidbody _rigidbody;

   [SerializeField]  private PlayerInput playerInput;

    private void Update()
    {
        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();
        Vector3 movementInput = new(input.x, 0, input.y);
        _rigidbody.linearVelocity = movementInput * speed;
    }
}
