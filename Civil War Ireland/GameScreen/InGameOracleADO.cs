
using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
   

    class InGameOracleADO : InGameADO
    {
        int playerTroops;

        public int viewTroops()
        {

            Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection(DbConnect.oradb);

            String strSQL = "SELECT * FROM V_PlayerTroops";

            conn.Open();

            Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(strSQL, conn);
            Oracle.ManagedDataAccess.Client.OracleDataReader dr = cmd.ExecuteReader();

            //read the record in dr
            dr.Read();

            if (dr.IsDBNull(0))
                playerTroops = 1;
            else
                playerTroops = Convert.ToInt16(dr.GetValue(0)) + 1;

            conn.Close();


            return playerTroops;

        }

        public void viewGold()
        {
            throw new NotImplementedException();
        }

        public void viewCountysOwned()
        {
            throw new NotImplementedException();
        }

        void InGameADO.viewTroops()
        {
            throw new NotImplementedException();
        }
    }
}
