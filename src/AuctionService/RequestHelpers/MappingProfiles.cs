﻿using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
            CreateMap<Item, AuctionDto>();
            CreateMap<CreateAuctionDTO, Auction>().ForMember(d => d.Item, o => o.MapFrom(s => s)); //s - Item
            CreateMap<CreateAuctionDTO, Item>();
        }
    }
}
