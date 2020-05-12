using Covid19v3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Covid19v3.SD
{
    public class Triaje_SD:ClaseBase
    {
        public List<Triaje> Listar()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            Triaje pTriaje_BE = new Triaje();
            SqlCommand ocomando = CargarParametrosStore(pTriaje_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspTriaje_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
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

        public List<Triaje> Listar(Triaje pTriaje_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pTriaje_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspTriaje_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
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
        public Triaje ListarKey(System.Int32 pCodigoTriaje)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarKey]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            Triaje ObeTriaje = new Triaje();
            ocomando.Parameters.Add("@IdTriaje", SqlDbType.Int).Value = pCodigoTriaje;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    ObeTriaje = CargarDatosEntidad(oDataReader);
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
            return ObeTriaje;
        }
        public List<Triaje> ListarDocumentoEvaluacion(System.String pNumeroDocumento)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarEstadoEvaluacion]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();
            ocomando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar,250).Value = pNumeroDocumento;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarDocumentoEvaluacion():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarDocumento(System.String pNumeroDocumento)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarDocumento]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();
            ocomando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 250).Value = pNumeroDocumento;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarDocumentoEvaluacion():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarDocumentoConRiego(System.String pNumeroDocumento)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarEstadoConRiesgo]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();
            ocomando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 250).Value = pNumeroDocumento;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarDocumentoConRiego():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarTriajePrueba()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarPrueba]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();

            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarTriajePrueba():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarTriaje()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarTriaje]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();

            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarTriaje():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarTriajeConfirmado()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarConfirmado]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();

            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarTriajeConfirmado():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarTriajeHospitalizado()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarHospitalizado]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();

            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarTriajeHospitalizado():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarTriajeRecuperado()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarRecuperado]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();

            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarTriajeRecuperado():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Triaje> ListarTriajeFallecido()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_ListarFallecido]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Triaje> oLista = new List<Triaje>();

            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Triaje obeTriaje = new Triaje();
                    obeTriaje = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeTriaje);
                    obeTriaje = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarTriajeFallecido():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public DataTable Lista(Triaje pTriaje_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pTriaje_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspTriaje_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            DataTable oDt = new DataTable("Triaje");
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

        public string RegistraModifica(Triaje pTriaje_BE, string pTipoTransaccion)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_RegistraModifica]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@TipoTransaccion", SqlDbType.Char, 1).Value = pTipoTransaccion;

           
            ocomando.Parameters.Add("@Nombre", SqlDbType.VarChar, 250).Value = pTriaje_BE.Nombres;
            ocomando.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 250).Value = pTriaje_BE.Nacionalidad;

            ocomando.Parameters.Add("@Departamento", SqlDbType.VarChar, 250).Value = pTriaje_BE.Departamento;
            ocomando.Parameters.Add("@TipoDocumento", SqlDbType.VarChar, 250).Value = pTriaje_BE.TipoDocumento;
            ocomando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 250).Value = pTriaje_BE.NumeroDocumento;
            // ocomando.Parameters.Add("@PreguntaTriaje", SqlDbType.VarChar, 250).Value = pTriaje_BE.PreguntaTriaje;
            ocomando.Parameters.Add("@Respuesta1", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta1;
            ocomando.Parameters.Add("@Respuesta2", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta2;
            ocomando.Parameters.Add("@Respuesta3", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta3;
            ocomando.Parameters.Add("@Respuesta4", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta4;
            ocomando.Parameters.Add("@Respuesta5", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta5;
            ocomando.Parameters.Add("@Respuesta6", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta6;
            //ocomando.Parameters.Add("@Latitud", SqlDbType.VarChar, 250).Value = pTriaje_BE.Latitud;
            //ocomando.Parameters.Add("@Longitud", SqlDbType.VarChar, 250).Value = pTriaje_BE.Longitud;
            ////ocomando.Parameters.Add("@IdMapa", SqlDbType.VarChar, 250).Value = pTriaje_BE.IdMapa;


            //ocomando.Parameters["@IdTriaje"].Direction = ParameterDirection.InputOutput;
            string StrResultado = "";
            try
            {
                oconexion.Open();
                ocomando.ExecuteNonQuery();
                StrResultado = ocomando.Parameters["@NumeroDocumento"].Value.ToString();

            }
            catch (Exception e)
            {
                throw new Exception("RegistraModifica():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return StrResultado;
        }


        public Boolean Elimina(System.Int32 pCodigoTriaje)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspTriaje_Elimina]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@IdTriaje", SqlDbType.Int).Value = pCodigoTriaje;
            Boolean BolResultado = false;
            try
            {
                oconexion.Open();
                ocomando.ExecuteNonQuery();
                BolResultado = true;
            }
            catch (Exception e)
            {
                throw new Exception("Elimina():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
            }
            return BolResultado;
        }

        public Triaje CargarDatosEntidad(SqlDataReader oDataReader)
        {
            Triaje ObeTriaje = new Triaje();

            try
            {
                ObeTriaje = new Triaje(
                    oDataReader.GetInt32((int)Triaje.CAMPOS.IdTriaje),
                    oDataReader.GetString((int)Triaje.CAMPOS.Nombres),
                    oDataReader.GetString((int)Triaje.CAMPOS.Nacionalidad),
                    oDataReader.GetString((int)Triaje.CAMPOS.TipoDocumento),
                    oDataReader.GetString((int)Triaje.CAMPOS.Departamento),
                    oDataReader.GetString((int)Triaje.CAMPOS.NumeroDocumento),
                    oDataReader.GetString((int)Triaje.CAMPOS.Respuesta1),
                    oDataReader.GetString((int)Triaje.CAMPOS.Respuesta2),
                    oDataReader.GetString((int)Triaje.CAMPOS.Respuesta3),
                    oDataReader.GetString((int)Triaje.CAMPOS.Respuesta4),
                    oDataReader.GetString((int)Triaje.CAMPOS.Respuesta5),
                    oDataReader.GetString((int)Triaje.CAMPOS.Respuesta6),
                    oDataReader.GetString((int)Triaje.CAMPOS.FechaTriaje),
                    oDataReader.GetString((int)Triaje.CAMPOS.Estado),
                    oDataReader.GetInt32((int)Triaje.CAMPOS.IdMapa)
                    
                    //oDataReader.GetString((int)Triaje.CAMPOS.Address)


                    );
            }
            catch (Exception e)
            {
                ObeTriaje = null;
                throw new Exception("CargarDatosEntidad():" + e.Message);
            }
            finally
            {
            }
            return ObeTriaje;
        }
        private SqlCommand CargarParametrosStore(Triaje pTriaje_BE)
        {
            SqlCommand ocomando = new SqlCommand();
            try
            {
                ocomando.Parameters.Add("@IdTriaje", SqlDbType.Int).Value = pTriaje_BE.IdTriaje;
                ocomando.Parameters.Add("@Nombre", SqlDbType.VarChar, 250).Value = pTriaje_BE.Nombres;
                ocomando.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 250).Value = pTriaje_BE.Nacionalidad;
                ocomando.Parameters.Add("@Departamento", SqlDbType.VarChar, 250).Value = pTriaje_BE.Departamento;
                ocomando.Parameters.Add("@TipoDocumento", SqlDbType.VarChar, 250).Value = pTriaje_BE.TipoDocumento;
                ocomando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 250).Value = pTriaje_BE.NumeroDocumento;
                ocomando.Parameters.Add("@Respuesta1", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta1;
                ocomando.Parameters.Add("@Respuesta2", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta2;
                ocomando.Parameters.Add("@Respuesta3", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta3;
                ocomando.Parameters.Add("@Respuesta4", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta4;
                ocomando.Parameters.Add("@Respuesta5", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta5;
                ocomando.Parameters.Add("@Respuesta6", SqlDbType.VarChar, 250).Value = pTriaje_BE.Respuesta6;
                ocomando.Parameters.Add("@FechaTriaje", SqlDbType.VarChar, 250).Value = pTriaje_BE.FechaTriaje;
                ocomando.Parameters.Add("@Estado", SqlDbType.VarChar, 250).Value = pTriaje_BE.Estado;
                ocomando.Parameters.Add("@IdMapa ", SqlDbType.VarChar, 250).Value = pTriaje_BE.IdMapa;



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