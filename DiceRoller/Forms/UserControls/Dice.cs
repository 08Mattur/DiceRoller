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
            Die = new Engine.Dice(diceSides);
            Roll();
        }

        private Engine.Dice Die { get; set; }

        public void Roll()
        {
            Die.Roll();
            lblDice.Text = Die.Result.ToString();
        }

        public int Result()
        {
            return Die.Result;
        }
    }
}
