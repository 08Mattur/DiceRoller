namespace DiceRoller.Engine.Objects
{
    internal class Dice
    {
        private readonly int _sides;

        public Dice(int sides)
        {
            _sides = sides;
        }

        internal int RollDice()
        {
            var rnd = new Random();
            return rnd.Next(1, _sides);
        }
    }
}
