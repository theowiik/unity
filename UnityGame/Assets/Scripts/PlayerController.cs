using UnityEngine;

public sealed class PlayerController : MonoBehaviour
{
  private const            int                 MovementSpeed = 14;
  [SerializeField] private CharacterController controller;

  private void Update()
  {
    var x = Input.GetAxis("Vertical");
    var y = Input.GetAxis("Horizontal");

    var movementDirNormalized = transform.forward * x + transform.right * y;

    controller.Move(movementDirNormalized * MovementSpeed * Time.deltaTime);
  }
}