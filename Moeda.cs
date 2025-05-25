using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cara_ou_corôa
{
    internal class Moeda
    {
        public bool isCaras { get; set; }

        // construtor para uma nova moeda
        public Moeda(bool C)
        {
            this.isCaras = C;
        }
        public void CaraOuCoroa(Random r)
        {
            this.isCaras = r.Next(2) == 0; // 0 = Cara, 1 = Coroa
        }
    }
}
