using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // CREATE OBJECT BURUNG
            Burung nuri = new Burung();
            nuri.Kaki = 2;
            nuri.Sayap = "Merah";
            Console.WriteLine("Burung Nuri : {0} kaki dan bersayap {1}", 
                nuri.Kaki, nuri.Sayap);

            // CREATE OBJECT KUDA
            Kuda zebra = new Kuda();
            zebra.Kaki = 4;
            zebra.Ekor = "Pendek";
            Console.WriteLine("Kuda Zebra : {0} kaki dan berekor {1}", 
                zebra.Kaki, zebra.Ekor);
            */

            // CREATE OBJECT PEGASUS
            Pegasus pegasus = new Pegasus();
            pegasus.Kaki = 4;
            pegasus.Sayap = "Putih";
            pegasus.Ekor = "Pendek";
            Console.WriteLine("Kuda Pegasus : {0} kaki, bersayap {1}, dan berekor {2}", 
                pegasus.Kaki, pegasus.Sayap, pegasus.Ekor);

            Console.ReadLine();
        }
    }
}
