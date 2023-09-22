using PC1.Entities;
using PC1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC1.Services
{
    internal class AppEscritorioService
    {
        private RepositoryAppEscritorio RepositoryAppescritorio = new();
        public AppEscritorioService() { }

        public bool Registrar(String codigo, AppEscritorio appEscritorio)
        {
            if (RepositoryAppescritorio.Existe(appEscritorio.Codigo))
            {
                return false;
            }
            else
            {
                RepositoryAppescritorio.Registrar(codigo, appEscritorio);
                return true;
            }
        }

        public List<AppEscritorio> ListarTodo(String codigo)
        {
            return RepositoryAppescritorio.ListarTodo(codigo);
        }

        public List<AppEscritorio> ListarProgramadoresPorNombreProgramador(String nombre)
        {
            return RepositoryAppescritorio.ListarProgramadoresPorNombreProgramador(nombre);
        }
    }
}
