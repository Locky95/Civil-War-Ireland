using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civil_War_Ireland
{
    public partial class frmStart_Game : Form
    {
        PlayerOracleADO factory = new PlayerOracleADO();
        PlayerADO a = new PlayerOracleADO();
        public frmStart_Game()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

            a.createPlayer(a.getNextPlayerId(),a.getUserId(),"Y");
        }
    }
}
