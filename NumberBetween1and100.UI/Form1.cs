using System;
using System.Windows.Forms;
using NumberBetween1and100;

namespace NumberBetween1and100.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int count = DivisibleByThreeCounter.Count();
            labelResult.Text = $"Count: {count}";
        }
    }
}
