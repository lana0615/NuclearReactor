using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Media;
namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void StartReactor_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            //change the message in the output label
            outputLabel.Text = "Meltdown Imminent";

            //change the colour of the state labels
            reactor1statelabel.BackColor = Color.Red;
            reactor2statelabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor1statelabel.BackColor = Color.White;
            reactor2statelabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            reactor1statelabel.BackColor = Color.Red;
            reactor2statelabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);



        }
    }

}