using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("", 0, 0, 0);
            Multibuilding multibuilding1 = new Multibuilding("", 0, 0, 0, 0);
            
            building1.GetBuilding();
            building1.Print();

            multibuilding1.GetMultiBuilding();
            multibuilding1.PrintMulti();
            Console.ReadKey();
        }
    }
    public class Building
    {
        public void GetBuilding()
        {
            Console.WriteLine("введите адрес, Д, Ш, В:");
            adress = Convert.ToString(Console.ReadLine());
            lenght = Convert.ToDouble(Console.ReadLine());
            width = Convert.ToDouble(Console.ReadLine());
            height = Convert.ToDouble(Console.ReadLine());
        }

        public string adress { get; set; }
        public double lenght { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        public Building(string adress, double lenght, double width, double height)
        {

        }
        public void Print()
        {
            Console.WriteLine($"\nИнформация о здании:\nАдрес: {adress}");
            Console.WriteLine($"Длина: {lenght}");
            Console.WriteLine($"Ширина: {width}");
            Console.WriteLine($"Высота: {height}");
        }
    }

    sealed class Multibuilding : Building
    {
        public Multibuilding(string adress, double lenght, double width, double height, int floor)
            : base(adress, lenght, width, height)
        {

        }

        public int floor { get; set; }

        public void GetMultiBuilding()
        {
            Console.Write("\nДля 2 здания ");
            base.GetBuilding();
            Console.WriteLine("введите этажнсть:");
            floor = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintMulti()
        {
            base.Print();
            Console.WriteLine($"Этажность: {floor}");
        }

    }
}
