using Covid19v3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Covid19v3.SD
{
    public class Cifras_SD:ClaseBase
    {
        public List<Cifras> Listar()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            Cifras pCifras_BE = new Cifras();
            SqlCommand ocomando = CargarParametrosStore(pCifras_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspCifras_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Cifras> oLista = new List<Cifras>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Cifras obeCifras = new Cifras();
                    obeCifras = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeCifras);
                    obeCifras = null;
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
        public List<Cifras> ListarReporte()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspCifras_ListaCifras]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Cifras> oLista = new List<Cifras>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Cifras obeCifras = new Cifras();
                    obeCifras = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeCifras);
                    obeCifras = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarReporte():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Cifras> ListarReporteDepartamento(System.String pDepartamento)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspCifras_ListaCifrasDepartamento]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Cifras> oLista = new List<Cifras>();
            ocomando.Parameters.Add("@Departamento", SqlDbType.VarChar, 250).Value = pDepartamento;

            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Cifras obeCifras = new Cifras();
                    obeCifras = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeCifras);
                    obeCifras = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarReporteDepartamento():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }
        public List<Cifras> Listar(Cifras pCifras_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pCifras_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspCifras_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Cifras> oLista = new List<Cifras>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Cifras obeCifras = new Cifras();
                    obeCifras = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeCifras);
                    obeCifras = null;
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
        public Cifras ListarKey(System.Int32 pCodigoCifras)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspCifras_ListarKey]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            Cifras ObeCifras = new Cifras();
            ocomando.Parameters.Add("@IdCifras", SqlDbType.Int).Value = pCodigoCifras;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    ObeCifras = CargarDatosEntidad(oDataReader);
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
            return ObeCifras;
        }
        public DataTable Lista(Cifras pCifras_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pCifras_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspCifras_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            DataTable oDt = new DataTable("Cifras");
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

        public int RegistraPrueba(Cifras pCifras_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspCifras_RegistraPrueba]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@PruebasRealizadas", SqlDbType.Int).Value = pCifras_BE.PruebasRealizadas;
            ocomando.Parameters.Add("@IdTriaje", SqlDbType.Int).Value = pCifras_BE.IdTriaje;
            //ocomando.Parameters["@IdTriaje"].Direction = ParameterDirection.InputOutput;
            int StrResultado = 0;
            try
            {
                oconexion.Open();
                ocomando.ExecuteNonQuery();
                StrResultado = int.Parse(ocomando.Parameters["@IdTriaje"].Value.ToString());

            }
            catch (Exception e)
            {
                throw new Exception("RegistraPrueba():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return StrResultado;
        }
        public int RegistraConfirmado(Cifras pCifras_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspCifras_RegistraConfirmado]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@CasosConfirmados", SqlDbType.Int).Value = pCifras_BE.CasosConfirmados;
            ocomando.Parameters.Add("@IdTriaje", SqlDbType.Int).Value = pCifras_BE.IdTriaje;
            //ocomando.Parameters["@IdTriaje"].Direction = ParameterDirection.InputOutput;
            int StrResultado = 0;
            try
            {
                oconexion.Open();
                ocomando.ExecuteNonQuery();
                StrResultado = int.Parse(ocomando.Parameters["@IdTriaje"].Value.ToString());

            }
            catch (Exception e)
            {
                throw new Exception("RegistraConfirmado():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return StrResultado;
        }
        public int RegistraHospitalizado(Cifras pCifras_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspCifras_RegistraHospitalizado]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@Hospitalizados", SqlDbType.Int).Value = pCifras_BE.Hospitalizados;
            ocomando.Parameters.Add("@IdTriaje", SqlDbType.Int).Value = pCifras_BE.IdTriaje;
            //ocomando.Parameters["@IdTriaje"].Direction = ParameterDirection.InputOutput;
            int StrResultado = 0;
            try
            {
                oconexion.Open();
                ocomando.ExecuteNonQuery();
                StrResultado = int.Parse(ocomando.Parameters["@IdTriaje"].Value.ToString());

            }
            catch (Exception e)
            {
                throw new Exception("RegistraHospitalizado():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return StrResultado;
        }
        public int RegistraRecuperadoFallecido(Cifras pCifras_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspCifras_RegistraHospitalizadoFR]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@Recuperados", SqlDbType.Int).Value = pCifras_BE.Recuperados;
            ocomando.Parameters.Add("@Fallecidos", SqlDbType.Int).Value = pCifras_BE.Fallecidos;
            ocomando.Parameters.Add("@IdTriaje", SqlDbType.Int).Value = pCifras_BE.IdTriaje;
            //ocomando.Parameters["@IdTriaje"].Direction = ParameterDirection.InputOutput;
            int StrResultado = 0;
            try
            {
                oconexion.Open();
                ocomando.ExecuteNonQuery();
                StrResultado = int.Parse(ocomando.Parameters["@IdTriaje"].Value.ToString());

            }
            catch (Exception e)
            {
                throw new Exception("RegistraRecuperadoFallecido():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return StrResultado;
        }


        public Cifras CargarDatosEntidad(SqlDataReader oDataReader)
        {
            Cifras ObeCifras = new Cifras();

            try
            {
                ObeCifras = new Cifras(
                    //oDataReader.GetInt32((int)Cifras.CAMPOS.IdCifras),
                    oDataReader.GetInt32((int)Cifras.CAMPOS.PruebasRealizadas),
                    oDataReader.GetInt32((int)Cifras.CAMPOS.CasosConfirmados),
                    oDataReader.GetInt32((int)Cifras.CAMPOS.Hospitalizados),
                     oDataReader.GetInt32((int)Cifras.CAMPOS.Recuperados),
                    oDataReader.GetInt32((int)Cifras.CAMPOS.Fallecidos)
                    //oDataReader.GetString((int)Cifras.CAMPOS.FechaPrueba),
                    //oDataReader.GetString((int)Cifras.CAMPOS.FechaConfirmado),
                    //oDataReader.GetString((int)Cifras.CAMPOS.FechaHospitalizado),
                    //oDataReader.GetString((int)Cifras.CAMPOS.FechaFallecido),
                    //oDataReader.GetInt32((int)Cifras.CAMPOS.IdTriaje)

                    //oDataReader.GetString((int)Triaje.CAMPOS.Address)


                    );
            }
            catch (Exception e)
            {
                ObeCifras = null;
                throw new Exception("CargarDatosEntidad():" + e.Message);
            }
            finally
            {
            }
            return ObeCifras;
        }
        private SqlCommand CargarParametrosStore(Cifras pCifras_BE)
        {
            SqlCommand ocomando = new SqlCommand();
            try
            {
                ocomando.Parameters.Add("@IdCifras", SqlDbType.Int).Value = pCifras_BE.IdTriaje;
                ocomando.Parameters.Add("@PruebasRealizadas", SqlDbType.Int).Value = pCifras_BE.PruebasRealizadas;
                ocomando.Parameters.Add("@CasosConfirmados", SqlDbType.Int).Value = pCifras_BE.CasosConfirmados;
                ocomando.Parameters.Add("@Hospitalizados", SqlDbType.Int).Value = pCifras_BE.Hospitalizados;
                ocomando.Parameters.Add("@Recuperados", SqlDbType.Int).Value = pCifras_BE.Recuperados;
                ocomando.Parameters.Add("@Fallecidos", SqlDbType.Int).Value = pCifras_BE.Fallecidos;
                //ocomando.Parameters.Add("@FechaPrueba", SqlDbType.VarChar, 250).Value = pCifras_BE.FechaPrueba;
                //ocomando.Parameters.Add("@FechaConfirmado", SqlDbType.VarChar, 250).Value = pCifras_BE.FechaConfirmado;
                //ocomando.Parameters.Add("@FechaHospitalizado", SqlDbType.VarChar, 250).Value = pCifras_BE.FechaHospitalizado;
                //ocomando.Parameters.Add("@FechaFallecido", SqlDbType.VarChar, 250).Value = pCifras_BE.FechaFallecido;
                ocomando.Parameters.Add("@IdTriaje ", SqlDbType.Int).Value = pCifras_BE.IdTriaje;



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