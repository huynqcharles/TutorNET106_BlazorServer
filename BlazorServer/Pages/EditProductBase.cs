using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using Shared;

namespace BlazorServer.Pages
{
    public class EditProductBase : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected Product Product { get; set; } = new Product();

        protected override async Task OnInitializedAsync()
        {
            Product = await ProductService.GetProductById(int.Parse(Id));
        }

        protected async Task SubmitForm()
        {
            await ProductService.EditProduct(Product);
            NavigationManager.NavigateTo("/list-products");
        }
    }
}
