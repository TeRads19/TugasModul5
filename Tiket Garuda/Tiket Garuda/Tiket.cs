using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiket_Garuda
{
     class Tiket
    {
        string kode, dept, arrv, waktu; int harga;
public Tiket(string asal, string tujuan, string kode, string waktu)
        {
            this.kode = kode; this.dept = asal; this.arrv = tujuan; this.waktu = waktu;
        }

        public void beli(int pricetag)
        {
            harga = pricetag;
        }

        public void printtiket()
        {

            Console.WriteLine("KODE PENERBANGAN           : " + kode);
            Console.WriteLine("Keberangkatan(DEPARTURE)   : " + dept);
            Console.WriteLine("Kedatangan(ARRIVAL)        : " + arrv);
            Console.WriteLine("Lama Perjalanan            : " + waktu);
            Console.WriteLine("Harga Tiket                : Rp." + harga);
    
        }

    }
}
