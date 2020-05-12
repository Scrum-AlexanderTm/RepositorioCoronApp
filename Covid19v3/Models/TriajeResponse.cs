using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class TriajeResponse: IDisposable
    {
        Triaje _ObjTriaje = new Triaje();
        List<Triaje> _ObjListaTriaje = new List<Triaje>();

        [DataMember]
        public Triaje ObjTriaje { get { return _ObjTriaje; } set { _ObjTriaje = value; } }

        [DataMember]
        public List<Triaje> ObjListaTriaje { get { return _ObjListaTriaje; } set { _ObjListaTriaje = value; } }

        public TriajeResponse()
        {
            _ObjTriaje = new Triaje();
            _ObjListaTriaje = new List<Triaje>();
        }

        public void Dispose()
        {
            GC.ReRegisterForFinalize(this);
        }
    }
}