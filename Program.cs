/*Interface is much like a parent class 
 Interface = define a "Contract"that all the classes inherating from should follow
 An interface declare "what a class should have"
an inheriting class defines "How it should do it"

Some of the benifits of using interface are Security+Multiple inheritance + "Plug and play"
 */

using System;
namespace learninginterface
{
    interface IShape
    {
        int Area(int a, int b);
        int Perimeter(int a, int b);
    }
    public class Square1 : IShape
    {
        public int Area(int a, int b)
        {
            return a*b;
        }
        public int Perimeter(int a,int b)
        {
            return 4*a;
        }
    }
    public class Rectangle : IShape
    {
        public int Area(int a,int b)
        {
            return a*b;
        }
        public int Perimeter (int a,int b)
        {
            return 2*(a*b);
        }
    }
    public class  static void Main()
    {
        Square1 square = new Square1();
        
        Console.WriteLine("");
    }
}