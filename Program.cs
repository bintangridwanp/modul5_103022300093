
﻿class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " Berisi " + storedData[i] + " Yang disimpan pada waktu UTC " + inputDates[i]);
        }
    }

}





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

            double nilai1 = 10;
            double nilai2 = 30;
            double nilai3 = 22;
            Console.WriteLine("Nilai terbesar adalah: " + pemrosesData.DapatkanNilaiTerbesar(nilai1, nilai2, nilai3));

        }
    }
}








