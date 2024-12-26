using AutoMapper;
using crud.Models;
using crud.Services.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            CreateMap<User, UserDto>().ForMember(dest => dest.Address, opt => opt.MapFrom(src => $"{src.AddressNo}, {src.Street}, {src.City}"));
        }
    }
}
