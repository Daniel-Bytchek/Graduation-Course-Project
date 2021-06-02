using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1._1
{
    public abstract class User : IUser
    {
        String fName;
        String sName;
        String tName;
        String Phone;
        String Mail;
        String Login;
        String Password;
        int id;
        Boolean admin;

        public string getFName()
        {
            return this.fName;
        }

        public string getLogin()
        {
            return this.Login;
        }

        public string getMail()
        {
            return this.Mail;
        }

        public string getPassword()
        {
            return this.Password;
        }

        public string getPhone()
        {
            return this.Phone;
        }

        public string getSName()
        {
            return this.sName;
        }

        public string getTName()
        {
            return this.tName;
        }

        public void setFName(string fName)
        {
            this.fName = fName;
        }

        public void setLogin(string Login)
        {
            this.Login = Login;
        }

        public void setMail(string Mail)
        {
            this.Mail = Mail;
        }

        public void setPassword(string Password)
        {
            this.Password = Password;
        }

        public void setPhone(string Phone)
        {
            this.Phone = Phone;
        }

        public void setSName(string sName)
        {
            this.sName = sName;
        }

        public void setTName(string tName)
        {
            this.tName = tName;
        }

        public int getID()
        {
            return this.id;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public Boolean getAdmin()
        {
            return this.admin;
        }

        public void setAdmin(Boolean admin)
        {
            this.admin = admin;
        }
    }
}
