﻿using AutoMapper;
using DHotel_Back.DTOs;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class HuespedProfiles : Profile
    {
        public HuespedProfiles()
        {
            CreateMap<HuespedCreacionDTO, Huesped>();

            CreateMap<HuespedModificacionDTO, Huesped>();            
        }
    }
}