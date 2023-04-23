namespace Rebelweb.MappingServiceClient;
public class MappingServiceConfiguration : IMappingServiceConfiguration
{
    public string? ApiKey { get; set; }

    public bool AuthEnabled => ApiKey != null;
}
