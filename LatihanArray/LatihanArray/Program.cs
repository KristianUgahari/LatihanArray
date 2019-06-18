using System;

namespace LatihanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat array sekaligus inisialisasi nilai
            string[] arrNama = { "kristian", "ugahari", "dwipa" };

            //menampilkan elemen array index ke 2
            Console.WriteLine(arrNama[2].ToString() + "\n");

            //menampilkan semua elemen array
            for (int i=0; i<arrNama.Length; i++)
            {
                Console.WriteLine(arrNama[i]);
            }
            Console.WriteLine(); //cetak baris kosong

            //menampilkan semua elemen array menggunakan foreach
            foreach (string nama in arrNama)
            {
                Console.WriteLine(); //cetak baris kosong

                //membuat array
                int[] arrBil = new int[3];

                //inisialisasi nilai array
                arrBil[0] = 12;
                arrBil[1] = 24;
                arrBil[2] = 48;

                //menampilkan semua elemen array menggunakan foreach
                foreach (int bil in arrBil)
                {
                    Console.WriteLine(bil.ToString());
                }

                Console.ReadKey();
            }
        }
    }
}
