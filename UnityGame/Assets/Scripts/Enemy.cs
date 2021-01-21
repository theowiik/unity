using UnityEngine;

public sealed class Enemy : MonoBehaviour, IDamageable
{
  private int _health = 100;

  public void DealDamage(int amount)
  {
    _health -= amount;
  }
}