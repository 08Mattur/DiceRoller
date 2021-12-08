namespace DiceRoller.Engine.Interfaces
{
    public interface IDiceManager
    {
        void RegisterDice(IDie d);
        void UnregisterDice(IDie d);
        void NotifyDice();
    }
}
