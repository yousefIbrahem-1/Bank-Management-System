using Bank_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank
{
    internal class clsValidatoin
    {
        public  enum enPermissions
        {
            PAll =65535, pShowEmployees = 1, pShowClients = 2, pAddEmployee = 4,
            pAddEmployeesLog = 8, pUpdateEmployee = 16, pUpdateEmployeesLog = 32, PDeleteEmployee = 64, PDeleteEmployeesLog = 128,
            pAddClient = 256, pAddClientsLog = 512, pUpdateClient = 1024, pUpdateClientsLog = 2048,PDeleteClient=4096, PDeleteClientsLog = 8192,
            PTransfer=16384, pTransactionsLog=32768
        };

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }
       public static bool CheckAccessPermission(enPermissions Permissions)
        {
            if (clsGlobal.CurrentEmployee.Permissons==((int)enPermissions.PAll))
                return true;

            if (((int)Permissions & clsGlobal.CurrentEmployee.Permissons).Equals((int)Permissions))
                return true;
           
                return false;

        }

        public static bool CheckAccessPermission(enPermissions Permissions,clsEmployee Employee)
        {
            if (Employee.Permissons == ((int)enPermissions.PAll))
                return true;

            if (((int)Permissions & Employee.Permissons)==((int)Permissions))
                return true;

            return false;

        }
    }
}
