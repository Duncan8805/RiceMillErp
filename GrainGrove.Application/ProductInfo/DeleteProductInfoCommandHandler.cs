using GrainGrove.Domain.Models;
using GrainGrove.Domain.Po;
using GrainGrove.Infrastructure;
using MediatR;

namespace GrainGrove.Application.ProductInfo;

/// <summary>
/// 刪除產品
/// </summary>
public class DeleteProductInfoCommandHandler : IRequestHandler<DeleteProductInfoRequest, DeleteProductInfoResponse>
{
    /// <summary>
    /// Db Context
    /// </summary>
    private readonly GrainGroveDBContext _context;

    /// <summary>
    /// 建構子
    /// </summary>
    public DeleteProductInfoCommandHandler(GrainGroveDBContext context)
    {
        _context = context;
    }

    public async Task<DeleteProductInfoResponse> Handle(DeleteProductInfoRequest request, CancellationToken cancellationToken)
    {
        DeleteProductInfoResponse response = new();

        try
        {

            ProductInfoPo? deleteProductInfo = _context.ProductInfo.Where(s => s.ProductGuid == request.ProductGuid).FirstOrDefault();

            if (deleteProductInfo == null)
            {
                response = new()
                {
                    Code = "404",
                    Data = null,
                    Msg = "Data not found"
                };
                return response;
            }

            _context.Remove(deleteProductInfo);
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
