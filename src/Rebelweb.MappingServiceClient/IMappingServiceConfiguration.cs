namespace Rebelweb.MappingServiceClient;
public interface IMappingServiceConfiguration
{
    string? ApiKey { get; set; }

    bool AuthEnabled { get; }
}