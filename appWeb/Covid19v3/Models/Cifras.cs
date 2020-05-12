using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{

    [DataContract]
    public class Cifras : ModeloBase
    {

        public enum CAMPOS
        {

            //IdCifras = 0,
            PruebasRealizadas= 0,
            CasosConfirmados = 1,
            Hospitalizados = 2,
            Recuperados = 3,
            Fallecidos = 4
            //FechaPrueba = 6,
            //FechaConfirmado = 7,
            //FechaHospitalizado = 8,
            //FechaFallecido = 9,
            //IdTriaje = 10
        }
        #region Miembros privados
        private System.Int32 _IdCifras;
        private System.Int32 _PruebasRealizadas;
        private System.Int32 _CasosConfirmados;
        private System.Int32 _Hospitalizados;
        private System.Int32 _Recuperados;
        private System.Int32 _Fallecidos;
        //private System.String _FechaPrueba;
        //private System.String _FechaConfirmado;
        //private System.String _FechaHospitalizado;
        //private System.String _FechaFallecido;
        private System.Int32 _IdTriaje;

        #endregion
        #region Propiedades
        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdCifras
        {
            get { return this._IdCifras; }
            set { this._IdCifras = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 PruebasRealizadas
        {
            get { return this._PruebasRealizadas; }
            set { this._PruebasRealizadas = value; }
        }
        [DataMember(EmitDefaultValue = false)]
        public System.Int32 CasosConfirmados
        {
            get { return this._CasosConfirmados; }
            set { this._CasosConfirmados = value; }
        }
        [DataMember(EmitDefaultValue = false)]
        public System.Int32 Hospitalizados
        {
            get { return this._Hospitalizados; }
            set { this._Hospitalizados = value ; }
        }
        [DataMember(EmitDefaultValue = false)]
        public System.Int32 Recuperados
        {
            get { return this._Recuperados; }
            set { this._Recuperados = value ; }
        }
        [DataMember(EmitDefaultValue = false)]
        public System.Int32 Fallecidos
        {
            get { return this._Fallecidos; }
            set { this._Fallecidos = value; }
        }
        //[DataMember(EmitDefaultValue = false)]
        //public System.String FechaPrueba
        //{
        //    get { return this._FechaPrueba; }
        //    set { this._FechaPrueba = value == null ? "" : value; }
        //}
        //[DataMember(EmitDefaultValue = false)]
        //public System.String FechaConfirmado
        //{
        //    get { return this._FechaConfirmado; }
        //    set { this._FechaConfirmado = value == null ? "" : value; }
        //}
        //[DataMember(EmitDefaultValue = false)]
        //public System.String FechaHospitalizado
        //{
        //    get { return this._FechaHospitalizado; }
        //    set { this._FechaHospitalizado = value == null ? "" : value; }
        //}
        //[DataMember(EmitDefaultValue = false)]
        //public System.String FechaFallecido
        //{
        //    get { return this._FechaFallecido; }
        //    set { this._FechaFallecido = value == null ? "" : value; }
        //}
        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdTriaje
        {
            get { return this._IdTriaje; }
            set { this._IdTriaje = value ; }
        }
        #endregion
        public Cifras()
        {
            this.LimpiarPropiedades();
        }

        public Cifras(
                //System.Int32 PIdCifras,
                System.Int32 PPruebasRealizadas,
                System.Int32 PCasosConfirmados,
                System.Int32 PHospitalizados,
                System.Int32 PRecuperados,
                System.Int32 PFallecidos
                //System.String PFechaPrueba,
                //System.String PFechaConfirmado,
                //System.String PFechaHospitalizado,
                //System.String PFechaFallecido,
                //System.Int32 PIdTriaje

               )
        {
            this.LimpiarPropiedades();
            //this._IdCifras = PIdCifras;
            this._PruebasRealizadas = PPruebasRealizadas;
            this._CasosConfirmados = PCasosConfirmados;
            this._Hospitalizados = PHospitalizados;
            this._Recuperados = PRecuperados;
            this._Fallecidos = PFallecidos;
            //this._FechaPrueba = PFechaPrueba;
            //this._FechaConfirmado = PFechaConfirmado;
            //this._FechaHospitalizado = PFechaHospitalizado;
            //this._FechaFallecido = PFechaFallecido;
            //this._IdTriaje = PIdTriaje;
        }

        public void LimpiarPropiedades()
        {

            //this._IdCifras = 0;
            this._PruebasRealizadas = 0;
            this._CasosConfirmados = 0;
            this._Hospitalizados = 0;
            this._Recuperados = 0;
            this._Fallecidos = 0;
            //this._FechaPrueba = "";
            //this._FechaConfirmado = "";
            //this._FechaHospitalizado = "";
            //this._FechaFallecido = "";
            //this._IdTriaje = 0;
           

        }
    }
}