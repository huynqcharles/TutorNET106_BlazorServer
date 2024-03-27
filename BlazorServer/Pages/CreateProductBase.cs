using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using Shared;

namespace BlazorServer.Pages
{
    public class CreateProductBase : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected Product Product { get; set; } = new Product();

        protected async Task SubmitForm()
        {
            await ProductService.CreateProduct(Product);
            NavigationManager.NavigateTo("/list-products");
        }
    }
}
