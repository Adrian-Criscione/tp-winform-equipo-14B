using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace negocio
{
    public class MarcaNegocio
    {
       
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Marca aux = new Marca();
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

        public void agregarMarca(Marca nuevaMarca) 
        {
            AccesoDatos datosMarcas = new AccesoDatos();

            try
            {
               // datosMarcas.setearConsulta("INSERT INTO MARCAS VALUE"('"+ nuevaMarca.Descripcion +" ')"");
                //datosMarcas.ejecutarAccion();
            }
            catch ( Exception ex)
            {

                throw;
            }
        
        
        
        }




    }











}
