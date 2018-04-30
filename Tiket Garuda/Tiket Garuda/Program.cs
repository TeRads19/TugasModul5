using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiket_Garuda
{
    class Program
    {
        public static void makasih ()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("    TERIMAKASIH TELAH MEMESAN TIKET MELALUI KAMI  ");
            Console.WriteLine("    KAMI TUNGGU PEMESANAN SELANJUTNYA DARI ANDA :)");
            Console.WriteLine("--------------------------------------------------");
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\nPAN_AM Ticketing ver [1.00.0]");
            Console.Write("\u00a9"); Console.Write(" 2018 SKYNET IT Solution. All rights reserved.");
        }


        public void tix(string asal, string tujuan, int price, string barcode,string times) { Tiket buy = new Tiket(asal, tujuan, barcode, times); buy.beli(price); buy.printtiket(); }

        public static void arr1 ()
        {
            Program buy = new Program();
            int arr;

            do
            {
                string s = "PAN-AM TICKETING V1.0";
                string a = "|| SELAMAT DATANG PAN-AM SIAP MELAYANI ANDA ||";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
                Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));
                string[] kota = new string[5] { "1.Jakarta", "2.Yogyakarta", "3.Denpassar", "4.Medan", "5.Makassar" };
                Console.WriteLine("\nPilih Kota Tujuan\n");
                foreach (string b in kota) { Console.WriteLine(b); };
                Console.Write("Kemana anda ingin terbang : ");
                if (int.TryParse(Console.ReadLine(), out arr))
                {
                    Console.Clear();
                    switch (arr)
                    {
                        case 1:
                            Console.WriteLine("Maaf Anda Tidak Usah Terbang Karena Sudah Tiba");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 2:
                            buy.tix("CGK-SUKARNO HATTA INTERNATIONAL AIRPORT", "JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", 765000, "PA-333CB", "1 Jam 20 Menit");
                            break;

                        case 3:
                            buy.tix("CGK-SUKARNO HATTA INTERNATIONAL AIRPORT", "DPS-NGURAH RAI INTERNATIONAL AIRPORT", 1500000, "PA-333XT", "2 Jam 5 Menit");
                            break;

                        case 4:
                            buy.tix("CGK-SUKARNO HATTA INTERNATIONAL AIRPORT", "KNO-KUALA NAMU INTERNATIONAL AIRPORT", 1750000, "PA-153CC", "2 Jam 20 Menit");
                            break;


                        case 5:
                            buy.tix("CGK-SUKARNO HATTA INTERNATIONAL AIRPORT", "UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", 1350000, "PA-567FB", "2 Jam 25 Menit");

                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                else { Console.WriteLine("Input Error"); }

            } while (arr < 1 || arr > 5 || arr ==1);

        }
       
 public static void arr2()
        {
            Program buy = new Program();

            int arr;
            do
            {
                string s = "PAN-AM TICKETING V1.0";
                string a = "|| SELAMAT DATANG PAN-AM SIAP MELAYANI ANDA ||";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
                Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));
                string[] kota = new string[5] { "1.Jakarta", "2.Yogyakarta", "3.Denpassar", "4.Medan", "5.Makassar" };
                Console.WriteLine("\nPilih Kota Tujuan\n");
                foreach (string b in kota) { Console.WriteLine(b); };
                Console.Write("Kemana anda ingin terbang : ");
                if (int.TryParse(Console.ReadLine(), out arr))
                {
                Console.Clear();
                switch (arr)
                {
                    case 1:
                        buy.tix("JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", "CGK-SUKARNO HATTA INTERNATIONAL AIRPORT",1550000,"PA-383CB", "1 Jam 20 Menit");
                        break;
                    case 2:
                        Console.WriteLine("Maaf Anda Tidak Usah Terbang Karena Sudah Tiba");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        buy.tix("JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", "DPS-NGURAH RAI INTERNATIONAL AIRPORT",450000, "PA-343XT","1 Jam 20 Menit");
                        break;
                    case 4:
                        buy.tix("JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", "KNO-KUALA NAMU INTERNATIONAL AIRPORT", 792000, "PA-303SF", "PA-333HH");
                        break;
                    case 5:
                        buy.tix("JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", "UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", 850000, "PA-333HH", "1 Jam 55 Menit");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
                else { Console.WriteLine("Input Error"); }

        } while (arr < 1 || arr > 5 || arr == 2);

        }
        public static void arr3()
        {
            Program buy = new Program();
            int arr;
            do
            {
                string s = "PAN-AM TICKETING V1.0";
                string a = "|| SELAMAT DATANG PAN-AM SIAP MELAYANI ANDA ||";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
                Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));
                string[] kota = new string[5] { "1.Jakarta", "2.Yogyakarta", "3.Denpassar", "4.Medan", "5.Makassar" };
                Console.WriteLine("\nPilih Kota Tujuan\n");
                foreach (string b in kota) { Console.WriteLine(b); };
                Console.Write("Kemana anda ingin terbang : "); if (int.TryParse(Console.ReadLine(), out arr))
                {
                    Console.Clear();
                    switch (arr)
                    {
                        case 1:
                            buy.tix("DPS-NGURAH RAI INTERNATIONAL AIRPORT", "CGK-SUKARNO HATTA INTERNATIONAL AIRPORT", 16500000, "PA-154XT", "2 Jam 5 Menit");
                            break;
                        case 2:
                            buy.tix("DPS-NGURAH RAI INTERNATIONAL AIRPORT", "JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", 650000, "PA-363XT", "1 Jam 20 Menit");
                            break;
                        case 3:
                            Console.WriteLine("Maaf Anda Tidak Usah Terbang Karena Sudah Tiba");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            buy.tix("DPS-NGURAH RAI INTERNATIONAL AIRPORT", "KNO-KUALA NAMU INTERNATIONAL AIRPORT", 1250000, "PA-777XT", "6 Jam 10 Menit");
                            break;
                        case 5:
                            buy.tix("DPS-NGURAH RAI INTERNATIONAL AIRPORT", "UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", 550000, "PA-898XT", "1 Jam 30 Menit");
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                else { Console.WriteLine("Input Error"); }
            } while (arr < 1 || arr > 5 || arr == 3);

        }
        public static void arr4()
        {
            Program buy = new Program();
            int arr;
            do
            {
                string s = "PAN-AM TICKETING V1.0";
                string a = "|| SELAMAT DATANG PAN-AM SIAP MELAYANI ANDA ||";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
                Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));
                string[] kota = new string[5] { "1.Jakarta", "2.Yogyakarta", "3.Denpassar", "4.Medan", "5.Makassar" };
                Console.WriteLine("\nPilih Kota Tujuan\n");
                foreach (string b in kota) { Console.WriteLine(b); };
                Console.Write("Kemana anda ingin terbang : "); if (int.TryParse(Console.ReadLine(), out arr))
                {
                    Console.Clear();
                    switch (arr)
                    {
                        case 1:
                            buy.tix("KNO-KUALA NAMU INTERNATIONAL AIRPORT", "CGK-SUKARNO HATTA INTERNATIONAL AIRPORT", 1650000, "PA-143CC", "2 Jam 20 Menit");
                            break;
                        case 2:
                            buy.tix("KNO-KUALA NAMU INTERNATIONAL AIRPORT", "JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", 792000, "PA-303SF", "3 jam 15 menit");
                            break;
                        case 3:
                            buy.tix("KNO-KUALA NAMU INTERNATIONAL AIRPORT", "DPS-NGURAH RAI INTERNATIONAL AIRPORT", 1450000, "PA-787XT", "6 Jam");
                            break;
                        case 4:
                            Console.WriteLine("Maaf Anda Tidak Usah Terbang Karena Sudah Tiba");
                            Console.ReadLine();
                            break;
                        case 5:
                            buy.tix("KNO-KUALA NAMU INTERNATIONAL AIRPORT", "UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", 1650000, "PA-787XX", "8 Jam");
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                else{ }
                } while (arr < 1 || arr > 5 || arr == 4);
            }

        public static void arr5()
        {
            Program buy = new Program();
            int arr;
            do
            {
                string s = "PAN-AM TICKETING V1.0";
                string a = "|| SELAMAT DATANG PAN-AM SIAP MELAYANI ANDA ||";
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
                Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));
                string[] kota = new string[5] { "1.Jakarta", "2.Yogyakarta", "3.Denpassar", "4.Medan", "5.Makassar" };
                Console.WriteLine("\nPilih Kota Tujuan\n");
                foreach (string b in kota) { Console.WriteLine(b); }; Console.Write("Kemana anda ingin terbang : ");
                if (int.TryParse(Console.ReadLine(), out arr))
                {
                    Console.Clear();
                    switch (arr)
                    {
                        case 1:
                            buy.tix("UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", "CGK-SUKARNO HATTA INTERNATIONAL AIRPORT", 1350000, "PA-568FB", "2 Jam 30 Menit");
                            break;
                        case 2:
                            buy.tix("UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", "JOG-ADI SUCIPTO INTERNATIONAL AIRPORT", 850000, "PA-334HH", "1 Jam 55 Menit");
                            break;
                        case 3:
                            buy.tix("UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", "DPS-NGURAH RAI INTERNATIONAL AIRPORT", 650000, "PA-899XT", "1 Jam 20 Menit");
                            break;
                        case 4:
                            buy.tix("UPG-SULTAN HASANUDDIN INTERNATIONAL AIRPORT", "KNO-KUALA NAMU INTERNATIONAL AIRPORT", 1750000, "PA-777XX", "8 Jam 20 Menit");
                            break;
                        case 5:
                            Console.WriteLine("Maaf Anda Tidak Usah Terbang Karena Sudah Tiba");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                else { Console.WriteLine("Input Error"); }

            } while (arr < 1 || arr > 5 || arr == 5);

        }


        static void Main(string[] args)
        {
            int dept, age, pilihan, pilihan2; string c; penumpang pas = new penumpang();
            Biodata.biodata();

            
                do
                {
                Console.WriteLine("lol\n");
                do
                {
                    Console.Clear();
                    string s = "PAN-AM TICKETING V1.0";
                    string a = "|| SELAMAT DATANG PAN-AM SIAP MELAYANI ANDA ||";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
                    Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));

                    Console.WriteLine("Mohon untuk mengisi data penumpang");
                    Console.Write("Masukan Nama Anda : ");
                    string pass = Console.ReadLine(); pas.data(pass);
                    Console.Write("\nMasukan ID penumpang(KTP) : ");
                    string ktp = Console.ReadLine(); pas.ID(ktp);
                    Console.Write("\nMasukan umur penumpang : "); 
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        pas.age(age);
                        if (age < 18) { Console.WriteLine("Maaf anda tidak dapat memesan tiket melalui aplikasi kami"); }
                    }
                    else { Console.WriteLine("Input Error"); Console.ReadLine(); }

                } while (age < 18); 
                pas.cetakdata(); Console.WriteLine("Apakah data sudah benar ?\n1.ya\n2.tidak"); if (int.TryParse(Console.ReadLine(), out pilihan)) { } else { Console.WriteLine("Input Error"); Console.ReadLine(); }
            } while (pilihan != 1);

            do
            {
                
                    Console.Clear();
                    string s = "PAN-AM TICKETING V1.0";
                    string a = "|| SELAMAT DATANG PAN-AM SIAP MELAYANI ANDA ||";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (s.Length / 2)) + "}", s));
                    Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (a.Length / 2)) + "}", a));
                    string[] kota = new string[5] { "1.Jakarta", "2.Yogyakarta", "3.Denpassar", "4.Medan", "5.Makassar" };
                    Console.WriteLine("\n");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|| KAMI MENYEDIAKAN LAYANAN BOOKING TIKET PESAWAT GARUDA  ||");
                    Console.WriteLine("||           KE LIMA DESTINASI KOTA DI INDONESIA          ||");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("\nPilih Kota Keberangkatan\n");
                    foreach (string b in kota) { Console.WriteLine(b); }; Console.Write("Dari mana anda ingin berangkat : ");
                    if (int.TryParse(Console.ReadLine(), out dept))
                    {
                        Console.Clear();
                        switch (dept)
                        {
                            case 1:
                                arr1(); pas.cetakdata(); makasih(); Console.ReadLine(); break;
                            case 2:
                                arr2(); pas.cetakdata(); makasih(); Console.ReadLine(); break;
                            case 3:
                                arr3(); pas.cetakdata(); makasih(); Console.ReadLine(); break;
                            case 4:
                                arr4(); pas.cetakdata(); makasih(); Console.ReadLine(); break;
                            case 5:
                                arr5(); pas.cetakdata(); makasih(); Console.ReadLine(); break;
                            default:
                                Console.WriteLine("Invalid Input");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                        Console.WriteLine("\nApa anda ingin memesan kembali  [1] Ya/[2] Tidak");
                    if (int.TryParse(Console.ReadLine(), out pilihan2)) if (pilihan2 == 1) { Console.Clear(); Program.Main(null); }
                    else if (pilihan2 == 2) { Environment.Exit(0); } else { Console.WriteLine("Input Error"); }
                    }
                    else { Console.WriteLine("Input Error"); }

            } while (dept < 1 || dept > 5);

        }
    }
}
