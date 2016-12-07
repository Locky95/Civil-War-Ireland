
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
//using Oracle.ManagedDataAccess.client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

       

        void PlayerADO.createPlayer(int id,int userID,char inGamePlayerStatus)
        {
            //Create database connection string
            OracleConnection conn = new OracleConnection(DbConnect.oradb);

            String strSQL = "INSERT INTO Player VALUES (" + id + "," + userID + ",'" + inGamePlayerStatus + "')";

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
            throw new NotImplementedException();
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
