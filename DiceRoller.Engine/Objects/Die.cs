namespace DiceRoller.Engine.Objects
{
    public class Die
    {
        private readonly int _sides;

        public Die(int sides)
        {
            _sides = sides;
        }

        public int RollDice()
        {
            var rnd = new Random();
            return rnd.Next(1, _sides+1);
        }
    }
}
