using System;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(PersonagemList personagem)
        {
            switch (personagem)
            {
                case PersonagemList.LiuKang: return new LiuKang();
                case PersonagemList.Scorpion: return new Scorpion();
                case PersonagemList.SubZero: return new SubZero();
                default: throw new NotImplementedException();
            }
        }
    }
}