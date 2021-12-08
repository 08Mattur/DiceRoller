using DiceRoller.Engine.Interfaces;
using System.Collections;

namespace DiceRoller.Engine.Managers
{
    public class DiceManager : IDiceManager
    {
        private ArrayList observers;

        public DiceManager()
        {
            observers = new ArrayList();
        }

        public void RegisterDice(IDie d)
        {
            observers.Add(d);
            GetResults();
        }

        public void UnregisterDice(IDie d)
        {
            observers.Remove(d);
            GetResults();
        }

        public void NotifyDice()
        {
            foreach (var d in observers)
            {
                IDie dice = (IDie)d;
                dice.Roll();
            }
        }

        public int ResultInt{ get; set; }
        public string ResultString { get; set; }
            
        public void Roll()
        {
            NotifyDice();    
            GetResults();
        }

        public void GetResults()
        {
            var result = "";
            var dlim = "";

            var resultInt = 0;
            foreach (var d in observers)
            {
                IDisplay display = (IDisplay)d;
                resultInt += display.DisplayInt();
                result += dlim + display.DisplayString();
                dlim = " + ";
            }

            ResultInt = resultInt;
            ResultString = $"({result})";
        }
    }
}
