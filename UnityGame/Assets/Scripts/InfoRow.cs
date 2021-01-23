using UnityEngine;

public sealed class InfoRow : MonoBehaviour
{
  private string _key;
  private string _value;

  public string Key
  {
    get => _key;
    set => _key = value;
  }

  public string Value
  {
    get => _value;
    set => _value = value;
  }
}