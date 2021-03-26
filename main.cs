using System;
using System.Windows;
namespace Dungeon
{
    public delegate void print(string phrase);
    public delegate int square(int width, int height);
    class Program
    {
        public class TestPrint
        {
            public  string name;
            public  print fn;
        }
        public class TestSquare
        {
            public  string name;
            public  square fn;
        }
        static void Main()
        {
            TestPrint[] testPrint = new TestPrint[3];
            for(int i =0;i < testPrint.Length;i++){
                TestPrint tmp = new TestPrint() {
                    name = $"print{i}",
                    fn = print
                };
                testPrint[i] = tmp;
            }
            for(int i =0;i < testPrint.Length;i++){
                testPrint[i].fn($"le nom associé à cette fonction est {testPrint[i].name}");
            }
            TestSquare[] testSquare = new TestSquare[]
            {
                new TestSquare() { name = "aera", fn = aeraOfSquare},
                new TestSquare() { name = "perimeter", fn = perimeterOfSquare},
            };
            int width = 5;
            int height = 42;
            for(int i = 0;i < testSquare.Length;i++)
                Console.WriteLine($"le nom de la fonction est {testSquare[i].name} et le résult avec {width} en largeur et {height} en hauteur est {testSquare[i].fn(width,height)}");
        }

        static private void print(string phrase)
        {
            Console.WriteLine(phrase);
        }

        static private int aeraOfSquare(int width, int height)
        {
            return width * height;
        }

        static private int perimeterOfSquare(int width, int height)
        {
            return (width * 2) + (height *2);
        }
    }
}