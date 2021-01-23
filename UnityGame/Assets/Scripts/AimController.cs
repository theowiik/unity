using UnityEngine;

public sealed class AimController : MonoBehaviour
{
  private const            float     Speed = 400f;
  [SerializeField] private Transform playerBody;
  private                  float     _xRotation;

  private float XRotation
  {
    get => _xRotation;
    set => _xRotation = Mathf.Clamp(value, -90f, 90f);
  }

  private void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void Update()
  {
    var x = Input.GetAxis("Mouse X") * Speed * Time.deltaTime;
    var y = Input.GetAxis("Mouse Y") * Speed * Time.deltaTime;

    XRotation -= y;

    transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
    playerBody.Rotate(Vector3.up * x);
  }
}