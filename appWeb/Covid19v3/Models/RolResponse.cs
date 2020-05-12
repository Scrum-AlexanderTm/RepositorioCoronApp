using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class RolResponse : IDisposable
    {


        Rol _ObjRol = new Rol();
        List<Rol> _ObjListaRol = new List<Rol>();

        [DataMember]
        public Rol ObjRol { get { return _ObjRol; } set { _ObjRol = value; } }

        [DataMember]
        public List<Rol> ObjListaRol { get { return _ObjListaRol; } set { _ObjListaRol = value; } }

        public RolResponse()
        {
            _ObjRol = new Rol();
            _ObjListaRol = new List<Rol>();
        }

        public void Dispose()
        {
            GC.ReRegisterForFinalize(this);
        }
    }

}