using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan2
{
    class Pegasus : Kuda
    {
        private Burung InternalBurung { get; set; }

        public Pegasus()
        {
            InternalBurung = new Burung();
        }

        public string Sayap
        {
            get
            {
                return InternalBurung.Sayap;
            }

            set
            {
                InternalBurung.Sayap = value;
            }
        }
    }
}
