using ClassAdapter.Libs;

namespace ClassAdapter.Adapters
{
    public class Mp4PlayerAdapter : IPlayer
    {
        public void Play(string file)
        {
            Mp4Player.Executar(file);
        }
    }
}
