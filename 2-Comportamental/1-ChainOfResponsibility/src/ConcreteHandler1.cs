using System;

namespace ChainResponsibility
{
    public class ConcreteHander1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if(request >= 0 && request < 10)
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