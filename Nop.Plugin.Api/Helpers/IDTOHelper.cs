﻿using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Orders;
using Nop.Plugin.Api.DTOs.Categories;
using Nop.Plugin.Api.DTOs.Orders;
using Nop.Plugin.Api.DTOs.Products;
using Nop.Plugin.Api.DTOs.ShoppingCarts;

namespace Nop.Plugin.Api.Helpers
{
    public interface IDTOHelper
    {
        ProductDto PrepareProductDTO(Product product);
        CategoryDto PrepareCategoryDTO(Category category);
        OrderDto PrepareOrderDTO(Order order);
        ShoppingCartItemDto PrepareShoppingCartItemDTO(ShoppingCartItem shoppingCartItem);
    }
}
