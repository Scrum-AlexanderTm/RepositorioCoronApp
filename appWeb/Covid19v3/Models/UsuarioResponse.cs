 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Covid19v3.Models
{
    [DataContract]
    public class UsuarioResponse : IDisposable
    {


        Usuario _ObjUsuario = new Usuario();
        List<Usuario> _ObjListaUsuario = new List<Usuario>();

        [DataMember]
        public Usuario ObjUsuario { get { return _ObjUsuario; } set { _ObjUsuario = value; } }

        [DataMember]
        public List<Usuario> ObjListaUsuario { get { return _ObjListaUsuario; } set { _ObjListaUsuario = value; } }

        public UsuarioResponse()
        {
            _ObjUsuario = new Usuario();
            _ObjListaUsuario = new List<Usuario>();
        }

        public void Dispose()
        {
            GC.ReRegisterForFinalize(this);
        }
    }

}