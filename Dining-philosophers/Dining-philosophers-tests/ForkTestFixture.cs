using Dining_philosophers;

namespace Dining_philosophers_tests;

public class ForkTestFixture
{

    private Fork _fork;
    public ForkTestFixture()
    {
        _fork = new();
    }
    
    public Fork Fork => _fork;
    
    
}