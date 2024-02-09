using GrainGrove.Domain.Models;
using GrainGrove.Domain.Po;
using GrainGrove.Infrastructure;
using MediatR;

namespace GrainGrove.Application.CustInfo;

/// <summary>
/// 刪除顧客
/// </summary>
public class DeleteCustInfoCommandHandler : IRequestHandler<DeleteCustInfoRequest, DeleteCustInfoResponse>
{
    /// <summary>
    /// Db Context
    /// </summary>
    private readonly GrainGroveDBContext _context;

    /// <summary>
    /// 建構子
    /// </summary>
    public DeleteCustInfoCommandHandler(GrainGroveDBContext context)
    {
        _context = context;
    }

    public async Task<DeleteCustInfoResponse> Handle(DeleteCustInfoRequest request, CancellationToken cancellationToken)
    {
        DeleteCustInfoResponse response = new();

        try
        {

            CustInfoPo? deleteCustInfo = _context.CustInfo.Where(s => s.CustId == request.CustId).FirstOrDefault();

            if (deleteCustInfo == null)
            {
                response = new()
                {
                    Code = "404",
                    Data = null,
                    Msg = "Data not found"
                };
                return response;
            }

            _context.Remove(deleteCustInfo);
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
