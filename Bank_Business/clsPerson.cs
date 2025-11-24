using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Bank_DataAccess;

namespace Bank_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public Nullable<int> PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public string HomePhone { set; get; }
        public string Phone { set; get; }
        public DateTime BirthOfDate { set; get; }
        public short Age { set; get; }
        public short Gender { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPerson()

        {
            this.PersonID = null;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.HomePhone = "";
            this.Phone = "";
            this.BirthOfDate = DateTime.Now;
            this.Age = 0;
            this.Gender = 1;
            this.Address = "";
            this.Email = "";
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }
        private clsPerson(Nullable<int> PersonID,  string FirstName,  string SecondName, string ThirdName,  string LastName
            ,  string HomePhone,  string Phone,  DateTime BirthOfDate,  short Age,  short Gender, string Address, string Email,  string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.HomePhone = HomePhone;
            this.Phone = Phone;
            this.BirthOfDate = BirthOfDate;
            this.Age = Age;
            this.Gender = Gender;
            this.Address = Address;
            this.Email = Email;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }
        public static clsPerson Find(Nullable<int> PersonID)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",HomePhone="",Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime BirthOfDate = DateTime.Now;
            short Gender = 0,Age=0;

            bool IsFound = clsPersonData.GetPersonInfoByID
                                 (
                                    PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName
                                    , ref HomePhone, ref Phone, ref BirthOfDate, ref Age, ref Gender, ref Address, ref Email, ref ImagePath
                                 );
            if (IsFound)
                //we return new object of that person with the right data
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, HomePhone,
                          Phone, BirthOfDate, Age,Gender, Address, Email, ImagePath);
            else
                return null;
        }

        private bool _AddNewPerson()
        {
            this.PersonID=clsPersonData.AddNewPerson(this.FirstName,this.SecondName,this.ThirdName,this.LastName,this.HomePhone,this.Phone
                ,this.BirthOfDate,this.Age,this.Gender,this.Address,this.Email,this.ImagePath);
            return (this.PersonID != -1);

        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePersonInfoByID(this.PersonID,this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.HomePhone, this.Phone
                , this.BirthOfDate, this.Age, this.Gender, this.Address, this.Email, this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public static DataTable GetPeople()
        {
           return clsPersonData.GetPeople();
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }




    }
}
