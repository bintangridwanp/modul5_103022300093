﻿internal class Program
{
    class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic temp1 = a;
            dynamic temp2 = b;
            dynamic temp3 = c;
            dynamic hasil = 0;

            if (temp1 > b && temp1 > c)
            {
                hasil = a;
            }
            else if (temp2 > a && temp2 > c)
            {
                hasil = b;
            }
            else
            {
                hasil = c;
            }
            return hasil;
        }

        private static void Main(string[] args)
        {
            PemrosesData pemrosesData = new PemrosesData();

            Console.WriteLine("Masukkan nilai 1: ");
            double nilai1 = 10;
            Console.WriteLine("Masukkan nilai 2: ");
            double nilai2 = 30;
            Console.WriteLine("Masukkan nilai 3: ");
            double nilai3 = 22;
            Console.WriteLine("Nilai terbesar adalah: " + pemrosesData.DapatkanNilaiTerbesar(nilai1, nilai2, nilai3));

        }
    }
}







