using UnityEngine;
using UnityEngine.Scripting;

public sealed class Gun : MonoBehaviour
{
  [SerializeField] private GameObject bulletPrefab;
  [SerializeField] private Transform  output;
  [SerializeField] private UnityTimer shootDelayTimer;

  private bool IsHoldingTrigger => Input.GetMouseButton(0);

  private bool ShootDelayFinished => shootDelayTimer.Finished;

  private void Update()
  {
    if (IsHoldingTrigger && ShootDelayFinished)
    {
      Shoot();
      StartShootDelay();
    }
  }

  private void Shoot()
  {
    Instantiate(bulletPrefab, output.position, output.rotation);
  }

  private void StartShootDelay()
  {
    shootDelayTimer.StartTimer();
  }
}