using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemServer
{
    public partial class ConsoleTextBox : TextBox
    {
        private StringBuilder sbText;

        public ConsoleTextBox()
        {
            sbText = new StringBuilder();
            InitializeComponent();
        }

        public ConsoleTextBox(IContainer container)
        {
            sbText = new StringBuilder();
            container.Add(this);

            InitializeComponent();
        }

        public void printLine(string message)
        {
            sbText.AppendFormat("{0}\r\n", message);
            this.Text = sbText.ToString();
            this.SelectionStart = this.Text.Length;
            this.ScrollToCaret();
        }

        public void clear()
        {
            sbText = new StringBuilder();
            this.Text = "";
        }
    }
}
