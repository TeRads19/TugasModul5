using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiket_Garuda
{
    class penumpang
    {
        String nama, id;
        int umur;
        public void data(String name)
        {
            this.nama = name;

        }
        public void ID(string code)
        {
            id = code;
        }
        public void age(int umr)
        {
            umur = umr;
        }
            public  void cetakdata()
        {
            penumpang pas = new penumpang();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                  Data Penumpang Pesawat                    ");
            Console.WriteLine("\nNama     : " + nama);
            Console.WriteLine("\nNomor ID : " + id);
            Console.WriteLine("\nUmur     : " + umur);
            Console.WriteLine("------------------------------------------------------------");
        }
            
        }
    }

