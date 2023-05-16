using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMascota
{
    internal class ClsMascota
    {
        public string nombre { get; set; }
        public string edad { get; set; }
        public string tipoAnimal { get; set; }


        public Image FotoAnimal { get; set; }


        public string AlimentarMascota()
        { return nombre + " " + "ha sido alimentado"; }

        public string JugarMascota()
        { return "Has jugado con" + " " + nombre; }

        public string CuidarMascota()
        { return "Has cuidado a" + " " + nombre; }

    }
}
