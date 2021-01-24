using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;

namespace Editor
{
  public sealed class NonGameObjectTest
  {
    [Test]
    public void AddTest()
    {
      var obj = new NonGameObject();
      Assert.AreEqual(obj.Add(1, 1), 2);
    }
  }
}