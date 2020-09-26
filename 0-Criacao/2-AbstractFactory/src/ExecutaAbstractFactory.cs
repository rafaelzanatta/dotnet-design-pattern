namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro MontarCarro(string tipo)
        {
            CarroFactory cf = null;

            switch(tipo)
            {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "popular":
                    cf = new CarroPopularFactory();
                    break;
            }

            Carro carro = new Carro();
            carro.Roda = cf.MontarRoda();
            carro.Som  = cf.MontarSom();

            return carro;
        }
    }
}