using Covid19v3.Models;
using Covid19v3.SD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Covid19v3
{
    public class WebRolProvider : RoleProvider
    {
        private Usuario_SD oUsuario_SD = new Usuario_SD();
        private UsuarioResponse oREspuesta = new UsuarioResponse();
        private RolResponse oREspuesta2 = new RolResponse();
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
           
            
            
            var r = oUsuario_SD.ListarRolUsuario(username);
            Console.WriteLine("Nombre de Rol ..................." + r);
            if (r [0]==null || r[0] == "") {
                throw new NotImplementedException();
            }
            return r;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}