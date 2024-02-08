using AutoMapper;
using GrainGrove.Domain.Models;
using GrainGrove.Domain.Po;
using GrainGrove.Infrastructure;
using MediatR;

namespace GrainGrove.Application.CustInfo;

/// <summary>
/// 新增顧客
/// </summary>
public class InsertCustInfoCommandHandler : IRequestHandler<InsertCustInfoRequest, InsertCustInfoResponse>
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
    public InsertCustInfoCommandHandler(IMapper mapper, GrainGroveDBContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<InsertCustInfoResponse> Handle(InsertCustInfoRequest request, CancellationToken cancellationToken)
    {
        InsertCustInfoResponse response = new();

        try
        {
            string guid = DateTime.Now.ToString("yyyyMMddHHmmss");
            CustInfoPo InsertCustInfo = new()
            {
                CustName = request.CustName,
                CustId = request.CustId,
                CustPhone = Convert.ToInt32(request.CustPhone),
                CustAddr = request.CustAddr,
                Creater = "Admin",
                CreateDate = DateTime.Now
            };

            _context.Add(InsertCustInfo);
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
}