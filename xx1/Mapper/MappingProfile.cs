using AutoMapper;
using Back_End.Models;
using SupplyChain.Data_Transfer_Object_DTOs_;
using SupplyChain.Entities_Models_;

namespace SupplyChain.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ChequeEntity,ChequeDto>();
            CreateMap<ChequeDto, ChequeEntity>();

            CreateMap<CashEntity, CashDto>();
            CreateMap<CashDto, CashEntity>();

           

            CreateMap<ProductEntity, ProductDto>().ReverseMap();
            CreateMap<CustomerEntity, CustomerDto>().ReverseMap();
            CreateMap<DeliveryEntity, DeliveryDto>().ReverseMap();
            CreateMap<OrderEntity, OrderDto>().ReverseMap();
            CreateMap<PaymentEntity, PaymentDto>().ReverseMap();
            CreateMap<ReturnEntity, ReturnDto>().ReverseMap();
            CreateMap<SupplierEntity, SupplierDto>().ReverseMap();
        }
    }
}
