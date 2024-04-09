using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubTester
{
    public partial class Form1 : Form
    {
        string playerName;
        string dragonName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add safety check to ensure input provided by user
        
            playerName = txtPlayerName.Text;
            dragonName = txtDragonName.Text;

            rtbLog.Text = "Player Name: " + playerName +
                            "\nDragon Name: " + dragonName;
        }
    }
}
