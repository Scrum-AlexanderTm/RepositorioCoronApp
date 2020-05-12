using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{

    [DataContract]
    public class CifrasResponse : IDisposable
    {
        Cifras _ObjCifras = new Cifras();
        List<Cifras> _ObjListaCifras = new List<Cifras>();

        [DataMember]
        public Cifras ObjCifras { get { return _ObjCifras; } set { _ObjCifras = value; } }

        [DataMember]
        public List<Cifras> ObjListaCifras { get { return _ObjListaCifras; } set { _ObjListaCifras = value; } }

        public CifrasResponse()
        {
            _ObjCifras = new Cifras();
            _ObjListaCifras = new List<Cifras>();
        }

        public void Dispose()
        {
            GC.ReRegisterForFinalize(this);
        }
    }
}