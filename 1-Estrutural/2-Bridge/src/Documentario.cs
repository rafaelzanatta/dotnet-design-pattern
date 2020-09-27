namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return "sintonizado no documentarios";
        }

        public string Status()
        {
            return "voce esta assintindo - a origem dos animais";
        }
    }
}