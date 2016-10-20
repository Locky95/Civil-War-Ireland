using System;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    class User
    {
        int userID;
        String userName;
        String userPassword;
        String userEmail;

        public User()
        {
        }
        public User(int userID,String userName,String userPassword, String userEmail)
        {
            setUserId(userID);
            setUserName(userName);
            setUserPassword(userPassword);
            setUserEmail(userEmail);
        }

        void setUserEmail(string userEmail)
        {
            this.userEmail = userEmail;
        }

        void setUserPassword(string userPassword)
        {
            this.userPassword = userPassword;
        }

        void setUserName(string userName)
        {
            this.userName = userName;
        }

        void setUserId(int userID)
        {
            this.userID = userID;
        }
        String getUserEmail()
        {
            return userEmail;
        }
        String getUserPassword()
        {
            return userPassword;
        }
        String getUserName()
        {
            return userName;
        }
        int getUserID()
        {
            return userID;
        }
        //public int getNextUserId()
        //{
        //    int NextUserId;
        //    OracleConnection conn = new OracleConnection(DbConnect.oradb);


        //    //Define SQL query
        //    String strSQL = "SELECT MAX(UserId) FROM Users";

        //    //Define Oracle command
        //    OracleCommand cmd = new OracleCommand(strSQL, conn);

        //    //Open DB connection
        //    conn.Open();

        //    //execute
        //    OracleDataReader dr = cmd.ExecuteReader();

        //    //read the record in dr
        //    dr.Read();

        //    if (dr.IsDBNull(0))
        //        NextUserId = 1;
        //    else
        //        NextUserId = Convert.ToInt16(dr.GetValue(0)) + 1;

        //    conn.Close();
        //    return NextUserId;
        //}
    }
}
