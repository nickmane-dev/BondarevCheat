using BondarevCheat.Function.Misc;
using BondarevCheat.Function.Visual;
using BondarevCheat.Utillities;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BondarevCheat
{
    public partial class menu : Form
    {

        

        private static bool formFunctions = false;
        private static bool visual = false;
        private static bool misc = false;
        /// /////////////////////////////////////////////////////////////////////////////
        ///                                                                           ///
        ///                               ///
        
            public menu()
        {
            InitializeComponent();            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void VisualGlowEsp_CheckedChanged(object sender, EventArgs e)
        {
            GlowESP startStream2 = new GlowESP();
            Thread streamGlowESP = new Thread(new ThreadStart(startStream2.runEsp));
            if (visualGlowEsp.Checked == false)
            {
                checkFunction.glowEsp = false;
                streamGlowESP.Abort();


            }
            else if (visualGlowEsp.Checked == true)
            {
                checkFunction.glowEsp = true;
                streamGlowESP.Start();
            }
        }

        private void MiscBunnyHop_CheckedChanged(object sender, EventArgs e)
        {
            BunnyHop startStream1 = new BunnyHop();
            Thread streamBunnyHop = new Thread(new ThreadStart(startStream1.Run));
            if (miscBunnyHop.Checked == false)
            {
                checkFunction.bunnyHop = false;
                streamBunnyHop.Abort();


            }
            else if (miscBunnyHop.Checked == true)
            {
                checkFunction.bunnyHop = true;
                streamBunnyHop.Start();
            }
        }

        private void ButtonVisual_Click(object sender, EventArgs e)
        {
            if (formFunctions == false)
            {
                //miscPanel.Visible = false;
            }
        }

        /*private void ButtonMisc_Click(object sender, EventArgs e)
        {
            if (formFunctions == false)
            {
                visualPanel.Visible = false;
            }
            miscPanel.Visible = true;
        }*/

        private void Menu_Load(object sender, EventArgs e)
        {



        }


        private void VisualPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }





        /*private void VisualBoxEsp_CheckedChanged(object sender, EventArgs e)
        {
            Thread streamEspBox = new Thread(new ThreadStart(Box.run));
            if (visualBoxEsp.Checked == false)
            {
                checkFunction.box = false;
                streamEspBox.Abort();
            } else if (visualBoxEsp.Checked == true)
            {
                checkFunction.box = true;
                streamEspBox.Start();
            }
        }*/


    }
}
