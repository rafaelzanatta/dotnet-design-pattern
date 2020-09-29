namespace Mediator
{
    public abstract class Colega
    {
        protected Mediator mediator;

        public Colega(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}