using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public static class Geometry
    {
        public static IArea GetRectangleOrSquare(int unit1, int? unit2=null)
        {
            //bu satırdan öncesi hayal gücünüze bırakılmıştır...
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }

            return new Square() { Edge = unit1}; 
        }



    }

    public interface IArea
    {
        int GetArea();
    }
    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;

    }

    public class Square : IArea //: Rectangle
    {
        public int Edge { get; set; }

        public int GetArea() => Edge * Edge;



    }
}
