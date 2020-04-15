using System;

namespace ResponsiPemrograman2826
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan = new Karyawan(190302123, "Paijo", 10000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", -50000000);


            Console.WriteLine("NIK\t Nama\t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\nAsiiikkk naik gaji nih");

            Console.WriteLine("NIK\t Nama\t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }
}