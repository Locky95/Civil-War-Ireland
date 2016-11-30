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
        String inGamePlayerStatus;

        public Player()
        {

        }
        public Player(int playerID,int userID,String inGamePlayerStatus)
        {
            setPlayerID(playerID);
            setUserID(userID);
            setInGamePlayerStatus(inGamePlayerStatus);
        }

        void setInGamePlayerStatus(String inGamePlayerStatus)
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
        String getInGamePlayerStatus()
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
 
    }
}
