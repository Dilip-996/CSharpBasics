using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookNameDisplay;

namespace FacebookNameDisplay.UI
{
    public partial class Form1 : Form
    {
        private readonly List<string> _names = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                string name = textBoxName.Text.Trim();
                _names.Add(name);
                listBoxNames.Items.Add(name);
                textBoxName.Clear();
            }
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            string message = LikeMessageFormatter.Format(_names);
            labelMessage.Text = message;
        }
    }
}

