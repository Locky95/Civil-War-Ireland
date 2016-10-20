using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    class CountiesOwned
    {
        int countyID;
        int playerID;

        public CountiesOwned()
        {

        }
        public CountiesOwned(int countyID, int playerID)
        {
            setCountyID(countyID);
            setPlayerID(playerID);
        }
        void setPlayerID(int playerID)
        {
            this.playerID = playerID;
        }
        void setCountyID(int countyID)
        {
            this.countyID = countyID;
        }
        int getCountyID()
        {
            return countyID;
        }
        int getPlayerID()
        {
            return playerID;
        }
        /*void setGoldCap()
        {
            the code used to set the upper limit of the gold the player can have
            should be placed in here.the upper limit is decided based on how many counties the player owns.
        }*/

    }
}
