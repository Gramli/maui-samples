namespace RockPaperScissors.Patterns.Mediator
{
    public interface IMediator
    {
        void Send<T>(IMessageObject sendingObject) where T : IParticipant;
    }
}
