namespace CatalogService.Domain.Entities;

public class ServiceCatalogItem
{
    public Guid Id { get; set; }
    public string ServiceName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}
