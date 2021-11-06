using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices.AccountManagement;

namespace ConexaoRemotaTS
{
     public class DescobrirTS
    {

        public string consultaservidor(string usuario)
        {
            if (usuario == null)
            {
                return "";
            }
            //PrincipalContext yourDomain = new PrincipalContext(ContextType.Domain);            
            PrincipalContext yourDomain = new PrincipalContext(ContextType.Domain);
            // find the user
            UserPrincipal user = UserPrincipal.FindByIdentity(yourDomain, usuario);
            if (user == null)
            {
                return "";
            }
            else
            {
                return user.Description;
            }
        }
    }
}
