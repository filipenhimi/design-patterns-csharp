// A classe Client cria os objetos necessários e configura a classe Invoker com os comandos
using Commnad.Commands;
using Commnad;

Receiver receiver = new();
OpenFileCommand openFileCommand = new(receiver);
SaveFileCommand saveFileCommand = new(receiver);
CloseFileCommand closeFileCommand = new(receiver);

Invoker invoker = new();
invoker.SetCommand(openFileCommand);
invoker.ExecuteCommand();

invoker.SetCommand(saveFileCommand);
invoker.ExecuteCommand();

invoker.SetCommand(closeFileCommand);
invoker.ExecuteCommand();