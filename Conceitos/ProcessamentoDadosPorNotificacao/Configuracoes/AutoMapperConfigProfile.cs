using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Model;
using View.Request;

namespace Configuracoes
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoMapperConfigProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public AutoMapperConfigProfile()
        {
            CreateMap<DadosRequest, Dados>();
        }


    }
}
