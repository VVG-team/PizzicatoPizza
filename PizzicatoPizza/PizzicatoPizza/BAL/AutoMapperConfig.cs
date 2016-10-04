using AutoMapper;
using PizzicatoPizza.Models.DB;
using PizzicatoPizza.Models.DTO;

namespace PizzicatoPizza.BAL
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserDTO>());
            Mapper.Initialize(cfg => cfg.CreateMap<UserDTO, User>());

            Mapper.Initialize(cfg => cfg.CreateMap<Courier, CourierDTO>());
            Mapper.Initialize(cfg => cfg.CreateMap<CourierDTO, Courier>());

            Mapper.Initialize(cfg => cfg.CreateMap<Ingredient, IngredientDTO>());
            Mapper.Initialize(cfg => cfg.CreateMap<IngredientDTO, Ingredient>());

            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDTO>());
            Mapper.Initialize(cfg => cfg.CreateMap<OrderDTO, Order>());

            Mapper.Initialize(cfg => cfg.CreateMap<Pizza, PizzaDTO>());
            Mapper.Initialize(cfg => cfg.CreateMap<PizzaDTO, Pizza>());

            Mapper.Initialize(cfg => cfg.CreateMap<Size, SizeDTO>());
            Mapper.Initialize(cfg => cfg.CreateMap<SizeDTO, Size>());
        }
    }
}