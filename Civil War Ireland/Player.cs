using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    class Player
    {
        int playerID;
        int userID;
        int inGamePlayerStatus;

        public Player()
        {

        }
        public Player(int playerID,int userID,int inGamePlayerStatus)
        {
            setPlayerID(playerID);
            setUserID(userID);
            setInGamePlayerStatus(inGamePlayerStatus);
        }

        void setInGamePlayerStatus(int inGamePlayerStatus)
        {
            this.inGamePlayerStatus = inGamePlayerStatus;
        }

        void setUserID(int userID)
        {
            this.userID = userID;
        }

        void setPlayerID(int playerID)
        {
            this.playerID = playerID;
        }
        int getInGamePlayerStatus()
        {
            return inGamePlayerStatus;
        }
        int getUserID()
        {
            return userID;
        }
        public int getPlayerID()
        {
            return playerID;
        }
        //public int getNextPlayerId()
        //{
        //    int NextPlayerId;
        //    OracleConnection conn = new OracleConnection(DbConnect.oradb);


        //    //Define SQL query
        //    String strSQL = "SELECT MAX(playerID) FROM Players";

        //    //Define Oracle command
        //    OracleCommand cmd = new OracleCommand(strSQL, conn);

        //    //Open DB connection
        //    conn.Open();

        //    //execute
        //    OracleDataReader dr = cmd.ExecuteReader();

        //    //read the record in dr
        //    dr.Read();

        //    if (dr.IsDBNull(0))
        //        NextPlayerId = 1;
        //    else
        //        NextPlayerId = Convert.ToInt16(dr.GetValue(0)) + 1;

        //    conn.Close();
        //    return NextPlayerId;
        //}
    }
}
