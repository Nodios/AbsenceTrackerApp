using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.ComponentModel.DataAnnotations;
using Microsoft.Owin.Security;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace AbsenceTracker.LoginAuthentication
{
    public class test
    {
        public void SignIn(string userName, string password)
        {
            string server = "192.168.21.10";
            DirectoryEntry localMachine = new DirectoryEntry
                ("LDAP://" + server);

            var item2 = localMachine.Children;


        }

    }



}
