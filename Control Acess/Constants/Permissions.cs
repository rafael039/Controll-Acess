using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control_Acess.Constants
{
    public class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
        }
        public static class Usuarios
        {
            public const string View = "Permissions.Usuarios.View";
            public const string Create = "Permissions.Usuarios.Create";
            public const string Edit = "Permissions.Usuarios.Edit";
            public const string Delete = "Permissions.Usuarios.Delete";
        }
    }
}
