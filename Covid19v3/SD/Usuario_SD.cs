using Covid19v3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Covid19v3.SD
{
    public class Usuario_SD : ClaseBase
    {

        public List<Usuario> Listar()
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            Usuario pUsuario_BE = new Usuario();
            SqlCommand ocomando = CargarParametrosStore(pUsuario_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspUsuario_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Usuario> oLista = new List<Usuario>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Usuario obeUsuario = new Usuario();
                    obeUsuario = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeUsuario);
                    obeUsuario = null;
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

        public List<Usuario> Listar(Usuario pUsuario_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pUsuario_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspUsuario_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            List<Usuario> oLista = new List<Usuario>();
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Usuario obeUsuario = new Usuario();
                    obeUsuario = CargarDatosEntidad(oDataReader);
                    oLista.Add(obeUsuario);
                    obeUsuario = null;
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
        public Usuario ListarKey(System.Int32 pCodigoUsuario)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspUsuario_ListarKey]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            Usuario ObeUsuario = new Usuario();
            ocomando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = pCodigoUsuario;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    ObeUsuario = CargarDatosEntidad(oDataReader);
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
            return ObeUsuario;
        }
        public Usuario ObtenerUsuario(System.String pUsuario)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspUsuario_ObtenerUsuario]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            Usuario ObeUsuario = new Usuario();
            ocomando.Parameters.Add("@Usuario", SqlDbType.VarChar,250).Value = pUsuario;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    ObeUsuario = CargarDatosEntidad(oDataReader);
                    break;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ObtenerUsuario():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return ObeUsuario;
        }
        public DataTable Lista(Usuario pUsuario_BE)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = CargarParametrosStore(pUsuario_BE);
            ocomando.CommandText = "[" + this.EsquemaBaseDatos() + "].[uspUsuario_Listar]";
            ocomando.Connection = oconexion;
            ocomando.CommandType = CommandType.StoredProcedure;
            DataTable oDt = new DataTable("Usuario");
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

        public string RegistraModifica(Usuario pUsuario_BE, string pTipoTransaccion)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspUsuario_RegistraModifica]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@TipoTransaccion", SqlDbType.Char, 1).Value = pTipoTransaccion;
            ocomando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = pUsuario_BE.IdUsuario;
            ocomando.Parameters.Add("@Nombre", SqlDbType.VarChar, 250).Value = pUsuario_BE.Nombres;
            ocomando.Parameters.Add("@FechaNacimiento", SqlDbType.VarChar, 250).Value = pUsuario_BE.FechaNacimiento;
            //ocomando.Parameters.Add("@Departamento", SqlDbType.VarChar, 250).Value = pUsuario_BE.Departamento;
            ocomando.Parameters.Add("@TipoDocumento", SqlDbType.VarChar, 250).Value = pUsuario_BE.TipoDocumento;
            //ocomando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 250).Value = pUsuario_BE.NumeroDocumento;
            //ocomando.Parameters.Add("@Telefono", SqlDbType.VarChar, 250).Value = pUsuario_BE.Telefono;
            //ocomando.Parameters.Add("@FechaRegistro", SqlDbType.VarChar,250).Value = pUsuario_BE.FechaRegistro;
            //ocomando.Parameters.Add("@IdRol", SqlDbType.Int, 250).Value = pUsuario_BE.IdRol;
            //ocomando.Parameters.Add("@Login", SqlDbType.VarChar, 250).Value = pUsuario_BE.Login;
            //ocomando.Parameters.Add("@Clave", SqlDbType.VarChar, 250).Value = pUsuario_BE.Clave;
            //ocomando.Parameters["@IdEncuesta"].Direction = ParameterDirection.InputOutput;
            string StrResultado = "";
            try
            {
                oconexion.Open();
                ocomando.ExecuteNonQuery();
                StrResultado = ocomando.Parameters["@Nombre"].Value.ToString();

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


        public Boolean Elimina(System.Int32 pCodigoUsuario)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspUsuario_Elimina]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            ocomando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = pCodigoUsuario;
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

        public string[] ListarRolUsuario(System.String pUsuario)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspUsuario_ListarRol]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            string[] oLista=null;
            string nombre;
            ocomando.Parameters.Add("@Usuario", SqlDbType.VarChar,250).Value = pUsuario;
            try
            {
                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                while (oDataReader.Read())
                {
                    Rol obeRol = new Rol();
                    obeRol.Nombres = oDataReader.GetString(0);
                    nombre= oDataReader.GetString(0); 
                    oLista =new string[1] {nombre};
                    obeRol = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ListarRolUsuario():" + e.Message);
            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return oLista;
        }

        public Usuario ValidarAcceso(String pLoginUsuario, String pContrasenia)
        {
            SqlConnection oconexion = new SqlConnection(this.CadenaConexion());
            SqlCommand ocomando = new SqlCommand("[" + this.EsquemaBaseDatos() + "].[uspUsuario_ValidarUsuario]", oconexion);
            ocomando.CommandType = CommandType.StoredProcedure;
            Usuario ObeUsuario = new Usuario();

            ocomando.Parameters.Add("@Username", SqlDbType.VarChar, 250).Value = pLoginUsuario;
            ocomando.Parameters.Add("@Password", SqlDbType.VarChar, 5000).Value = pContrasenia;
            try
            {

                oconexion.Open();
                SqlDataReader oDataReader = ocomando.ExecuteReader();
                
                while (oDataReader.Read())
                {
                    ObeUsuario = CargarDatosEntidad(oDataReader);
                    break;
                }
            }
            catch (Exception)
            {
                ObeUsuario = null;

            }
            finally
            {
                if (oconexion.State == ConnectionState.Open) { oconexion.Close(); }
                ocomando.Dispose();
                oconexion.Dispose();
            }
            return ObeUsuario;
        }

        public Usuario CargarDatosEntidad(SqlDataReader oDataReader)
        {
            Usuario ObeUsuario = new Usuario();

            try
            {
                ObeUsuario = new Usuario(
                    oDataReader.GetInt32((int)Usuario.CAMPOS.IdUsuario),
                    oDataReader.GetString((int)Usuario.CAMPOS.Nombres),
                    oDataReader.GetString((int)Usuario.CAMPOS.FechaNacimiento),
                    //oDataReader.GetString((int)Usuario.CAMPOS.Departamento),
                    oDataReader.GetString((int)Usuario.CAMPOS.TipoDocumento),
                    //oDataReader.GetString((int)Usuario.CAMPOS.NumeroDocumento),
                    //oDataReader.GetString((int)Usuario.CAMPOS.Telefono),
                    oDataReader.GetString((int)Usuario.CAMPOS.FechaNacimiento),
                    oDataReader.GetInt32((int)Usuario.CAMPOS.IdRol),
                    oDataReader.GetString((int)Usuario.CAMPOS.Login),
                    oDataReader.GetString((int)Usuario.CAMPOS.Clave)
                    );
            }
            catch (Exception e)
            {
                ObeUsuario = null;
                throw new Exception("CargarDatosEntidad():" + e.Message);
            }
            finally
            {
            }
            return ObeUsuario;
        }
        private SqlCommand CargarParametrosStore(Usuario pUsuario_BE)
        {
            SqlCommand ocomando = new SqlCommand();
            try
            {
                ocomando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = pUsuario_BE.IdUsuario;
                ocomando.Parameters.Add("@Nombre", SqlDbType.VarChar, 250).Value = pUsuario_BE.Nombres;
                ocomando.Parameters.Add("@FechaNacimiento", SqlDbType.VarChar, 250).Value = pUsuario_BE.FechaNacimiento;
                //ocomando.Parameters.Add("@Departamento", SqlDbType.VarChar, 250).Value = pUsuario_BE.Departamento;
                ocomando.Parameters.Add("@TipoDocumento", SqlDbType.VarChar, 250).Value = pUsuario_BE.TipoDocumento;
                //ocomando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 250).Value = pUsuario_BE.NumeroDocumento;
                //ocomando.Parameters.Add("@Telefono", SqlDbType.VarChar, 250).Value = pUsuario_BE.Telefono;
                ocomando.Parameters.Add("@FechaRegistro", SqlDbType.VarChar).Value = pUsuario_BE.FechaRegistro;
                ocomando.Parameters.Add("@IdRol", SqlDbType.Int, 250).Value = pUsuario_BE.IdRol;
                ocomando.Parameters.Add("@Login", SqlDbType.VarChar, 250).Value = pUsuario_BE.Login;
                ocomando.Parameters.Add("@Clave", SqlDbType.VarChar, 250).Value = pUsuario_BE.Clave;


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