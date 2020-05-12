using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class MapsResponse: IDisposable
    {

        Maps _ObjMaps = new Maps();
        List<Maps> _ObjListaMaps = new List<Maps>();

        [DataMember]
        public Maps ObjMaps { get { return _ObjMaps; } set { _ObjMaps = value; } }

        [DataMember]
        public List<Maps> ObjListaMaps { get { return _ObjListaMaps; } set { _ObjListaMaps = value; } }

        public MapsResponse()
        {
            _ObjMaps = new Maps();
            _ObjListaMaps = new List<Maps>();
        }

        public void Dispose()
        {
            GC.ReRegisterForFinalize(this);
        }
    }
}