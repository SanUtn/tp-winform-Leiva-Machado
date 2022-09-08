using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    class CategoriaNegocio
    {
        public List<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();

            AccesoDatos datos = new AccesoDatos();
            try
            {
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
