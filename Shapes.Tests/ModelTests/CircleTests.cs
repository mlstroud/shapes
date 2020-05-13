using Microsoft.VisualStudio.TestTools.UnitTesting;

using Shapes.Models;

namespace Shapes.TestTools
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      Circle newCircle = new Circle(5);

      int result = newCircle.GetDiameter();

      Assert.AreEqual(result, 10);
    }

    [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
      Circle newCircle = new Circle(5);

      double result = newCircle.GetCircumference();

      Assert.AreEqual(result, 31.42);
    }
  }
}