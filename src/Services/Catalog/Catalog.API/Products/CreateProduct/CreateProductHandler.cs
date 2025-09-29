using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProdcutCommand(string Name,List<string> Category, string Description,string ImageFile, decimal Price)
    :ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler:ICommandHandler<CreateProdcutCommand,CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProdcutCommand command, CancellationToken cancellationToken)
    {
        //Create Product entity from command object
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Descriptiom = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };
        //save to database
        
        //return CreateProductResult result
        return new CreateProductResult(Guid.NewGuid());
        throw new NotImplementedException();
    }
}