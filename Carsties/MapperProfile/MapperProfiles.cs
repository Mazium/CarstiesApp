using AutoMapper;
using Carsties.Data.DTOs.Auction;
using Carsties.Domain.Models;

namespace Carsties.Api.MapperProfile
{
    public class MapperProfiles: Profile
    {
        public MapperProfiles()
        {
            CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
            CreateMap<Item, AuctionDto>();
            CreateMap<Item, CreateAuctionDto>();
            CreateMap<CreateAuctionDto, Auction>()
                .ForMember(d => d.Item, o => o.MapFrom(s => s)).ReverseMap();
            CreateMap<CreateAuctionDto, Item>();
        }
    }
}
