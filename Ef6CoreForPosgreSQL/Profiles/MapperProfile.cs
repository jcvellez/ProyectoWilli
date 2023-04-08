using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ef6CoreForPosgreSQL.DTOS;
using Ef6CoreForPosgreSQL.Entities;
using StackExchange.Redis;

namespace ApiScan.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<PerfilDTO, IPerfil>().ReverseMap();
            this.CreateMap<FarmaciaDTO, IFarmacia>().ReverseMap();
            this.CreateMap<FilesDTO, IFiles>().ReverseMap();
            this.CreateMap<UserScannerDTO, IUserScanner>().ReverseMap();

        }
    }
}
