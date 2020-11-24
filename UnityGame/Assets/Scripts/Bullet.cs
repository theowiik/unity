using UnityEngine;

public sealed class Bullet : MonoBehaviour
{
  private const int MovementSpeed = 15;

  private void Start()
  {
    Destroy(gameObject, 5f);
  }

  private void Update()
  {
    transform.position += transform.forward * MovementSpeed * Time.deltaTime;
  }
}