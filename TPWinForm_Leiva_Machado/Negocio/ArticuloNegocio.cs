using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulo()
        {
            List<Articulo> lista = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select A.Codigo, A.Nombre,A.IdCategoria, A.IdMarca,A.ImagenUrl, C.Descripcion 'Categoria', M.Descripcion 'Marca', A.Precio  from Articulos A INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria INNER JOIN Marcas M ON M.id = A.IdMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.CodArticulo = (String)datos.Lector["Codigo"];
                    art.NombreArticulo = (String)datos.Lector["Nombre"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        art.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }

                    art.CategoriaArticulo = new Categoria();
                    art.CategoriaArticulo.Id = (int)datos.Lector["IdCategoria"];
                    art.CategoriaArticulo.NombreCategoria = (String)datos.Lector["Categoria"];
                    art.MarcaArticulo = new Marca();
                    art.MarcaArticulo.Id = (int)datos.Lector["IdMarca"];
                    art.MarcaArticulo.NombreMarca = (string)datos.Lector["Marca"];
                    art.Precio = (float)(decimal)datos.Lector["Precio"]; //hay que revisar esto

                    lista.Add(art);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
