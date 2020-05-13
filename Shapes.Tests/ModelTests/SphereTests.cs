using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.TestTools
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      Circle newCircle = new Circle(5);
      Sphere newSphere = new Sphere(newCircle);

      int result = newSphere.GetVolume();

      Assert.AreEqual(result, 523.60);
    }
  }
}