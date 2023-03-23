using ClassAdapter.Adapters;

Console.WriteLine("Informe o arquivo de mídia que deseja executar: ");
string file = Console.ReadLine();

var file_parte = file.Split("."); //file://musica.mp3

IPlayer player;

switch (file_parte[1])
{
    case "mp3":
        {
            player = new Mp3PlayerAdapter();
            player.Play(file);
            break;
        }
    case "mp4":
        {
            player = new Mp4PlayerAdapter();
            player.Play(file);
            break;
        }
    default:
        {
            Console.WriteLine("Arquivo de mídia incompatível!");
            break;
        }

}
