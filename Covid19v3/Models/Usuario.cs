using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class Usuario : ModeloBase
    {

        public enum CAMPOS
        {
            IdUsuario = 0,
            Nombres = 1,
            FechaNacimiento = 2,
            // Departamento = 3,
            TipoDocumento = 3,
            // NumeroDocumento = 5,
            //Telefono = 6,
            FechaRegistro = 4,
            IdRol = 5,
            Login = 6,
            Clave = 7
        }

        #region Miembros privados
        private System.Int32 _IdUsuario;
        private System.String _Nombres;
        private System.String _FechaNacimiento;
        //private System.String _Departamento;
        private System.String _TipoDocumento;
        //private System.String _NumeroDocumento;
        //private System.String _Telefono;
        private System.String _FechaRegistro;
        private System.Int32 _IdRol;
        private System.String _Login;
        private System.String _Clave;
        #endregion

        #region Propiedades

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdUsuario
        {
            get { return this._IdUsuario; }
            set { this._IdUsuario = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Nombres
        {
            get { return this._Nombres; }
            set { this._Nombres = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String FechaNacimiento
        {
            get { return this._FechaNacimiento; }
            set { this._FechaNacimiento = value == null ? "" : value; }
        }

        //[DataMember(EmitDefaultValue = false)]
        //public System.String Departamento
        //{
        //    get { return this._Departamento; }
        //    set { this._Departamento = value == null ? "" : value; }
        //}

        [DataMember(EmitDefaultValue = false)]
        public System.String TipoDocumento
        {
            get { return this._TipoDocumento; }
            set { this._TipoDocumento = value == null ? "" : value; }
        }

        //[DataMember(EmitDefaultValue = false)]
        //public System.String NumeroDocumento
        //{
        //    get { return this._NumeroDocumento; }
        //    set { this._NumeroDocumento = value; }
        //}

        //[DataMember(EmitDefaultValue = false)]
        //public System.String Telefono
        //{
        //    get { return this._Telefono; }
        //    set { this._Telefono = value == null ? "" : value; }
        //}

        [DataMember(EmitDefaultValue = false)]
        public System.String FechaRegistro
        {
            get { return this._FechaRegistro; }
            set { this._FechaRegistro = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdRol
        {
            get { return this._IdRol; }
            set { this._IdRol = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Login
        {
            get { return this._Login; }
            set { this._Login = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Clave
        {
            get { return this._Clave; }
            set { this._Clave = value == null ? "" : value; }
        }
        #endregion

        public Usuario()
        {
            this.LimpiarPropiedades();
        }

        public Usuario(
                System.Int32 PIdUsuario,
                System.String PNombres,
                System.String PFechaNacimiento,
                //System.String PDepartamento,
                System.String PTipoDocumento,
                //System.String PNumeroDocumento,
                //System.String PTelefono,
                System.String PFechaRegistro,
                System.Int32 PIdRol,
                System.String PLogin,
                System.String PClave)
        {
            this.LimpiarPropiedades();
            this._IdUsuario = PIdUsuario;
            this._Nombres = PNombres;
            this._FechaNacimiento = PFechaNacimiento;
            //this._Departamento = PDepartamento;
            this._TipoDocumento = PTipoDocumento;
            //this._NumeroDocumento = PNumeroDocumento;
            //this._Telefono = PTelefono;
            this._FechaRegistro = PFechaRegistro;
            this._IdRol = PIdRol;
            this._Login = PLogin;
            this._Clave = PClave;
            
        }

        public void LimpiarPropiedades()
        {
          
            this._IdUsuario = 0;
            this._Nombres = "";
            this._FechaNacimiento = "";
            //this._Departamento = "";//Quitar
            this._TipoDocumento = "";
            //this._NumeroDocumento = "";//Quitar
            //this._Telefono = "";
            this._FechaRegistro = "";
            this._IdRol = 0;
            this._Login = "";
            this._Clave = "";
        }

    }

}