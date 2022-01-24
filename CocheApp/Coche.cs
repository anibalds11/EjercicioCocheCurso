using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocheApp
{
    public class Coche
    {
        public Boolean estado;
        public Rueda rueda;

        public Coche(bool estado, Rueda rueda)
        {
            this.estado = estado;
            this.rueda = rueda;
        }

        public void arrancar()
        {
            this.estado = true;
            this.rueda.rodar();
        }

        public void apagar()
        {
            this.estado = false;
            this.rueda.parar();
        }
    }
}
