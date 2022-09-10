using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public string CodArticulo { get; set; }

        public string NombreArticulo { get; set; }
        public string Descripcion { get; set; }
        public Marca MarcaArticulo { get; set; }
        public Categoria CategoriaArticulo { get; set; }
        public string UrlImagen { get; set; }

        public float Precio { get; set; }
    }
}
