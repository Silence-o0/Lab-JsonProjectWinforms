using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_JsonProjectWinforms
{
    public partial class WarningForm : Form
    {
        public string errorText;
        public WarningForm()
        {
            InitializeComponent();
        }
        private void WarningForm_Load(object sender, EventArgs e)
        {
            labelErrorMessage.Text = Data.ErrorMessage;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelErrorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
