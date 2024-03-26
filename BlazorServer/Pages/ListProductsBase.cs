using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using Shared;

namespace BlazorServer.Pages
{
    public class ListProductsBase : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; }
        protected List<Product> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = (await ProductService.GetProducts()).ToList();
        }
    }
}