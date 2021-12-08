using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller.Forms.UserControls
{
    public partial class Dice : UserControl
    {
        public Dice(int diceSides)
        {
            InitializeComponent();
            Die = new Engine.Objects.Die(diceSides);
            RollDice();
        }

        private Engine.Objects.Die Die { get; set; }

        public int DiceResult { get; set; }

        public void RollDice()
        {
            DiceResult = Die.RollDice();
            lblDice.Text = DiceResult.ToString();
        }
    }
}
