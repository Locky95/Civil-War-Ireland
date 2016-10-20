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
        int getPlayerTroops()
        {
            return playerTroops;
        }
        int getPlayerID()
        {
            return playerID;
        }

        /*void setGoldCap()
        {
            the code used to set the upper limit of the gold the player can have
            should be placed in here.the upper limit is decided based on how many counties the player owns.
        }

        /*void purchasePlayerTroopsUsingPlayerGold()
        {
            the code to purchase player troops using the players gold should be put in here
        }*/

        /*void sendTroopsToBattle()
        {
            the code to decide how many troops to send to battle should be placed in here

        }
        */
    }
}
