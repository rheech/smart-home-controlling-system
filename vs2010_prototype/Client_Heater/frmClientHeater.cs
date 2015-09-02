using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserInterface;

namespace Client_Heater
{
    public partial class frmHeaterClient : AgentUI
    {
        public frmHeaterClient()
        {
            DeviceName = "Heater";
            InitializeComponent();
        }

        private void btnReleaseHeat_Click(object sender, EventArgs e)
        {
            sendCommand("Release Heat");
        }
    }
}
