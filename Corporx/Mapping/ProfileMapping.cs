using AutoMapper;
using Corporx.Resources;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corporx.Mapping
{
    public class ProfileMapping : Profile
    {
        private static string BaseUrl = "https://localhost:44355/img/";

        public ProfileMapping()
        {

            CreateMap<Services, ServicesResource>();

            CreateMap<QualityWork, QualityWorkResource>();

            CreateMap<News, NewsResource>()
                .ForMember(n => n.Categories, opt => opt.MapFrom(src => src.NewsCategories
                                                                        .Select(s => s.Category.Name)
                                                                        .ToList()));

            CreateMap<Team, TeamResource>()
            .ForMember(d => d.Photos, opt => opt.MapFrom(src => src.TeamPhotos
            .Select(p => BaseUrl + p.Photo)));

            CreateMap<NewsResource, NewsCategory>();

            CreateMap<Client, ClientResource>();

            CreateMap<Data.Entities.Corporx, CorporxResource>()
                .ForMember(l => l.Logo, opt => opt.MapFrom(src => BaseUrl + src.Logo));

        }

    }
}
