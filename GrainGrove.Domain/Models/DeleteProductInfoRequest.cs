using MediatR;

namespace GrainGrove.Domain.Models;

/// <summary>
/// 刪除產品 Request
/// </summary>
public class DeleteProductInfoRequest : IRequest<DeleteProductInfoResponse>
{
    /// <summary>
    /// 產品序號(單號)
    /// </summary>
    public int ProductGuid { get; set; }
}
