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
        int inGamePlayerStatus;

        public Player()
        {

        }
        public Player(int playerID,int userID,int inGamePlayerStatus)
        {
            setPlayerID(playerID);
            setUserID(userID);
            setInGamePlayerStatus(inGamePlayerStatus);
        }

        void setInGamePlayerStatus(int inGamePlayerStatus)
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
        int getInGamePlayerStatus()
        {
            return inGamePlayerStatus;
        }
        int getUserID()
        {
            return userID;
        }
        int getPlayerID()
        {
            return playerID;
        }
    }
}
