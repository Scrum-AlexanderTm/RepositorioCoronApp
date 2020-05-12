using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class Rol : ModeloBase
    {

        public enum CAMPOS
        {
            IdRol = 0,
            Nombres = 1
        }

        #region Miembros privados
        private System.Int32 _IdRol;
        private System.String _Nombres;
        
        #endregion

        #region Propiedades

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdRol
        {
            get { return this._IdRol; }
            set { this._IdRol = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Nombres
        {
            get { return this._Nombres; }
            set { this._Nombres = value == null ? "" : value; }
        }


        #endregion

        public Rol()
        {
            this.LimpiarPropiedades();
        }

        public Rol(
                System.Int32 PIdRol,
                System.String PNombres)
        {
            this.LimpiarPropiedades();
            this._IdRol = PIdRol;
            

        }

        public void LimpiarPropiedades()
        {

            this._IdRol = 0;
            this._Nombres = "";
            
        }

    }
}