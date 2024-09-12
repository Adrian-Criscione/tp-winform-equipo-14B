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

                    if (!(datos.Lector["codigo"] is DBNull))
                    {
                        aux.CodigoArticulo = (string)datos.Lector["codigo"];

                    }
                    if (!(datos.Lector["nombre"] is DBNull))
                    {

                        aux.Nombre = (string)datos.Lector["nombre"];

                    }
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    {
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    }
                    if (!(datos.Lector["Marcas"] is DBNull))
                    {
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["Marcas"];
                    }
                    if (!(datos.Lector["Categorias"] is DBNull))
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.Lector["Categorias"];
                    }

                    if (!(datos.Lector["precio"] is DBNull))
                    {
                        aux.Precio = (decimal)datos.Lector["precio"];
                    }

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
                //INSERT DE LA CONSULTA
                datos.setearConsulta("insert into ARTICULOS (codigo,nombre,Descripcion,IdMarca,IdCategoria,precio) values(@CodigoArticulo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                //SETEAR LOS VALORES A LAS VARIABLES QUE SE PASAN EN LA CONSULTA.
                datos.setearParametro("@CodigoArticulo", nuevo.CodigoArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                //EJECUTA EL OPEN Y LA QUERY 
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
