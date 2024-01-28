using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrainGrove.Domain.Po;

/// <summary>
/// 顧客資料 Po
/// </summary>
[Table("CustInfo")]
public class CustInfoPo
{
    /// <summary>
    /// 顧客資料(流水號)
    /// </summary>
    [Key]
    public int CustNo { get; set; }

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
