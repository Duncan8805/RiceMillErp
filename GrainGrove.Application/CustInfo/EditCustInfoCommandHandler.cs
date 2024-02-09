using AutoMapper;
using GrainGrove.Domain.Models;
using GrainGrove.Domain.Po;
using GrainGrove.Infrastructure;
using MediatR;

namespace GrainGrove.Application.CustInfo;

/// <summary>
/// 編輯顧客
/// </summary>
public class EditCustInfoCommandHandler : IRequestHandler<EditCustInfoRequest, EditCustInfoResponse>
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
    public EditCustInfoCommandHandler(IMapper mapper, GrainGroveDBContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<EditCustInfoResponse> Handle(EditCustInfoRequest request, CancellationToken cancellationToken)
    {
        EditCustInfoResponse response = new();

        try
        {
            CustInfoPo? getCustInfo = _context.CustInfo.Where(s => s.CustId == request.CustId).FirstOrDefault();

            if (getCustInfo == null)
            {
                response = new()
                {
                    Code = "404",
                    Data = null,
                    Msg = "Data not found"
                };
                return response;
            }

            string guid = DateTime.Now.ToString("yyyyMMddHHmmss");
            CustInfoPo EditCusInfo = new()
            {
                CustNo = request.CustNo,
                CustName = request.CustName,
                CustId = request.CustId,
                CustPhone = Convert.ToInt32(request.CustPhone),
                CustAddr = request.CustAddr,
                Editer = "Admin",
                EditDate = DateTime.Now
            };

            _context.Update(EditCusInfo);
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