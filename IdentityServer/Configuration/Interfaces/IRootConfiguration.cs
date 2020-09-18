namespace IdentityServer.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        AdminConfiguration AdminConfiguration { get; }
        
        IdentityDataConfiguration IdentityDataConfiguration { get; }
        
        IdentityServerDataConfiguration IdentityServerDataConfiguration { get; }
        
        RegisterConfiguration RegisterConfiguration { get; }
    }
}