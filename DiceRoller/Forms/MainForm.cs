using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateNewDice(int sides)
        {
            var uc = new UserControls.Dice(sides);
            flpDice.Controls.Add(uc);
            CalculateResult();
        }

        private void CalculateResult()
        {
            var result = 0;
            foreach (UserControls.Dice uc in flpDice.Controls)
            {
                result += uc.DiceResult;
            }

            lblResult.Text = result.ToString();
        }

        private void btnAddD4_Click(object sender, EventArgs e)
        {
            CreateNewDice(4);
        }

        private void btnAddD6_Click(object sender, EventArgs e)
        {
            CreateNewDice(6);
        }

        private void btnAddD8_Click(object sender, EventArgs e)
        {
            CreateNewDice(8);
        }

        private void btnAddD10_Click(object sender, EventArgs e)
        {
            CreateNewDice(10);
        }

        private void btnAddD12_Click(object sender, EventArgs e)
        {
            CreateNewDice(12);
        }

        private void btnAddD20_Click(object sender, EventArgs e)
        {
            CreateNewDice(20);
        }

        private void btnAddD100_Click(object sender, EventArgs e)
        {
            CreateNewDice(100);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            foreach (UserControls.Dice uc in flpDice.Controls)
            {
                uc.RollDice();
            }
            CalculateResult();
        }
    }
}
