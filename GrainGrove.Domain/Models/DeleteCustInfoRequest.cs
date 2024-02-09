using MediatR;

namespace GrainGrove.Domain.Models;

/// <summary>
/// 刪除顧客 Request
/// </summary>
public class DeleteCustInfoRequest : IRequest<DeleteCustInfoResponse>
{
    /// <summary>
    /// 顧客身分證
    /// </summary>
    public string? CustId { get; set; }
}
