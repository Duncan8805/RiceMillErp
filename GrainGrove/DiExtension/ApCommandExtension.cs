using GrainGrove.Application.CustInfo;
using GrainGrove.Application.ProductInfo;
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
        service.AddScoped<IRequestHandler<InsertCustInfoRequest, InsertCustInfoResponse>, InsertCustInfoCommandHandler>();
        service.AddScoped<IRequestHandler<EditCustInfoRequest, EditCustInfoResponse>, EditCustInfoCommandHandler>();
        service.AddScoped<IRequestHandler<DeleteCustInfoRequest, DeleteCustInfoResponse>, DeleteCustInfoCommandHandler>();

        service.AddScoped<IRequestHandler<GetProductInfoRequest, GetProductInfoResponse>, GetProductInfoCommandHandler>();
        service.AddScoped<IRequestHandler<InsertProductInfoRequest, InsertProductInfoResponse>, InsertProductInfoCommandHandler>();
        service.AddScoped<IRequestHandler<EditProductInfoRequest, EditProductInfoResponse>, EditProductInfoCommandHandler>();
        service.AddScoped<IRequestHandler<DeleteProductInfoRequest, DeleteProductInfoResponse>, DeleteProductInfoCommandHandler>();

        //service.AddScoped<IRequestHandler<GetReportContentRequest, GetReportContentResponse>, GetReportContentCommandHandler>();

        return service;
    }
}
