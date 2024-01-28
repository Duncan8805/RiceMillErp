using MediatR;

namespace GrainGrove.Domain.Models;

/// <summary>
/// 取得客戶資訊 Request
/// </summary>
public class GetCustInfoRequest : IRequest<GetCustInfoResponse>
{
    /// <summary>
    /// 顧客名稱
    /// </summary>
    public string? CustName { get; set; }

    /// <summary>
    /// 顧客手機
    /// </summary>
    public int? CustPhone { get; set; }
}