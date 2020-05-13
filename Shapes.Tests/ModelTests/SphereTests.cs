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

      double result = newSphere.GetVolume();

      Assert.AreEqual(result, 523.60);
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      Circle newCircle = new Circle(5);
      Sphere newSphere = new Sphere(newCircle);

      double result = newSphere.GetSurfaceArea();

      Assert.AreEqual(result, 314.16);
    }
  }
}