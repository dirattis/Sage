using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Sage.Pessoas.Infra.CrossCutting.Configuration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sage.Pessoas.API.Middlewares
{
    public static class ErrorHandlingMiddleware
    {
        public static void UseConfigureExceptionHandler(this IApplicationBuilder app, ILogger<Startup> logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"Ocorreu o seguinte erro: {contextFeature.Error}");

                        await context.Response.WriteAsync(new ResponseData("Erro interno, por favor contate o administrador!").ToString());
                    }
                });
            });
        }
    }
}
