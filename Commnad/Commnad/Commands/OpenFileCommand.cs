using Commnad.Interface;

namespace Commnad.Commands
{
    // As classes Command concretas implementam a interface ICommand e invocam os métodos do Receiver
    public class OpenFileCommand : ICommand
    {
        private Receiver _receiver;

        public OpenFileCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.OpenFile();
        }
    }
}
