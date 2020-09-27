using System;

namespace Bridge
{
    public class SmartTv
    {
        public ICanal CanalAtual { get; set; }
        
        public void ExibeCanalSintonizado()
        {
            if(CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Canal());
            }
            else
            {
                Console.WriteLine("selecione um canal");
            }
        }

        public void PlayTv()
        {
            if(CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Status());
            }
            else
            {
                Console.WriteLine("selecione um canal para assistir algo");
            }
        }
    }
}