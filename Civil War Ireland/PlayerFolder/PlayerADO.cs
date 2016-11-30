using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    interface PlayerADO
    {
       void createPlayer(int id,int userID,String inGamePlayerStatus);
        int getNextPlayerId();
        int getUserId();
        String setPlayerInGameStatus(int playerID);

    }
}
