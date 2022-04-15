using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealOrNoDeal
{
    public partial class frmGameState : Form
    {
        public frmGameState()
        {
            InitializeComponent();
        }

        private void frmGameState_Load(object sender, EventArgs e)
        {
            foreach (Button button in grpCaseButtons.Controls)
            {
                button.Click += new EventHandler(CaseButtonClick);
            }
        }

        private void CaseButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("It Works");
        }
    }
}
