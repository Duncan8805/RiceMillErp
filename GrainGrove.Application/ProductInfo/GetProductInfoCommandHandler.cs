using AutoMapper;
using GrainGrove.Domain.Models;
using GrainGrove.Domain.Po;
using GrainGrove.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GrainGrove.Application.CustInfo;

/// <summary>
/// 取得商品資料
/// </summary>
public class GetProductInfoCommandHandler : IRequestHandler<GetProductInfoRequest, GetProductInfoResponse>
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
    public GetProductInfoCommandHandler(IMapper mapper, GrainGroveDBContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<GetProductInfoResponse> Handle(GetProductInfoRequest request, CancellationToken cancellationToken)
    {
        GetProductInfoResponse response = new();

        try
        {
            
            if (request.CustId == string.Empty || request.ProductGuid == 0 || request.DriverOrLicensePlateNo==string.Empty)
            {
                List<ProductInfoPo> respData = await _context.ProductInfo.ToListAsync();
                response = new()
                {
                    Data = _mapper.Map<List<ProductInfoPo>>(respData)
                };
            }
            else
            {
                List<ProductInfoPo> respData = await _context.ProductInfo.ToListAsync();
                List<ProductInfoPo> respDataList = respData.Where(x => x.CustId == request.CustId || x.ProductGuid == request.ProductGuid || x.DriverOrLicensePlateNo == request.DriverOrLicensePlateNo).ToList();

                response = new()
                {
                    Data = _mapper.Map<List<ProductInfoPo>>(respData)
                };
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return response;
    }
}