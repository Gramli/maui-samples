namespace RockPaperScissors.Patterns.Mediator
{
    public interface IParticipant
    {
        void Notify(IMessageObject message);
    }
}
