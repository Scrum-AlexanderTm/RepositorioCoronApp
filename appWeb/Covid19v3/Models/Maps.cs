using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class Maps : ModeloBase
    {

        public enum CAMPOS
        {
            IdMapa = 0,
            Rating = 1,
            Address = 2,
            Lat = 3,
            Long = 4,
            Zoom = 5
        }

        #region Miembros privados
        private System.Int32 _IdMapa;
        private System.Int32 _Rating;
        private System.String _Address;
        private System.Double _Lat;
        private System.Double _Long;
        private System.Int32 _Zoom;
        #endregion

        #region Propiedades

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 IdMapa
        {
            get { return this._IdMapa; }
            set { this._IdMapa = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 Rating
        {
            get { return this._Rating; }
            set { this._Rating = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.String Address
        {
            get { return this._Address; }
            set { this._Address = value == null ? "" : value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.Double Lat
        {
            get { return this._Lat; }
            set { this._Lat = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.Double Long
        {
            get { return this._Long; }
            set { this._Long = value; }
        }

        [DataMember(EmitDefaultValue = false)]
        public System.Int32 Zoom
        {
            get { return this._Zoom; }
            set { this._Zoom = value; }
        }

       
        #endregion

        public Maps()
        {
            this.LimpiarPropiedades();
        }

        public Maps(

                System.Int32 PIdMapa,
                System.Int32 PRating,
                System.String PAddress,
                System.Double PLat,
                System.Double PLong,
                System.Int32 PZoom
            )
        {
            this.LimpiarPropiedades();
            this._IdMapa = PIdMapa;
            this._Rating = PRating;
            this._Address = PAddress;
            this._Lat = PLat;
            this._Long = PLong;
            this._Zoom = PZoom;
            
        }

        public void LimpiarPropiedades()
        {

            this._IdMapa = 0;
            this._Rating = 0;
            this._Address = "";
            this._Lat = 0;
            this._Long = 0;
            this._Zoom = 0;
            
        }

    }
}