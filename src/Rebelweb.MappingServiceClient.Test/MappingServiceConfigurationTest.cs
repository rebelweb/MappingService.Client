namespace Rebelweb.MappingServiceClient.Test;

public class MappingServiceConfigurationTest
{
    [Fact]
    public void TestAuthEnabledTrue()
    {
        MappingServiceConfiguration config = new()
        {
            ApiKey = "abc123"
        };
        Assert.True(config.AuthEnabled);
    }

    [Fact]
    public void TestAuthEnabledFalse()
    {
        MappingServiceConfiguration config = new();
        Assert.False(config.AuthEnabled);
    }
}