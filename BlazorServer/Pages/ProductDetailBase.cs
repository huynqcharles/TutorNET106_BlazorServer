﻿using BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using Shared;

namespace BlazorServer.Pages
{
    public class ProductDetailBase : ComponentBase
    {
        [Inject]
        protected IProductService ProductService { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }
        public Product Product { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Product = await ProductService.GetProductById(int.Parse(Id));
        }

        protected async Task DeleteProduct()
        {
            await ProductService.DeleteProduct(int.Parse(Id));
            NavigationManager.NavigateTo("/list-products");

        }
    }
}
