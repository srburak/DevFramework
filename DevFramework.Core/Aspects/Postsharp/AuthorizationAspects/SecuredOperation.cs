using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace DevFramework.Core.Aspects.Postsharp.AuthorizationAspects
{
    [PSerializable]
    public class SecuredOperation:OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorized = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (Thread.CurrentPrincipal.IsInRole(roles[i]))
                {
                    isAuthorized = true;
                }

                if (isAuthorized==false)
                {
                    throw new SecurityException("You are not authorized");
                }
            }
        }
    }
}
