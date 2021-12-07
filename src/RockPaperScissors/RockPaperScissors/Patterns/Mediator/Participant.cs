namespace RockPaperScissors.Patterns.Mediator
{
    public abstract class Participant : IParticipant
    {
        protected readonly IMediator _mediator;
        
        protected Participant(IMediator mediator)
        {
            _mediator = mediator;
        }
        public abstract void Notify(IMessageObject message);
    }
}
