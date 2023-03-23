namespace FactoryMethod.Product
{
    public abstract class Tela
    {
        protected string BackgroundColor { get; }
        private readonly string MessageText;

        public Tela(string backgroundColor, string messageText)
        {
            BackgroundColor = backgroundColor;
            MessageText = messageText;
        }

        public string GetMessageText()
        {
            return MessageText;
        }
    }
}
