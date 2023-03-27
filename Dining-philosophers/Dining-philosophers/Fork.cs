namespace Dining_philosophers;

public class Fork
{
    private static readonly Mutex _mutex = new(); 
    public bool PickUp()
    {
        return _mutex.WaitOne(60000);
    }

    public object PutDown()
    {
        throw new NotImplementedException();
    }
}