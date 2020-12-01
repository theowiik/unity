using UnityEngine;

public sealed class UnityTimer : MonoBehaviour
{
  public delegate void OnTimeoutDelegate();

  [SerializeField] [Range(0, 1000)] private float seconds;
  private                                   float _timeRan;

  public OnTimeoutDelegate OnTimeout;

  public bool Running  { get; private set; }
  public bool Finished => !Running;

  private void Start()
  {
    Running  = false;
    _timeRan = 0;
  }

  private void Update()
  {
    _timeRan += Time.deltaTime;

    if (_timeRan >= seconds && Running)
    {
      Running = false;
      OnTimeout();
    }
  }

  /// <summary>
  ///   Starts the countdown timer.
  /// </summary>
  public void StartTimer()
  {
    _timeRan = 0;
    Running  = true;
  }
}