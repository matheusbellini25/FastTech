﻿using AutoMapper;
using FastTech.Domain.Entities;
using DTO = FastTech.Application.DataTransferObjects;
using MSG = FastTech.Application.DataTransferObjects.MessageBrokers;


namespace FastTech.Application.Mappings
{
    public class PedidoItemCardapioMapper : Profile
    {
        public PedidoItemCardapioMapper()
        {
            CreateMap<PedidoItemCardapio, DTO.PedidoItemCardapio>()
            .ConstructUsing(src => new DTO.PedidoItemCardapio())
            .ReverseMap()
            .ConstructUsing(src => new PedidoItemCardapio())
            .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
            .ForMember(dest => dest.RemovedAt, opt => opt.Ignore())
            .ForMember(dest => dest.RemovedBy, opt => opt.Ignore())
            .ForMember(dest => dest.Removed, opt => opt.Ignore());

            CreateMap<DTO.BasicPedidoItemCardapio, PedidoItemCardapio>()
                .ConstructUsing(src => new PedidoItemCardapio());

            CreateMap<PedidoItemCardapio, MSG.PedidoItemCardapio>()
                .ReverseMap()
                .ConstructUsing(src => new PedidoItemCardapio())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.RemovedAt, opt => opt.Ignore())
                .ForMember(dest => dest.RemovedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Removed, opt => opt.Ignore());

            CreateMap<MSG.BasicPedidoItemCardapio, PedidoItemCardapio>()
                .ConstructUsing(src => new PedidoItemCardapio());
        }
    }
}
