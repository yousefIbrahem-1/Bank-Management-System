using Bank.Properties;
using Bank_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        private Nullable<int> _PersonID = null;

        public Nullable<int> PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(Nullable<int> PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }


        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.female_student;
            else
                pbPersonImage.Image = Resources.man__1_;

            //string ImagePath = _Person.ImagePath;
            //if (ImagePath != "")
            //    if (File.Exists(ImagePath))
            //        pbPersonImage.ImageLocation = ImagePath;
            //    else
            //        MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
          //  llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblHomePhone.Text = _Person.HomePhone;
            lblFullName.Text = _Person.FullName;
            lblGender.Text = _Person.Gender == 1 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblBirthOfDate.Text = _Person.BirthOfDate.ToShortDateString();
            lblAddress.Text = _Person.Address;
            _LoadPersonImage();




        }

        public void ResetPersonInfo()
        {
            _PersonID = null;
            lblPersonID.Text = "[????]";
            lblHomePhone.Text = "[????]";
            lblFullName.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblBirthOfDate.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.question;

        }

        

        //private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
        //    frm.ShowDialog();

        //    //refresh
        //    LoadPersonInfo(_PersonID);
        //}

    }
}
