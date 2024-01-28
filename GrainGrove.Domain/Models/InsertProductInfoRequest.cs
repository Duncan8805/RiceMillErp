using MediatR;

namespace GrainGrove.Domain.Models;

/// <summary>
/// 新增產品 Request
/// </summary>
public class InsertProductInfoRequest : IRequest<InsertProductInfoResponse>
{
    /// <summary>
    /// 顧客身分證
    /// </summary>
    public string? CustId { get; set; }

    /// <summary>
    /// 顧客司機(車牌號碼)
    /// </summary>
    public string? DriverOrLicensePlateNo { get; set; }

    /// <summary>
    /// 貨名
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// 貨物狀態(乾/濕)
    /// </summary>
    public bool? ProductStatus { get; set; }

    /// <summary>
    /// 單價
    /// </summary>
    public long? UnitPrice { get; set; }

    /// <summary>
    /// 總車重輛(KG)
    /// </summary>
    public double? TotalWeight { get; set; }

    /// <summary>
    /// 空車重量(KG)
    /// </summary>
    public double? EmptyWeight { get; set; }

    /// <summary>
    /// 是否公糧
    /// </summary>
    public bool? IsPublicGrain { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? Creater { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? CreateDate { get; set; }
}
