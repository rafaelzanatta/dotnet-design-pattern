namespace ChainResponsibility
{
    public abstract class Handler
    {
        protected Handler Sucessor;

        public void SetSucessor(Handler sucessor)
        {
            Sucessor = sucessor;
        }

        public abstract void HandlerRequest(int request);
    }
}