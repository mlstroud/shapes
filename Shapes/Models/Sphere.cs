using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Circle { get; set; }

    public Sphere(Circle circle)
    {
      Circle = circle;
    }

    public int GetSurfaceArea()
    {
      return 0;
    }

    public double GetVolume()
    {
      return Math.Round((4 * Math.PI * (Circle.Radius * Circle.Radius * Circle.Radius)) / 3, 2);
    }
  }
}