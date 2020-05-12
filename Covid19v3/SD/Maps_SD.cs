using Covid19v3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Covid19v3.SD
{
    public class Maps_SD : ClaseBase
    {
        public List<Maps> Listar()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            Maps pMaps_BE = new Maps();
            SqlCommand ocomando = CargarParametrosStore(pMaps_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspMaps_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Maps> oLista = new List<Maps>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Maps obeMaps = new Maps();
                    obeMaps = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeMaps);
                    obeMaps = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Listar():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }

        public List<Maps> Listar(Maps pMaps_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pMaps_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspMaps_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Maps> oLista = new List<Maps>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Maps obeMaps = new Maps();
                    obeMaps = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeMaps);
                    obeMaps = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Listar():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public Maps ListarKey(System.Int32 pCodigoMaps)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspMaps_ListarKey]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            Maps ObeMaps = new Maps();
            ocomando.Parameters.Add("@IdMapa", SqlDbType.Int).Value = pCodigoMaps;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    ObeMaps = CargarDatosEntidad(oDataReader);
                    break;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarKey():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return ObeMaps;
        }
        public DataTable Lista(Maps pMaps_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pMaps_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspMaps_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            DataTable oDt = new DataTable("Maps");
            try
            {
                oconexion.Open();
                oDt.Load(ocomando.ExecuteReader());
            }
            catch (Exception e)
            {
                throw new Exception("Lista():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oDt;
        }

      
        public Maps CargarDatosEntidad(SqlDataReader oDataReader)
        {
            Maps ObeMaps = new Maps();

            try
            {
                ObeMaps = new Maps(
                    oDataReader.GetInt32((int)Maps.CAMPOS.IdMapa),
                    oDataReader.GetInt32((int)Maps.CAMPOS.Rating),
                    oDataReader.GetString((int)Maps.CAMPOS.Address),
                    oDataReader.GetDouble((int)Maps.CAMPOS.Lat),
                    oDataReader.GetDouble((int)Maps.CAMPOS.Long),
                    oDataReader.GetInt32((int)Maps.CAMPOS.Zoom)

                    );
            }
            catch (Exception e)
            {
                ObeMaps = null;
                throw new Exception("CargarDatosEntidad():" + e.Message);
            }
            finally
            {
            }
            return ObeMaps;
        }
        private SqlCommand CargarParametrosStore(Maps pMaps_BE)
        {
            SqlCommand ocomando = new SqlCommand();
            try
            {
                ocomando.Parameters.Add("@IdMapa", SqlDbType.Int).Value = pMaps_BE.IdMapa;
                ocomando.Parameters.Add("@Rating", SqlDbType.Int).Value = pMaps_BE.Rating;
                ocomando.Parameters.Add("@Address", SqlDbType.VarChar, 250).Value = pMaps_BE.Address;
                ocomando.Parameters.Add("@Lat", SqlDbType.Float).Value = pMaps_BE.Lat;
                ocomando.Parameters.Add("@Long", SqlDbType.Float).Value = pMaps_BE.Long;
                ocomando.Parameters.Add("@Zoom", SqlDbType.Int).Value = pMaps_BE.Zoom;
            }
            catch (Exception e)
            {
                throw new Exception("CargarParametrosStore():" + e.Message);
            }
            finally
            {
            }
            return ocomando;
        }

        public void Dispose()
        {
            GC.ReRegisterForFinalize(this);
        }

    }
}