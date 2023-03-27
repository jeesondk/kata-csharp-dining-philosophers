namespace Dining_philosophers;

public class Fork
{
    private readonly Mutex _mutex = new(); 
    public bool PickUp()
    {
        return _mutex.WaitOne(100);
    }

    public void PutDown()
    {
        _mutex.ReleaseMutex();
    }

    ~Fork()
    {
        _mutex.Dispose();
    }
}