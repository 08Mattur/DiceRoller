namespace DiceRoller.Engine
{
    public class Dice
    {
        private readonly int _sides;
        public Dice(int sides)
        {
            _sides = sides;
            Roll();
        }

        public int Result { get; set; }

        public void Roll()
        {
            var rnd = new Random();
            Result = rnd.Next(1, _sides);
        }
    }
}
