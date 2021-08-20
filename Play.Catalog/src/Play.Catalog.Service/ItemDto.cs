using System;
using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.Controllers
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);
    public record CreateItemDto([Required] string Name, string Description, [Range(0, 10000)] decimal Price);
    public record UpdateItemDto([Required] string Name, string Description, [Range(0, 10000)] decimal Price);

}