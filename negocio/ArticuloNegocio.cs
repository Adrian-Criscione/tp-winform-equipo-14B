using dominio;
using System;
using System.Collections.Generic;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select codigo, nombre, a.descripcion, m.Descripcion as MARCAS, c.Descripcion as CATEGORIAS, precio from ARTICULOS a inner join MARCAS m on a.IdMarca = m.id inner join CATEGORIAS c on a.idcategoria = c.Id"); // aca va la consulta.
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.CodigoArticulo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marcas"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categorias"];
                    aux.Precio = (decimal)datos.Lector["precio"];
                    lista.Add(aux);
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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (codigo,nombre,Descripcion,IdMarca,IdCategoria,precio) values('" + nuevo.CodigoArticulo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "','" + nuevo.Marca + "','" + nuevo.Categoria + "'," + nuevo.Precio + ")");
                //datos.setearConsulta("insert into ARTICULOS (codigo,nombre,Descripcion,IdMarca,IdCategoria,precio) values('" + nuevo.CodigoArticulo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "','" + nuevo.Marca + "','" + nuevo.Categoria + "'," + nuevo.Precio")");
                //datos.setearConsulta("insert into POKEMONS ( numero, nombre, descripcion, activo) values(" + nuevo.Numero + ", '" + nuevo.Nombre + "','" + nuevo.Descripcion + "','" + nuevo.Tipo + "','" + nuevo.Debilidad + "',1)");
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
        public void modificar(Articulo modificar)
        {

        }
    }
}
