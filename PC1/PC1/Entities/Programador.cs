using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC1.Entities
{
    internal class Programador
    {
        public Programador(string codigop, string nombre, string categoria)
        {
            Codigop = codigop;
            Nombre = nombre;
            Categoria = categoria;
            AppEscritorios = new();
        }

        public String Codigop { get; set; }
        public String Nombre { get; set; }
        public String Categoria { get; set; }

        public List<AppEscritorio> AppEscritorios { get; set; }
    }
}
