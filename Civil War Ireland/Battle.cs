using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    class Battle
    {
        //void sendTroopsToBattle()
        //{
        //    the code to decide how many troops to send to battle should be placed in here

        //}
        public void neutralCountyBattle()
        {
            //the value for the attacking players id needs to be generated
            //the players id needs to be assigned
            //the players troops must be assigned correctly, corresponding to the players id

            Player player1 = new Player(001, 001, 1);
            int id = player1.getPlayerID();
            Troops p1 = new Troops();
            //p1.setTroops(sendTroopsToBattle);
            //p1.setPlayerID(id);

            int enemyTroops =( p1.getPlayerTroops()/3 )+ 1;

            //BattleResults(p1.getTroops, enemyTroops);
        }

        public void playerVsPlayer()
        {
            //the value for the attacking players id needs to be generated
            //the players id needs to be assigned
            //the players troops must be assigned correctly, corresponding to the players id

            Player player1 = new Player(001, 001, 1);
            int id = player1.getPlayerID();
            Troops p1 = new Troops();
            //p1.setTroops(sendTroopsToBattle);
            //p1.setPlayerID(id);


            Player player2 = new Player(001, 001, 1);
            int id2 = player2.getPlayerID();
            Troops p2 = new Troops();
            //p1.setTroops(sendTroopsToBattle);
            //p1.setPlayerID(id2);

            //BattleResults(p1.getTroops(),p2.getTroops());

        }

        public void BattleResults(int attackerTroops, int defenderTroops)
        {
            Random rnd = new Random();

            int attacker = rnd.Next(attackerTroops, attackerTroops + 20);
            int defender = rnd.Next(defenderTroops, defenderTroops + 20);

            // if statement comparing which number is bigger.bigger number wins
            // winner gets the county etc etc
        }


    }
}
