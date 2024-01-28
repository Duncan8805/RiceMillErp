using AutoMapper;
using GrainGrove.Domain.Models;
using GrainGrove.Domain.Po;
using GrainGrove.Infrastructure;
using MediatR;

namespace GrainGrove.Application.ProductInfo;

/// <summary>
/// 新增產品
/// </summary>
public class InsertProductInfoCommandHandler : IRequestHandler<InsertProductInfoRequest, InsertProductInfoResponse>
{
    /// <summary>
    /// Db Context
    /// </summary>
    private readonly GrainGroveDBContext _context;

    /// <summary>
    /// mapper
    /// </summary>
    private readonly IMapper _mapper;

    /// <summary>
    /// 建構子
    /// </summary>
    public InsertProductInfoCommandHandler(IMapper mapper, GrainGroveDBContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<InsertProductInfoResponse> Handle(InsertProductInfoRequest request, CancellationToken cancellationToken)
    {
        InsertProductInfoResponse response = new();

        try
        {
            string guid = DateTime.Now.ToString("yyyyMMddHHmmss");
            ProductInfoPo InsertProductInfo = new()
            {
                CustId = request.CustId,
                DriverOrLicensePlateNo = request.DriverOrLicensePlateNo,
                ProductGuid = Convert.ToInt32(guid),
                ProductName = request.ProductName,
                ProductStatus = request.ProductStatus,
                TotalPrice = (long?)(request.TotalWeight * request.UnitPrice),
                UnitPrice = request.UnitPrice,
                TotalWeight = request.TotalWeight,
                EmptyWeight = request.EmptyWeight,
                ActualWeight = request.TotalWeight - request.EmptyWeight,
                IsPublicGrain = request.IsPublicGrain,
                ConvertToTKG = ConvertToTKG(request.TotalWeight),
                Creater = "Admin",
                CreateDate = DateTime.Now
            };

            _context.Add(InsertProductInfo);
            await _context.SaveChangesAsync();

            response = new()
            {
                Code = "200",
                Data = null,
                Msg = "Success"
            };
        }
        catch (Exception ex)
        {
            response = new()
            {
                Code = "404",
                Data = null,
                Msg = ex.ToString()
            };
        }

        return response;
    }

    /// <summary>
    /// 公斤轉換台斤功能
    /// </summary>
    /// <param name="kilograms"></param>
    /// <returns></returns>
    private double? ConvertToTKG(double? kilograms)
    {
        if (kilograms == null) return null;
        // 台斤公斤轉換率
        double conversionRate = 1.2046;

        return kilograms * conversionRate;
    }
}