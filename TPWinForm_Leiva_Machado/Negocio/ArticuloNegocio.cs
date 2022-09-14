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
        private AccesoDatos datos = new AccesoDatos(); //cambio a una propiedad privada para no instanciar en todos los metodos
        public List<Articulo> listarArticulo()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdCategoria, A.IdMarca,A.ImagenUrl, C.Descripcion 'Categoria', M.Descripcion 'Marca', A.Precio from Articulos A INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria INNER JOIN Marcas M ON M.id = A.IdMarca where A.Activo = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = (int)datos.Lector["Id"];
                    art.CodArticulo = (String)datos.Lector["Codigo"];
                    art.NombreArticulo = (String)datos.Lector["Nombre"];
                    art.Descripcion = (String)datos.Lector["Descripcion"];

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

        public List<Articulo> buscarArticulo(Articulo buscado)
        {
            List<Articulo> encontrados = new List<Articulo>();
            try
            {
                datos.setearConsulta("SELECT Nombre, ImagenUrl FROM ARTICULOS WHERE Nombre like @buscado");
                datos.setearParametro("@buscado", "%"+buscado.NombreArticulo+"%"); //polemico
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.NombreArticulo = (String)datos.Lector["Nombre"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        art.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    encontrados.Add(art);
                }
                    return encontrados;
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

        public void agregar(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES(@codigo, @nombre, @descripcion, @idmarca, @idcategoria, @imagen, @precio)");
                datos.setearParametro("@codigo", nuevo.CodArticulo);
                datos.setearParametro("@nombre", nuevo.NombreArticulo);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@idmarca", nuevo.MarcaArticulo.Id);
                datos.setearParametro("@idcategoria", nuevo.CategoriaArticulo.Id);
                datos.setearParametro("@imagen", nuevo.UrlImagen);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.ejecutarAccion();
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

        public void modificar(Articulo modificado)
        {
            try
            {
                datos.setearConsulta("Update Articulos set codigo = @codigo, Nombre = @nombre, descripcion = @descripcion, idmarca = @idmarca, idcategoria = @idcategoria, imagenurl = @imagen, precio = @precio where id = @id ");
                datos.setearParametro("@codigo", modificado.CodArticulo);
                datos.setearParametro("@nombre", modificado.NombreArticulo);
                datos.setearParametro("@descripcion", modificado.Descripcion);
                datos.setearParametro("@idmarca", modificado.MarcaArticulo.Id);
                datos.setearParametro("@idcategoria", modificado.CategoriaArticulo.Id);
                datos.setearParametro("@imagen", modificado.UrlImagen);
                datos.setearParametro("@precio", modificado.Precio);
                datos.setearParametro("@id", modificado.Id);
                datos.ejecutarAccion();
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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM Articulos WHERE Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
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

        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update Articulos set Activo = 0 Where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT A.Nombre, A.ImagenUrl FROM ARTICULOS A ";

                if (campo == "Precio")
                {
                    consulta += "WHERE ";
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += " A.Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += " A.Precio < " + filtro;
                            break;
                        default:
                            consulta += " A.Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    consulta += "WHERE ";
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " A.Nombre LIKE '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += " A.Nombre LIKE  '%" + filtro + "' ";
                            break;
                        default:
                            consulta += " A.Nombre LIKE '%" + filtro + "%' ";
                            break;
                    }
                }
                else
                {
                    consulta += "LEFT JOIN Categorias C ON C.ID = A.IdCategoria WHERE";
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " C.Descripcion LIKE '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += " C.Descripcion LIKE '%" + filtro + "' ";
                            break;
                        default:
                            consulta += " C.Descripcion LIKE '%" + filtro + "%' ";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();


                while (datos.Lector.Read()) //mientras tenga datos, crea un objeto nuevo
                {
                    Articulo art = new Articulo();
                    art.NombreArticulo = (String)datos.Lector["Nombre"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        art.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    lista.Add(art);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
