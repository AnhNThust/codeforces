using System;

namespace Anton_and_Polyhedrons
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                switch (s)
                {
                    case "Tetrahedron":
                        count += 4;
                        break;
                    case "Cube":
                        count += 6;
                        break;
                    case "Octahedron":
                        count += 8;
                        break;
                    case "Dodecahedron":
                        count += 12;
                        break;
                    case "Icosahedron":
                        count += 20;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
