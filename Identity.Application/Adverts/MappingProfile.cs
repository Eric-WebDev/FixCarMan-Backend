﻿using AutoMapper;
using Identity.Application.Vehicles;
using Identity.Domain;

namespace Identity.Application.Adverts
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            CreateMap<UserAdvert, Profiles.UserAdDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.AdvertId))
                .ForMember(d => d.Title, o => o.MapFrom(s => s.Advert.Title))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Advert.Description))
                .ForMember(d => d.CarModel, o => o.MapFrom(s => s.Advert.CarModel))
                .ForMember(d => d.City, o => o.MapFrom(s => s.Advert.City))
                .ForMember(d => d.Date, o => o.MapFrom(s => s.Advert.Date))
                .ForMember(d => d.AdvertiserUsername, o => o.MapFrom(s => s.AppUser.UserName));
            CreateMap<Advert, AdDto>();
            CreateMap<Vehicle, VehicleDto>()
                .ForMember(d => d.VehicleOwnerUsername, o => o.MapFrom(s => s.VehicleOwner.UserName)); ;
                

        }
    }
}
