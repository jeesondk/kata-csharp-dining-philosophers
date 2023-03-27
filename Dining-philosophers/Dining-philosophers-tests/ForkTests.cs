using Dining_philosophers;
using FluentAssertions;

namespace Dining_philosophers_tests;

public class ForkTests:IClassFixture<ForkTestFixture>
{
    private readonly ForkTestFixture _fixture;

    public ForkTests(ForkTestFixture fixture)
    {
        _fixture = fixture;
    }
    
    
    
    [Fact]
    void CanPickUpFork()
    {
        _fixture.Fork.PickUp().Should().Be(true);
    }

    [Fact]
    public void CanBeReleased()
    {
        _fixture.Fork.PickUp();
        var action = () => _fixture.Fork.PutDown();
        action.Should().NotThrow();
    }
}