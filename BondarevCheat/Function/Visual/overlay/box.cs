using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BondarevCheat.Function.Visual.overlay
{
    public partial class box : Form
    {
        public box()
        {
            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;

        }
    }
}
