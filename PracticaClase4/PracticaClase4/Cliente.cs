using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase4
{
    class Cliente
    {
        // Punto 10
        public string Nombre { get; set; }
        public int Cuit { get; set; }
        public decimal Saldo { get; set; }

        public static Cliente operator -(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.Cuit==cliente2.Cuit)
            {
                decimal resta = cliente1.Saldo - cliente2.Saldo;
                cliente1.Saldo = resta;
                return cliente1;
            }
            else
            {
                if (cliente1.Saldo<cliente2.Saldo)
                {
                    return cliente1;
                }
                else
                {
                    return cliente2;
                }
            }
        }

    }
}
