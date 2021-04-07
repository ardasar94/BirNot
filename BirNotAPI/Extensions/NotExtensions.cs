using BirNotAPI.DTOs;
using BirNotAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirNotAPI.Extensions
{
    public static class NotExtensions
    {
        public static GetNotDto ToGetNotDTO(this Not not)
        {
            return new GetNotDto()
            {
                Id = not.Id,
                Baslik = not.Baslik,
                Icerik = not.Icerik,
                SonDegistirilme = not.SonDegistirilme
            };
        }
    }
}