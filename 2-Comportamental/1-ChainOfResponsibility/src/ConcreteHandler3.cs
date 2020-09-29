using System;

namespace ChainResponsibility
{
    public class ConcreteHander3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if(request >= 20 && request < 30)
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