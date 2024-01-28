using GrainGrove.Application.CustInfo;
using GrainGrove.Domain.Models;
using MediatR;
using System.Reflection;

namespace GrainGrove.DiExtension;

public static class ApCommandExtension
{
    public static IServiceCollection AddApCommands(this IServiceCollection service)
    {
        service.AddMediatR(cf => cf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        //service.AddScoped<IGoogleAdsService, GoogleAdsService>();

        service.AddScoped<IRequestHandler<GetCustInfoRequest, GetCustInfoResponse>, GetCustInfoCommandHandler>();

        //service.AddScoped<IRequestHandler<GetReportContentRequest, GetReportContentResponse>, GetReportContentCommandHandler>();

        return service;
    }
}
