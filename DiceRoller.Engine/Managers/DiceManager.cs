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
        }

        public void UnregisterDice(IDie d)
        {
            int index = observers.IndexOf(d);
            if (index != -1)
            {
                observers[index] = null;
            }
        }

        public void NotifyDice()
        {
            foreach (var d in observers)
            {
                IDie dice = (IDie)d;
                dice.Roll();
            }
        }

        public int DisplayInt()
        {
            var result = 0;
            foreach (var d in observers)
            {
                IDisplay display = (IDisplay)d;
                result += display.DisplayInt();
            }
            return result;
        }

        public void Roll()
        {
            NotifyDice();
        }
    }
}
