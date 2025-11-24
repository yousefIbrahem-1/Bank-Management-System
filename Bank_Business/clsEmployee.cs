using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using Bank_DataAccess;

namespace Bank_Business
{
    public class clsEmployee
    {
       
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public Nullable<int> EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int Permissons {  get; set; } 
        public Nullable<int> PersonID { get; set; }
      

       public clsEmployee() 
        {
            EmployeeID = null;
            UserName = string.Empty; 
            Password = string.Empty;
            IsActive = false;
            PersonID = null;
            Mode = enMode.AddNew;
        }
       private clsEmployee( Nullable<int> employeeID, string userName, string password, bool isActive,int permissions, Nullable<int> personID)
        {
            
            EmployeeID = employeeID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Permissons = permissions;
            PersonID = personID;
            Mode = enMode.Update;
        }
        
      
        public static clsEmployee Find(Nullable<int> EmployeeID)
        {
            string UserName = "", Password = ""; bool IsActive=false; Nullable<int> PersonID = null; int Permissions=0;
           bool IsFound= clsEmployeeData.GetEmployeeByID(EmployeeID, ref UserName, ref Password, ref IsActive,ref Permissions,ref PersonID);
            if (IsFound)
            {
                return new clsEmployee(EmployeeID,UserName,Password,IsActive,Permissions,PersonID);
            }
            return null;
        }
        private bool _AddNewEmployee(Nullable<int> EmployeeIDResponsible)
        {
          this.Password=clsEncryptionAndDecrypyion.Encrypt(this.Password);
            this.EmployeeID = clsEmployeeData.AddNewEmployee(this.UserName, this.Password,this.PersonID,this.Permissons,this.IsActive,EmployeeIDResponsible);
            return (this.EmployeeID != null);

        }
        private bool _UpdateEmployee(Nullable<int> EmployeeIDResponsible)
        {
            this.Password = clsEncryptionAndDecrypyion.Encrypt(this.Password);
            return clsEmployeeData.UpdateEmployee(this.EmployeeID,this.UserName, this.Password, this.PersonID,this.Permissons ,this.IsActive,EmployeeIDResponsible);
        }
        public static clsEmployee Find(string UserName,string Password)
        {
            Password = clsEncryptionAndDecrypyion.Encrypt(Password);
            bool IsActive = false ; Nullable<int> EmployeeID = null, PersonID = null; int Permissions=0;
            bool IsFound = clsEmployeeData.GetEmployeeByUsernameAndPassword(ref EmployeeID,  UserName, Password, ref IsActive,ref Permissions, ref PersonID);
            if (IsFound)
            {
                return new clsEmployee(EmployeeID, UserName, Password, IsActive,Permissions, PersonID);
            }
            return null;
        }
        public bool Save(Nullable<int> EmployeeIDResponsible)
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee(EmployeeIDResponsible))
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateEmployee(EmployeeIDResponsible);

            }

            return false;
        }
        public bool ChangePassword(Nullable<int> EmployeeID,string NewPassword)
        {
            NewPassword = clsEncryptionAndDecrypyion.Encrypt(NewPassword);
           return clsEmployeeData.ChangePassword(EmployeeID, NewPassword);
        }
        public static DataTable GetAllEmployees() {
            return clsEmployeeData.GetAllEmployees();
        }
        public static bool IsEmployeeExistByUserName(string UserName)
        {
            return clsEmployeeData.IsEmployeeExistByUserName(UserName);
        }
        public static bool IsEmployeeExistByPersonID(Nullable<int> PersonID)
        {
            return clsEmployeeData.IsEmployeeExistByPersonID(PersonID);
        }
        public static bool IsEmployeeExistByEmployeeID(int EmployeeID)
        {
            return clsEmployeeData.IsEmployeeExistByEmployeeID(EmployeeID);
        }
        public static bool DeleteEmployee(int EmployeeID, Nullable<int> EmployeeIDResponsible)
        {
            return clsEmployeeData.DeleteEmployee(EmployeeID,EmployeeIDResponsible);
        }
        public static bool ActiveEmployee(int EmployeeID, Nullable<int> EmployeeIDResponsible)
        {
            return clsEmployeeData.ActiveEmployee(EmployeeID, EmployeeIDResponsible);
        }
    }
}
