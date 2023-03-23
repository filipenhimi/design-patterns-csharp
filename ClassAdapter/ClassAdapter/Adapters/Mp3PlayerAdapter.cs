using ClassAdapter.Libs;

namespace ClassAdapter.Adapters
{
    public class Mp3PlayerAdapter : IPlayer
    {
        public Mp3PlayerAdapter()
        {
        }

        public void Play(string file)
        {
            Mp3Player mp3Player = new();
            mp3Player.Run(file);
        }
    }
}
