using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
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
        public void agregarCategoria(Categoria newcat)
        {
            AccesoDatos datosCat = new AccesoDatos();

            try
            {

                datosCat.setearConsulta("INSERT INTO CATEGORIAS(Descripcion) VALUES (@Descripcion)");
                datosCat.setearParametro("@Descripcion", newcat.Descripcion);

                datosCat.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally

            {
                datosCat.cerrarConexion();
            }
        
        
        
        }
        public void modificarCategoria(Categoria modifcat)
        {
            AccesoDatos datoCat = new AccesoDatos();

            try
            {
                datoCat.setearConsulta("UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @Id");
                datoCat.setearParametro("@Id", modifcat.Id);
                datoCat.setearParametro("@Descripcion", modifcat.Descripcion);
                datoCat.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datoCat.cerrarConexion();
            }

        }



    }
}
