
using System;
using System.Collections.Generic;
using System.Data.OracleClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    class PlayerOracleADO : PlayerADO
    {
        private OracleConnection conn = new OracleConnection(DbConnect.oradb);

        void PlayerADO.createPlayer(int id)
        {
            throw new NotImplementedException();
        }

        int PlayerADO.getNextPlayerId()
        {
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

       

        void PlayerADO.setPlayerInGameStatus(string inGameStatus)
        {
            throw new NotImplementedException();
        }

       
    }
}
