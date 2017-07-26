using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    

    public partial class Robot : Form
    {

        robot myRobot = new robot();
        public Robot()
        {
            InitializeComponent();
            
        }

        

        private void Robot_Load(object sender, EventArgs e)
        {
            lblRobot.Text = "é"; // form property set to wingdings for arrow, then using character equiv for hacky avatar generation. It worked what can I say.
            myRobot.Draw(pnlRobot);
            lblPosition.Text = myRobot.location.ToString();

        }

        private void btnMoveOne_Click(object sender, EventArgs e)
        {
            myRobot.Move(1);
            myRobot.Draw(pnlRobot);
            lblPosition.Text = myRobot.location.ToString();

        }

        private void btnMoveTen_Click(object sender, EventArgs e)
        {
            myRobot.Move(10);
            myRobot.Draw(pnlRobot);
            lblPosition.Text = myRobot.location.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myRobot.direction = Direction.North;
            lblRobot.Text = "é";
        }

        private void btnGoEast_Click(object sender, EventArgs e)
        {
            myRobot.direction = Direction.East;
            lblRobot.Text = "è";
        }

        private void btnGoSouth_Click(object sender, EventArgs e)
        {
            myRobot.direction = Direction.South;
            lblRobot.Text = "ê";
        }

        private void btnGoWest_Click(object sender, EventArgs e)
        {
            myRobot.direction = Direction.West;
            lblRobot.Text = "ç";
        }

        private void pnlRobot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
