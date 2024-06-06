using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private Int32 mUserId;
        private string mUserName;
        private string mUserPassword;  
        private string mUserDepartment;
        public int UserId 
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }
        public string UserName 
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string UserPassword 
        {
            get
            {
                return mUserPassword;
            }
            set
            {
                mUserPassword = value;
            }
        }
        public string UserDepartment 
        {
            get
            {
                return mUserDepartment;
            }
            set
            {
                mUserDepartment = value;
            }
        }

        public bool FindUser(string userName, string userPassword)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", userPassword);
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            if(DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mUserPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mUserDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}