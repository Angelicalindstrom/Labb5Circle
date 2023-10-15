using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5Circle
{
    // Angelica Lindström NET.23
    internal class Circle
    { // declared class, named it Circle
        
        //declare variables (private)
        private double _pi = Math.PI;
        private int _Radius;
        private string _name;
      
        
        public Circle(string name, int radius)  // Construktor, parameters name and radius
        {
            
            _name = name;
            _Radius = radius;
            Console.WriteLine(_name + " Skapades och har en radie på " + _Radius );
        }

        public double GetArea() // method that calculates the area of the circle
        {
            double circleArea = (_Radius * _Radius) * _pi; 
            Console.Write($"Räknar ut {_name} area, som blir : " );
            return circleArea;
        } 
        public double GetPerimeter()   // method that calculates the perimeter of the circle
        {
            double circlePerimeter = (_Radius + _Radius) * _pi;
            Console.Write($"Räknar ut {_name} omkrets, som blir : ");
            return circlePerimeter;
        }

        public double GetSphereVolume()  // method that calculates the volume of the sphere
        {
            double sphereVolume = ((4 * _pi) * (_Radius * _Radius * _Radius)) /3;
            Console.Write($"Räknar ut {_name} volym, som om det vore en sfär, då blir det : ");
            return sphereVolume;
        }

        public double GetSphereArea()  // method that calculates the area of the sphere
        {
            double sphereArea = (4 * _pi) * (_Radius * _Radius);
            Console.Write($"Räknar ut {_name} area, som om det vore en sfär, då blir det : ");
            return sphereArea;
        }
     
        
        // used double in all my methods so the value of the calculation would be right
    }
}
