using PC1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC1.Repositories
{
    internal class RepositoryProgramador
    {
        private static List<Programador> programadores = new();

        public RepositoryProgramador() { }

        public bool Existe(String codigop)
        {
            return programadores.Exists(programador => programador.Codigop.Equals(codigop));
        }

        public void Registrar(Programador programador)
        {
            programadores.Add(programador);
        }

        public static List<Programador> ListarTodo()
        {
            return programadores;
        }

        public List<Programador> ListarProgramadoresconMasTiempo()
        {
            List<Programador> programadoresTemp = new();
            Double maxHoras = double.MinValue;

            foreach (Programador programador in programadores)
            {
                AppEscritorio? AppMasLarga = programador.AppEscritorios.MaxBy(AppEscritorio => AppEscritorio.Horas);
                if (AppMasLarga != null)
                {
                    if (AppMasLarga.Horas > maxHoras)
                    {
                        maxHoras = AppMasLarga.Horas;
                        programadoresTemp.Clear();
                        programadoresTemp.Add(programador);
                    }
                    else if (AppMasLarga.Horas == maxHoras)
                    {
                        programadoresTemp.Add(programador);
                    }
                }
            }
            return programadoresTemp;
        }

        public List<Programador> ListarPorgramadoresconMenosHoras()
        {
            List<Programador> programadoresTemp = new();
            int menorCantidaddeHoras = int.MaxValue;

            foreach (Programador bus in programadores)
            {
                int cantidadRutas = bus.AppEscritorios.Count;
                if (cantidadRutas < menorCantidaddeHoras)
                {
                    menorCantidaddeHoras = cantidadRutas;
                    programadoresTemp.Clear();
                    programadoresTemp.Add(bus);
                }
                else if (cantidadRutas == menorCantidaddeHoras)
                {
                    programadoresTemp.Add(bus);
                }
            }
            return programadoresTemp;
        }
    }
}
