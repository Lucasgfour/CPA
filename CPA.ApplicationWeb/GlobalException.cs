using CPA.Commom.Models;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;
using System.Text;

namespace CPA.ApplicationWeb {
    public static class GlobalException {

        public static void ConfigureExceptionHandler(this IApplicationBuilder app) {

            app.UseExceptionHandler(errorApp => {
                errorApp.Run(async context => {
                    context.Response.StatusCode = 200;
                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null) {
                        var ex = error.Error;

                        ResponseResult<Object> result = new ResponseResult<Object>(false, ex.Message);

                        await context.Response.WriteAsync(JsonConvert.SerializeObject(result).Replace("Message", "message").Replace("Success", "success").Replace("Data", "data"), Encoding.UTF8);
                    }
                });
            });

        }

    }
}
