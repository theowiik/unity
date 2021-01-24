/// <summary>
///   A class that does not inherit from MonoBehavior.
/// </summary>
public sealed class NonGameObject
{
  public NonGameObject(){}
  
  /// <summary>
  ///   Adds two numbers and returns the total.
  /// </summary>
  /// <param name="number1">First number.</param>
  /// <param name="number2">Second number.</param>
  /// <returns>Returns the sum.</returns>
  public int Add(int number1, int number2)
  {
    return number1 + number2;
  }
}