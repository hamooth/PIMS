using PIMS.DataSet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIMS.Servies
{
    public class UsersUserControl_Services
    {
        Repository _Repo;
        public UsersUserControl_Services()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Table_add_new_user> ListAll()
        {
            return _Repo.GetAll<Table_add_new_user>().ToList();
        }

        public void AddData(string addrole, string addFname, string addLname, string addGender, int addphoneNo, string addEmail, string addNic, string addAddress,
            DateTime addDob, DateTime addJdate, string Uname, string addpsw, byte[] img)
        {
            var mydata = new Table_add_new_user();
            {
                mydata.Role = addrole;
                mydata.Firstname = addFname;
                mydata.Lastname = addLname;
                mydata.Gender = addGender;
                mydata.Phonenumber = addphoneNo;
                mydata.Emailid = addEmail;
                mydata.Nic = addNic;
                mydata.Address = addAddress;
                mydata.Date_of_birth = addDob;
                mydata.Joindate = addJdate;
                mydata.Username = Uname;
                mydata.Password = addpsw;
                mydata.Imege = img;

            };


            _Repo.AddData(mydata);
        }

        public void UpdateData(string addrole, string addFname, string addLname, string addGender, int addphoneNo, 
            string addEmail, string addNic, string addAddress, DateTime addDob, DateTime addJdate, string Uname, string addpsw, Image Upimage)
        {
            var mydata = ListAll().SingleOrDefault(x => x.Username == Uname);

            mydata.Role = addrole;
            mydata.Firstname = addFname;
            mydata.Lastname = addLname;
            mydata.Gender = addGender;
            mydata.Phonenumber = addphoneNo;
            mydata.Emailid = addEmail;
            mydata.Nic = addNic;
            mydata.Address = addAddress;
            mydata.Date_of_birth = addDob;
            mydata.Joindate = addJdate;
            mydata.Username = Uname;
            mydata.Password = addpsw;
           // mydata.Imege = Upimage;

            _Repo.UpdateData(mydata);


        }

        public void ResetData(string Id)
        {
            var Qu = _Repo.GetAll<Table_add_new_user>().Where(x => x.Username == Id).ToList();

            foreach (var item in Qu)
            {
               _Repo.DeleteData(item.Username);
            }
        }








    } 
}



