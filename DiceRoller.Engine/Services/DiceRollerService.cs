namespace DiceRoller.Engine.Services
{
    public class DiceRollerService
    {
        private readonly List<int> _diceToRoll;
        private readonly List<int> _eachRoll;
        private readonly int _totalResult;
        public DiceRollerService(List<int> diceToRoll)
        {
            _eachRoll = new List<int>();
            _totalResult = 0;
            _diceToRoll = diceToRoll;

            foreach (var roll in _diceToRoll)
            {
                var dice = new Objects.Dice(roll);
                var result = dice.RollDice();
                _eachRoll.Add(result);
                _totalResult += result;
            }
        }

        public List<int> GetSizes { get { return _diceToRoll; } }
        public List<int> GetRolls { get { return _eachRoll; } }
        public int TotalResult { get { return _totalResult; } }
    }
}
