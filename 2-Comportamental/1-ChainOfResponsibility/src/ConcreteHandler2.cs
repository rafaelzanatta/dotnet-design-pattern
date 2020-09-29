using System;

namespace ChainResponsibility
{
    public class ConcreteHander2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if(request >= 10 && request < 20)
            {
                Console.WriteLine($"{GetType().Name} handled request {request}");
            }
            else if(Sucessor != null)
            {
                Sucessor.HandlerRequest(request);
            }
        }
        
    }
}