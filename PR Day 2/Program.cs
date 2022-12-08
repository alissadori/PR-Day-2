using System;

namespace PR_Day_2
{
    internal class Program
    {
        public void GradeNilai(int x)
        {

            if (x >= 80 && x <= 100)
            {
                Console.WriteLine("Grade A");
            }

            else if (x >= 60 && x < 80)
            {
                Console.WriteLine("Grade B");
            }

            else if (x < 60 && x >= 0)
            {
                Console.WriteLine("Grade C");
            }

            else
            {
                Console.WriteLine("Nilai tidak sesuai");
            }
        }

        public int CekAngka(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Angka " + a + " adalah genap");
            }

            else
            {
                Console.WriteLine("Angka " + a + "adalah ganjil");
            }

            return a;
        }


        public void PoinPulsa(int pulsa)
        {
            int poin = 0;
            if (pulsa >= 100000)
            {
                poin += (pulsa / 100000) * 800;
                pulsa = pulsa % 100000;
            }

            if (pulsa >= 50000 && pulsa < 100000)
            {
                poin += (pulsa / 50000) * 400;
                pulsa %= 50000;
            }

            if (pulsa >= 25000 && pulsa < 50000)
            {
                poin += (pulsa / 25000) * 200;
                pulsa %= 25000;
            }

            if (pulsa>=10000 && pulsa<25000)
            {
                poin += (pulsa / 10000) * 80;
                pulsa %= 10000;
            }

            Console.WriteLine("Poin = " + poin);
        }


        public void GrabFood()
        {
            int belanja = 0, jarak = 0, ongkir, total;
            double diskon=0;
            string promo = "";

            Console.WriteLine("Masukkan total belanja = ");
            belanja = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukkan jarak ongkir = ");
            jarak= int.Parse(Console.ReadLine());

            Console.WriteLine("Masukkan kode promo = ");
            promo=Console.ReadLine();

            ongkir = jarak > 5 ? 5000 + (jarak - 5) * 1000 : 5000;

            if (promo == "JKTOVO" && belanja>=30000)
            {
                diskon = belanja * (0.4);

                if (diskon >= 30000)
                {
                     diskon = 30000;

                }
            }

            Console.WriteLine();
            Console.WriteLine($"Belanja :  {belanja,9}");
            Console.WriteLine($"Diskon 40% :  {diskon,9}");
            Console.WriteLine($"Ongkos Kirim :  {ongkir,9}");
            Console.WriteLine($"Total Belanja :  {belanja-diskon+ongkir,9}");



        }


        static void Main(string[] args)
        {

            Program pg = new Program(); 
            
            Console.WriteLine("Menu Switch Case");
            Console.WriteLine("1. Buat program untuk grade nilai");
            Console.WriteLine("2. Buat program untuk cek angka genap ganjil");
            Console.WriteLine("3. Buat program poin pulsa");
            Console.WriteLine("4. Buat program diskon GrabFood");
            Console.WriteLine();
            Console.Write("Masukkan pilihan = ");
            int pil = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (pil)
            {
                case 1:
                    Console.WriteLine("Masukkan angka = ");
                    int x =int.Parse(Console.ReadLine());
                    pg.GradeNilai (x);
                    break;
                case 2:
                    Console.WriteLine("Masukkan angka yg ingin dicek = ");
                    int a = int.Parse(Console.ReadLine());
                    int cek = pg.CekAngka(a);
                    break;
                case 3:
                    Console.WriteLine("Masukkan jumlah pulsa = ");
                    int p = int.Parse(Console.ReadLine());
                    pg.PoinPulsa(p);
                    break;
                case 4:
                        pg.GrabFood();
                    break;
                default:
                    Console.WriteLine("Menu tidak tersedia");
                    break;



            }
        }
    }
}
