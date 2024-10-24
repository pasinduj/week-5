using IndustryConnect_Week5_WebApi.Dtos;
using IndustryConnect_Week5_WebApi.Models;

namespace IndustryConnect_Week5_WebApi.Mappers
{
    public class SaleMapper
    {

        public static Sale DtoToEntity(SaleDto saleDto)
        {
            var entity = new Sale
            {
                Id = saleDto.Id,
                CustomerId = saleDto.CustomerId,
                ProductId = saleDto.ProductId,
                DateSold = saleDto.DateSold,
                StoreId = saleDto.StoreId,
                Customer = saleDto.Customer,
                Product = saleDto.Product,
                Store = saleDto.Store
            };

            return entity;
        }

        public static SaleDto EntityToDto(Sale sale)
        {
            var dto = new SaleDto
            {
                Id = sale.Id,
                CustomerId = sale.CustomerId,
                ProductId = sale.ProductId,
                DateSold = sale.DateSold,
                StoreId = sale.StoreId,
                Customer = sale.Customer,
                Product = sale.Product,
                Store = sale.Store

            };

            return dto;
        }

    }
}
