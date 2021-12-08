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
        private Engine.Managers.DiceManager _diceManager = new Engine.Managers.DiceManager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateNewDice(int sides)
        {
            var uc = new UserControls.Dice(_diceManager, sides, this);
            flpDice.Controls.Add(uc);
            Display();
        }       

        public void Remove(UserControls.Dice toRemove)
        {
            flpDice.Controls.Remove(toRemove);
            Display();
        }

        private void Display()
        {
            foreach (UserControls.Dice ucD in flpDice.Controls)
            {
                ucD.Display();
            }
            lblResult.Text = _diceManager.DisplayInt().ToString();
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
            _diceManager.Roll();
            Display();
        }
    }
}
