namespace SingletonPattern;

sealed public class PlayService
{
    private static PlayService _playService = null!;
    private static readonly object _lock = new object();

    /// <summary>
    /// 
    /// </summary>
    private PlayService() {}

    public static PlayService Instance()
    {
        if (_playService == null)
        {
            lock (_lock)
            {
                _playService = new PlayService();
            }
        }
        return _playService;
    }
}
