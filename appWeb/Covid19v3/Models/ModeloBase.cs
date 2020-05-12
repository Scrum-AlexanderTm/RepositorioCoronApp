using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{

    [DataContract]

    public class ModeloBase
    {
        public enum CAMPOSVALIDACION
        {
            Numero = 0,
            DescripcionValidacion = 1
        }


        [DataMember]
        public Boolean Eliminado { get; set; }


        [DataMember]
        public Int32 CodigoError { get; set; }
        [DataMember]
        public String DescripcionError { get; set; }

        [DataMember]
        public String MensajeError { get; set; }


        public ModeloBase()
        {
            LimpiarProiedades();
        }

        private void LimpiarProiedades()
        {
            CodigoError = 0;
            DescripcionError = "";
        }
        public ModeloBase(Int32 pCodigoError, String pMensaje)
        {
            LimpiarProiedades();
            CodigoError = pCodigoError;
            DescripcionError = pMensaje;
        }

    }
}