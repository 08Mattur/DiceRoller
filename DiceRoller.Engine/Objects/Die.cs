using DiceRoller.Engine.Interfaces;

namespace DiceRoller.Engine.Objects
{
    public class Die : IDie, IDisplay
    {
        private readonly int _sides;
        private int _result;
        private IDiceManager _manager;


        public Die(IDiceManager manager, int sides)
        {
            _manager = manager;
            _sides = sides;
            Roll();
            _manager.RegisterDice(this);
        }

        public void UnRegister()
        {
            _manager.UnregisterDice(this);
        }

        public string DisplayString()
        {
            return _result.ToString();
        }

        public int DisplayInt()
        {
            return _result;
        }

        public void Roll()
        {
            var rnd = new Random();
            _result=  rnd.Next(1, _sides + 1);
        }
    }
}
