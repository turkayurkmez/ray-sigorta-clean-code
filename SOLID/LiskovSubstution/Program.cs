// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
/*
 * Bir nesne, bir başkasına miras veriyorsa; bu iki nesne birbirlerinin yerine kullanılabilir olmalı.
 * Miras alan nesne; miras veren nesnenin davranışına müdahale etmemeli.
 */

var rectangle = Geometry.GetRectangleOrSquare(12);
//rectangle.Width = 10;
//rectangle.Height = 8;
Console.WriteLine(rectangle.GetArea());