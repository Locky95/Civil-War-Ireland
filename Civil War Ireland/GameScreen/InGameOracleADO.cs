
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
//using Oracle.ManagedDataAccess.client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
   

    class InGameOracleADO : InGameADO
    {


        public void viewTroops()
        {
            OracleConnection conn = new OracleConnection(DbConnect.oradb);

            String strSQL = "SELECT inGameStatus FROM Player";

            conn.Open();
            
            OracleCommand cmd = new OracleCommand("USER_ID",conn);
            

        }

        public void viewGold()
        {
            throw new NotImplementedException();
        }

        public void viewCountysOwned()
        {
            throw new NotImplementedException();
        }
    }
}
