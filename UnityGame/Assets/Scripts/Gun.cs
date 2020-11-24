using UnityEngine;

public sealed class Gun : MonoBehaviour
{
  [SerializeField] private GameObject bulletPrefab;
  [SerializeField] private Transform  output;

  private void Update()
  {
    if (Input.GetMouseButton(0)) Instantiate(bulletPrefab, output.position, output.rotation);
  }
}