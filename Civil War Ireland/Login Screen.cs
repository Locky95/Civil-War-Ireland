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
        Player player = new Player();
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            player = player.createPlayer();
        }
    }
}
