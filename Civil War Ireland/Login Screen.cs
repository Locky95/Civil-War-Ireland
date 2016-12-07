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
    public partial class Login_Screen : Form
    {
        PlayerOracleADO factory = new PlayerOracleADO();
        PlayerADO a = new PlayerOracleADO();
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

            a.createPlayer(0,0,'Y');
        }
    }
}
