using PC1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC1.Repositories
{
    internal class RepositoryAppEscritorio
    {
        public RepositoryAppEscritorio() { }

        public bool Existe(String codigo)
        {
            List<Programador> programadores = RepositoryProgramador.ListarTodo();
            foreach (Programador programador in programadores )
            {
                bool existe = programador.AppEscritorios.Exists(appEscritorio => appEscritorio.Codigo.Equals(codigo));
                if (existe)
                {
                    return true;
                }
            }
            return false;
        }

        public void Registrar(String codigop, AppEscritorio appEscritorio)
        {
            List<Programador> programadores = RepositoryProgramador.ListarTodo();

           
            Programador? programador = programadores.Find(programador => programador.Codigop.Equals(codigop));

            if (programador != null)
            {
                programador.AppEscritorios.Add(appEscritorio);
            }
        }

        public List<AppEscritorio> ListarTodo(String codigop)
        {
            List<Programador> programadores = RepositoryProgramador.ListarTodo();

            Programador? programador = programadores.Find(programador => programador.Codigop.Equals(codigop));

            if (programador != null)
            {
                return programador.AppEscritorios;
            }
            else
            {
                return new List<AppEscritorio>();
            }
        }

        public List<AppEscritorio> ListarProgramadoresPorNombreProgramador(String nombre)
        {
            List<Programador> programadores = RepositoryProgramador.ListarTodo();
            List<Programador> programadorestemp = programadores.FindAll(programador => programador.Nombre.Equals(nombre));

            List<AppEscritorio> apptemp = new();

            
            foreach (Programador programador in programadorestemp)
            {
                apptemp.AddRange(programador.AppEscritorios);
            }

            return apptemp;
        }
    }
}
