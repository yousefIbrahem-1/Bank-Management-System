using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business
{
   public class clsClient
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public Nullable<int> ClientID { get; set; }
        public decimal AccountBalance { get; set; }
        public int AccountID { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> PersonID { get; set; }


        public clsClient()
        {
            ClientID = null;
            AccountBalance = 0;
            AccountID = 0;
            IsActive = true;
            PersonID = null;
            Mode = enMode.AddNew;
        }
        private clsClient(Nullable<int> clientID, decimal accountBalance, int accountID, bool isActive, Nullable<int> personID)
        {
            ClientID= clientID;
            AccountBalance= accountBalance;
            AccountID= accountID;
            IsActive = isActive;
            PersonID = personID;
            Mode= enMode.Update;
        }

        public bool AddNewClient(Nullable<int> EmployeeIDResponsible)
        {
            this.ClientID= clsClientData.AddNewClient(this.AccountBalance, this.AccountID, this.PersonID, EmployeeIDResponsible);
            return this.ClientID != null;
        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();
        }
        public static DataTable GetAllAccounts()
        {
            return clsClientData.GetAllAccounts();
        }
        public static bool IsClientExistByPersonID(Nullable<int> PersonID)
        {
            return clsClientData.IsClientExistByPersonID((Nullable<int>)PersonID);
        }

       

    }
}
