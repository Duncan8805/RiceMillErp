using AutoMapper;
using GrainGrove.Domain.Models;
using GrainGrove.Domain.Po;
using GrainGrove.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GrainGrove.Application.CustInfo;

/// <summary>
/// 取得顧客資料
/// </summary>
public class GetCustInfoCommandHandler : IRequestHandler<GetCustInfoRequest, GetCustInfoResponse>
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
    public GetCustInfoCommandHandler(IMapper mapper, GrainGroveDBContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<GetCustInfoResponse> Handle(GetCustInfoRequest request, CancellationToken cancellationToken)
    {
        GetCustInfoResponse response = new();

        try
        {
            
            if (request.CustName == string.Empty)
            {
                List<CustInfoPo> respData = await _context.CustInfo.ToListAsync();
                response = new()
                {
                    Data = _mapper.Map<List<CustInfoPo>>(respData)
                };
            }
            else
            {
                List<CustInfoPo> respData = await _context.CustInfo.ToListAsync();
                List<CustInfoPo> respDataList = respData.Where(x => x.CustName == request.CustName || x.CustPhone == request.CustPhone).ToList();

                response = new()
                {
                    Data = _mapper.Map<List<CustInfoPo>>(respData)
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