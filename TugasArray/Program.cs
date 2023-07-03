using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrNama = { "Erik", "Wely", "Sony"};
            int[] arrNim = { 1234, 2657, 3434 };
            int[] arrNilai = { 75, 80, 95};


            Console.WriteLine("No   " + "Nama     NIM     Nilai");
            Console.WriteLine("===============================");

            //menampilkan semua elemen array
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine((i + 1) + ".   " + arrNama[i] + "     " + arrNim[i] + "     " + arrNilai[i]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
