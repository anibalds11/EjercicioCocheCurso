using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheApp
{
    public class Rueda
    {
        public Boolean movimiento;

        public Rueda(bool movimiento)
        {
            this.movimiento = movimiento;
        }

        public void rodar()
        {
            this.movimiento = true;
        }
        public void parar()
        {
            this.movimiento = false;
        }
    }
}
