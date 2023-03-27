using Dining_philosophers;
using FluentAssertions;

namespace Dining_philosophers_tests;

public class ForkTests:IClassFixture<ForkTestFixture>
{
    private readonly ForkTestFixture _fixture;


    
    [Fact]
    void CanPickUpFork()
    {
        var fork = new Fork();

        var t1 = Task.Factory.StartNew(() => fork.PickUp());
        t1.Result.Should().BeTrue();
        Task.Factory.StartNew(() => fork.PutDown());
    }

    [Fact]
    public void CanBeReleased()
    {
        var fork = new Fork();

        var t1 = Task.Factory.StartNew(() => fork.PickUp());
        var t2 = Task.Factory.StartNew(() => fork.PutDown());
        t2.Exception.Should().BeNull();
    }

    [Fact]
    void CanOnlyBePickedUpOnce()
    {
        var fork = new Fork();
        
        var t1 = Task.Factory.StartNew(() => fork.PickUp());
        var t2 = Task.Factory.StartNew(() => fork.PickUp());
        
        t1.Result.Should().BeTrue();
        t2.Result.Should().BeFalse();
    }
}