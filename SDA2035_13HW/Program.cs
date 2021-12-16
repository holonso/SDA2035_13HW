using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_13HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Пушкина, дом Колотушкина", 18, 15, 6);
            building.Print();

            Console.WriteLine();

            MultiBuilding building1 = new MultiBuilding("ул. Пушкина, дом Колотушкина", 18, 15, 6, 2);
            building1.MultiPrint();

            Console.ReadKey();
        }
    }
    public class Building
    {
        public string Location { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Building(string location, int length, int width, int height)
        {
            Location = location;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Location);
            Console.WriteLine("Длина здания: {0}", Length);
            Console.WriteLine("Ширина здания: {0}", Width);
            Console.WriteLine("Высота здания: {0}", Height);
        }
    }
    public sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }
        public MultiBuilding(string loc, int length, int width, int height, int floor)
            : base(loc, length, width, height)
        {
            Floor = floor;
        }
        public void MultiPrint()
        {
            base.Print();
            Console.WriteLine("Этаж здания: {0}", Floor);
        }
    }
}
