using MediatR;

namespace GrainGrove.Domain.Models;

/// <summary>
/// 取得客戶資訊 Request
/// </summary>
public class GetProductInfoRequest : IRequest<GetProductInfoResponse>
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
    /// 產品序號(單號)
    /// </summary>
    public int ProductGuid { get; set; }
}