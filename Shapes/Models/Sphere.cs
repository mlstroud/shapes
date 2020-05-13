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

    public double GetSurfaceArea()
    {
      return Math.Round(4 * Math.PI * Math.Pow(Circle.Radius, 2), 2);
    }

    public double GetVolume()
    {
      return Math.Round((4 * Math.PI * (Circle.Radius * Circle.Radius * Circle.Radius)) / 3, 2);
    }
  }
}