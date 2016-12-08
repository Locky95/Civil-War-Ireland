
using System;
using System.Collections.Generic;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Civil_War_Ireland
{
   
    class PlayerOracleADO : PlayerADO
    {
        
        public int playerID;
        public int userID;
        String inGameStatus;
        PlayerADO a;

        public PlayerOracleADO()
        {

        }

       

        void PlayerADO.createPlayer(int id,int userID,String inGamePlayerStatus)
        {
            //Create database connection string
            OracleConnection conn = new OracleConnection(DbConnect.oradb);

            String strSQL = "INSERT INTO PLAYER VALUES(" + id + ",'PLayer'," + userID + ",'" + inGamePlayerStatus + "',1,3)";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Open DB connection
            conn.Open();

            //execute
            cmd.ExecuteNonQuery();

            //Close DB connection
            conn.Close();

        }

        int PlayerADO.getNextPlayerId()
        {
        OracleConnection conn = new OracleConnection(DbConnect.oradb);
        int NextPlayerId;

            //Define SQL query
            String strSQL = "SELECT MAX(PlayerID) FROM Player";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Open DB connection
            conn.Open();

            //execute
            OracleDataReader dr = cmd.ExecuteReader();

            //read the record in dr
            dr.Read();

            if (dr.IsDBNull(0))
                NextPlayerId = 1;
            else
                NextPlayerId = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();
            return NextPlayerId;
            
        }


        int PlayerADO.getUserId()
        {
            OracleConnection conn = new OracleConnection(DbConnect.oradb);
            int nextUserID;

            //Define SQL query
            String strSQL = "User_ID";
            
            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //Open DB connection
            conn.Open();

            //execute
            OracleDataReader dr = cmd.ExecuteReader();

            //read the record in dr
            dr.Read();

            if (dr.IsDBNull(0))
                nextUserID = 1;
            else
                nextUserID = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();
            return nextUserID;
        }

       

        String PlayerADO.setPlayerInGameStatus(int playerID)
        {
        OracleConnection conn = new OracleConnection(DbConnect.oradb);
        String inGame;

            //Define SQL query
            String strSQL = "SELECT inGameStatus FROM Player";
            String strSQL2 = "UPDATE Player SET inGameStatus = 'Y' WHERE playerID = " + playerID +");";
            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            
            //Open DB connection
            conn.Open();

            //execute
            OracleDataReader dr = cmd.ExecuteReader();

            //read the record in dr
            dr.Read();

            if (dr.IsDBNull(0))
                inGame = "Y";
            else
                inGame = "N";

            OracleCommand cmd2 = new OracleCommand(strSQL2, conn);

            OracleDataReader dr2 = cmd2.ExecuteReader();

            conn.Close();

            return inGame;
        }

       
    }
}
