using Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels;
using System;
using System.Collections.Generic;

namespace Sage.Pessoas.Infra.CrossCutting.Configuration.Extensions
{
    public static class ResponseExtensions
    {
        public static ResponseData<T> ToResponse<T>(this T data)
        {
            return new ResponseData<T>(data);
        }
    }
}
