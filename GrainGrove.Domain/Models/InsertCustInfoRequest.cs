using MediatR;

namespace GrainGrove.Domain.Models;

/// <summary>
/// 新增顧客 Request
/// </summary>
public class InsertCustInfoRequest : IRequest<InsertCustInfoResponse>
{
    /// <summary>
    /// 顧客名稱
    /// </summary>
    public string? CustName { get; set; }

    /// <summary>
    /// 顧客身分證
    /// </summary>
    public string? CustId { get; set; }

    /// <summary>
    /// 顧客手機
    /// </summary>
    public int? CustPhone { get; set; }

    /// <summary>
    /// 顧客地址
    /// </summary>
    public string? CustAddr { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? Creater { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? CreateDate { get; set; }
}
