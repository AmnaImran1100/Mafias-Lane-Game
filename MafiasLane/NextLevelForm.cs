using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MafiasLane
{
    public partial class NextLevelForm : Form
    {
        public NextLevelForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Level2 form = new Level2();
            form.Show();
        }
    }
}
