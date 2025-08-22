using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace CS_Alphabet_App
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer sapi = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sapi.Speak("B is for banana");
            picFruit.Image = Properties.Resources.banana;
            lblApp.Text = "Banana";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sapi.Speak("H is for honeydaw");
            picFruit.Image = Properties.Resources.honeydaw;
            lblApp.Text = "Honeydaw";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sapi.Speak("O is for orange");
            picFruit.Image = Properties.Resources.orange;
            lblApp.Text = "Orange";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            sapi.Speak("L is for lemon");
            picFruit.Image = Properties.Resources.lemon;
            lblApp.Text = "Lemon";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sapi.Speak("E is for eggplant");
            picFruit.Image = Properties.Resources.eggplant;
            lblApp.Text = "Eggplant";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sapi.Speak("D is for dragon_fruit");
            picFruit.Image = Properties.Resources.dragon_fruit;
            lblApp.Text = "Dragon_fruit";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sapi.Speak("F is for fig");
            picFruit.Image = Properties.Resources.fig;
            lblApp.Text = "Fig";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sapi.Speak("U is for ulgi_fruit");
            picFruit.Image = Properties.Resources.ulgi_fruit;
            lblApp.Text = "Ulgi_fruit";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            sapi.Speak("Confirm if youn want to exit");

            iExit = MessageBox.Show("Confirm if you want to exit", "Alphabet App", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblApp.Text = "";
            picFruit.Image = null;
        }

        private void btnA_Click(object sender, EventArgs e)
        {picFruit.Image = Properties.Resources.apple;
            sapi.Speak("A is for apple");
            
            lblApp.Text = "Apple";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            sapi.Speak("C is for cherry");
            picFruit.Image = Properties.Resources.cherry;
            lblApp.Text = "Cherry";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            sapi.Speak("G is for grape");
            picFruit.Image = Properties.Resources.grape;
            lblApp.Text = "Grape";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            sapi.Speak("I is for iceburg");
            picFruit.Image = Properties.Resources.iceburg;
            lblApp.Text = "Iceburg";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            sapi.Speak("J is for jackfruit");
            picFruit.Image = Properties.Resources.jackfruit;
            lblApp.Text = "Jackfruit";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            sapi.Speak("K is for kiwi");
            picFruit.Image = Properties.Resources.kiwi;
            lblApp.Text = "Kiwi";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            sapi.Speak("M is for mango");
            picFruit.Image = Properties.Resources.mango;
            lblApp.Text = "Mango";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            sapi.Speak("N is for nectarine");
            picFruit.Image = Properties.Resources.nectarine;
            lblApp.Text = "Nectarine";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            sapi.Speak("P is for pear");
            picFruit.Image = Properties.Resources.pear;
            lblApp.Text = "Pear";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            sapi.Speak("Q is for quince");
            picFruit.Image = Properties.Resources.quince;
            lblApp.Text = "Quince";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            sapi.Speak("R is for radish");
            picFruit.Image = Properties.Resources.radish;
            lblApp.Text = "Radish";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            sapi.Speak("S is for strawberry");
            picFruit.Image = Properties.Resources.strawberry;
            lblApp.Text = "Strawberry";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            sapi.Speak("T is for tomato");
            picFruit.Image = Properties.Resources.tomato;
            lblApp.Text = "Tomato";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            sapi.Speak("V is for victoria_plum");
            picFruit.Image = Properties.Resources.victoria_plum;
            lblApp.Text = "Victoria_plum";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            sapi.Speak("W is for watermelon");
            picFruit.Image = Properties.Resources.watermelon;
            lblApp.Text = "Watrmelon";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            sapi.Speak("X is for ximenia");
            picFruit.Image = Properties.Resources.ximenia;
            lblApp.Text = "Ximenia";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            sapi.Speak("Y is for yellow_pepper");
            picFruit.Image = Properties.Resources.yellow_pepper;
            lblApp.Text = "Yellow_pepper";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            sapi.Speak("Z is for zucchini");
            picFruit.Image = Properties.Resources.zucchini;
            lblApp.Text = "Zucchini";
        }
    }
}
