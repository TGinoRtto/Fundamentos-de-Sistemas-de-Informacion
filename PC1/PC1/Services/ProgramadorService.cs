using PC1.Entities;
using PC1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC1.Services
{
    internal class ProgramadorService
    {
        private RepositoryProgramador Repositoryprogramador = new();

        public ProgramadorService() { }

        public bool Registrar(Programador programador)
        {
            if (Repositoryprogramador.Existe(programador.Codigop))
            {
                return false;
            }
            else
            {
                Repositoryprogramador.Registrar(programador);
                return true;
            }
        }

        public List<Programador> ListarTodo()
        {
            return RepositoryProgramador.ListarTodo();
        }

        public List<Programador> ListarProgramadoresconMasTiempo() 
        {
            return Repositoryprogramador.ListarProgramadoresconMasTiempo();
        }

        public List<Programador> ListarBusesConMenosRutas()
        {
            return Repositoryprogramador.ListarPorgramadoresconMenosHoras();
        }
    }
}
