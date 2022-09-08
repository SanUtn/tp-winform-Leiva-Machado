using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listarMarca()
        {
            List<Marca> lista = new List<Marca>();

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
