using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC1.Entities
{
    internal class AppEscritorio
    {
        public AppEscritorio(string codigo, string nombreapp, string lenguajeprogramacion, double horas)
        {
            Codigo = codigo;
            NombreApp = nombreapp;
            LenguajeProgramacion = lenguajeprogramacion;
            Horas = horas;
        }

        public String Codigo { get; set; }
        public String NombreApp { get; set; }
        public String LenguajeProgramacion { get; set; }
        public Double Horas { get; set; }

    }
}
