using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrainGrove.Domain.Po;

/// <summary>
/// 商品資料 Po
/// </summary>
[Table("ProductInfo")]
public class ProductInfoPo
{
    /// <summary>
    /// 顧客資料(流水號)
    /// </summary>
    [Key]
    public int ProductNo { get; set; }

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

    /// <summary>
    /// 貨名
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// 貨物狀態(乾/濕)
    /// </summary>
    public bool? ProductStatus { get; set; }

    /// <summary>
    /// 總價
    /// </summary>
    public long? TotalPrice { get; set; }

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
    /// 貨物實際重量(KG)
    /// </summary>
    public double? ActualWeight { get; set; }

    /// <summary>
    /// 是否公糧
    /// </summary>
    public bool? IsPublicGrain { get; set; }

    /// <summary>
    /// 換算臺斤
    /// </summary>
    public double? ConvertToTKG { get; set; }


    /// <summary>
    /// 編輯者
    /// </summary>
    public string? Editer { get; set; }

    /// <summary>
    /// 編輯時間
    /// </summary>
    public DateTime? EditDate { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? Creater { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? CreateDate { get; set; }
}
