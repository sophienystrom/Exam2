using System;

class MainClass {
  public static void Main (string[] args) {
  
  Console.WriteLine("Give radius of cylinder");
  double radius = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Give height of cylinder");
  double height = Convert.ToDouble(Console.ReadLine());
 
  double volume = CylinderVolume(radius, height);

  Console.WriteLine ("The volume of the cylinder is: " + volume);

  }

  public static double CylinderVolume (double radius, double height) {
  double volume = (3.14 * radius * radius * height);
  return volume;
  }
}