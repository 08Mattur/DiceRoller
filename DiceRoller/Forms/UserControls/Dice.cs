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
        private Engine.Objects.Die Die { get; set; }

        public Dice(Engine.Managers.DiceManager manager, int diceSides)
        {
            InitializeComponent();
            Die = new Engine.Objects.Die(manager, diceSides);
            Die.Roll();
            Display();
        }

        public void Display()
        {
            lblDice.Text = Die.DisplayString();
        }

        private void lblDice_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
