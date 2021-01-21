using UnityEngine;
using UnityEngine.UI;

public sealed class HealthBar : MonoBehaviour
{
  [SerializeField] private Slider slider;

  /// <summary>
  ///   Percentage of how much the health bar should be filled.
  /// </summary>
  public float Percentage { get; set; }
}