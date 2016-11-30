using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    public class PlayerFactoryADO 
    {
        int playerID = 0;
        String inGameStatus;
        public PlayerFactoryADO()
        {
            getPlayerADO();
        }
        public void getPlayerADO()
        {
            PlayerADO player = new PlayerOracleADO();
            playerID = player.getNextPlayerId();
            inGameStatus = player.setPlayerInGameStatus(playerID);

           // player.createPlayer(playerID, 000, inGameStatus);
         
        }
    }
}
