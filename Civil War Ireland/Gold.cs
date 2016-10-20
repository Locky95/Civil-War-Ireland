using System;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Civil_War_Ireland
{
    class Gold
    {
        int playerID;
        int playerGold;

        public Gold()
        {

        }
        public Gold(int playerID,int playerGold)
        {
            setPlayerID(playerID);
            setPlayerGold(playerGold);
        }

        void setPlayerID(int playerID)
        {
            this.playerID = playerID;
        }

        void setPlayerGold(int playerGold)
        {
            this.playerGold = playerGold;
        }
        
        int getPlayerID()
        {
            return playerID;
        }
        int getPlayerGold()
        {
            return playerGold;
        }

       /* void generatePlayerGoldFromCountiesOwned()
        {
        the code to generate the gold from all the countys owned should be placed in here
        }*/
    }
}
