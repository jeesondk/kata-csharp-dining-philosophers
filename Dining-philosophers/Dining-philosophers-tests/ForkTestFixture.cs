using Dining_philosophers;
using Microsoft.VisualBasic;

namespace Dining_philosophers_tests;

public class ForkTestFixture
{

    private Fork _fork;
    public ForkTestFixture()
    {
        _fork = new();
    }
    
    public Fork Fork => _fork;

    public void ForkThreadProc()
    {
        for (var i = 0; i < 2; i++)
        {
            _fork.PickUp();
        }
    }
    
}