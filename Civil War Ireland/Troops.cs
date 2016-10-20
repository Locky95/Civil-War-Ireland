using System;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    class Troops
    {
        int playerTroops;
        int playerID;
        public Troops()
        {
        }
        public Troops(int playerID, int playerTroops)
        {
            setPlayerID(playerID);
            setPlayerTroops(playerTroops);
        }

        void setPlayerTroops(int playerTroops)
        {
            this.playerTroops = playerTroops;
        }

        void setPlayerID(int playerID)
        {
            this.playerID = playerID;
        }
        public int getPlayerTroops()
        {
            return playerTroops;
        }
        public int getPlayerID()
        {
            return playerID;
        }

        /*

        /*void purchasePlayerTroopsUsingPlayerGold()
        {
            the code to purchase player troops using the players gold should be put in here
        }*/

       
        
    }
}
