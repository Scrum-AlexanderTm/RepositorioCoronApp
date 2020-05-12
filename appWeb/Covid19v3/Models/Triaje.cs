using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class Triaje : ModeloBase
    {

        public enum CAMPOS
        {
            IdTriaje = 0,
            Nombres = 1,
            Nacionalidad=2,
            Departamento = 3,
            TipoDocumento = 4,
            NumeroDocumento = 5,
            Respuesta1 = 6,
            Respuesta2 = 7,
            Respuesta3 = 8,
            Respuesta4 = 9,
            Respuesta5 = 10,
            Respuesta6  = 11,
            FechaTriaje = 12,
            Estado = 13,

            IdMapa = 14
        }

        #region Miembros privados
        private System.Int32 _IdTriaje;
        private System.String _Nombres;
        private System.String _Departamento;
        private System.String _Nacionalidad;
        private System.String _TipoDocumento;
        private System.String _NumeroDocumento;
        private System.String _Respuesta1;
        private System.String _Respuesta2;
        private System.String _Respuesta3;
        private System.String _Respuesta4;
        private System.String _Respuesta5;
        private System.String _Respuesta6=default;
        private System.String _FechaTriaje;
        private System.String _Longitud;
        private System.String _Latitud;
        private System.String _Estado;
        private System.Int32 _IdMapa;

        #endregion

        #region Propiedades

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdTriaje
        {
            get { return this._IdTriaje; }
            set { this._IdTriaje = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdMapa
        {
            get { return this._IdMapa; }
            set { this._IdMapa = value; }
        }
      
        [DataMember(EmitDefaultValue = false)]
        public System.String Nombres
        {
            get { return this._Nombres; }
            set { this._Nombres = value == null ? "" : value; }
        }
        [DataMember(EmitDefaultValue = false)]
        public System.String Longitud
        {
            get { return this._Longitud; }
            set { this._Longitud = value == null ? "" : value; }
        }
        [DataMember(EmitDefaultValue = false)]
        public System.String Latitud
        {
            get { return this._Latitud; }
            set { this._Latitud = value == null ? "" : value; }
        }


        [DataMember(EmitDefaultValue = false)]
        public System.String Departamento
        {
            get { return this._Departamento; }
            set { this._Departamento = value == null ? "" : value; }
        }
        [DataMember(EmitDefaultValue = false)]
        public System.String Nacionalidad
        {
            get { return this._Nacionalidad; }
            set { this._Nacionalidad = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String TipoDocumento
        {
            get { return this._TipoDocumento; }
            set { this._TipoDocumento = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String NumeroDocumento
        {
            get { return this._NumeroDocumento; }
            set { this._NumeroDocumento = value == null ? "" : value; ; }
        }



        [DataMember(EmitDefaultValue = false)]
        public System.String Respuesta1
        {
            get { return this._Respuesta1; }
            set { this._Respuesta1 = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Respuesta2
        {
            get { return this._Respuesta2; }
            set { this._Respuesta2 = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Respuesta3
        {
            get { return this._Respuesta3; }
            set { this._Respuesta3 = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Respuesta4
        {
            get { return this._Respuesta4; }
            set { this._Respuesta4 = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Respuesta5
        {
            get { return this._Respuesta5; }
            set { this._Respuesta5 = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Respuesta6
        {
            get { return this._Respuesta6; }
            set {this._Respuesta5 = value == null ? "" : value;}
        } 

        [DataMember(EmitDefaultValue = false)]
        public System.String FechaTriaje
        {
            get { return this._FechaTriaje; }
            set { this._FechaTriaje = value == null ? "" : value; }
        }


        [DataMember(EmitDefaultValue = false)]
        public System.String Estado
        {
            get { return this._Estado; }
            set { this._Estado = value == null ? "" : value; }
        }


        #endregion

        public Triaje()
        {
            this.LimpiarPropiedades();
        }

        public Triaje(
                System.Int32 PIdTriaje,
                System.String PNombres,
                System.String PNacionalidad,
                System.String PDepartamento,
                System.String PTipoDocumento,
                System.String PNumeroDocumento,
                System.String PRespuesta1,
                System.String PRespuesta2,
                System.String PRespuesta3,
                System.String PRespuesta4,
                System.String PRespuesta5,
                System.String PRespuesta6,
                System.String PFechaTriaje,
                System.String PEstado,
                System.Int32 PIdMapa

               )
        {
            this.LimpiarPropiedades();
            this._IdTriaje = PIdTriaje;
            this._Nombres = PNombres;
            this._Nacionalidad = PNacionalidad;
            this._Departamento = PDepartamento;
            this._TipoDocumento = PTipoDocumento;
            this._NumeroDocumento = PNumeroDocumento;
            this._Respuesta1 = PRespuesta1;
            this._Respuesta2 = PRespuesta2;
            this._Respuesta3 = PRespuesta3;
            this._Respuesta4 = PRespuesta4;
            this._Respuesta5 = PRespuesta5;
            this._Respuesta6 = PRespuesta6;
            this._FechaTriaje = PFechaTriaje;
            this._Estado = PEstado;
            this._IdMapa = PIdMapa;



        }

        public void LimpiarPropiedades()
        {

            this._IdTriaje = 0;
            this._Nombres = "";
            this._Nacionalidad = "";
            this._Departamento = "";
            this._TipoDocumento = "";
            this._NumeroDocumento = "";
            this._Respuesta1 = "";
            this._Respuesta2 = "";
            this._Respuesta3 = "";
            this._Respuesta4 = "";
            this._Respuesta5 = "";
            this._Respuesta6 = "";
            this._FechaTriaje = "";
            this._Estado = "";
            this._IdMapa = 0;

        }
    }
}