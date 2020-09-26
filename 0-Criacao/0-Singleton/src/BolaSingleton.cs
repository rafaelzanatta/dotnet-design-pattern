using System;

namespace sigleton
{
    public sealed class BolaSingleton
    {
        private static BolaSingleton _intancia = null;

        public static BolaSingleton GetIntancia
        {
            get
            {
                if(_intancia == null)
                {
                    _intancia = new BolaSingleton();
                    Console.WriteLine("bola em jogo");
                }
                
                return _intancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
