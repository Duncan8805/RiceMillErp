using GrainGrove.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrainGrove.Controllers;

public class CustInfoController : BaseApiController
{
    /// <summary>
    /// 取得顧客資料
    /// </summary>
    [HttpPost]
    public Task<GetCustInfoResponse> GetCustInfo(GetCustInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// 新增顧客
    /// </summary>
    [HttpPost]
    public Task<InsertCustInfoResponse> InsertCustInfo(InsertCustInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// 編輯顧客
    /// </summary>
    [HttpPost]
    public Task<EditCustInfoResponse> EditCustInfo(EditCustInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// 刪除顧客
    /// </summary>
    [HttpPost]
    public Task<DeleteCustInfoResponse> DeleteCustInfo() => Mediator!.Send(new DeleteCustInfoRequest());
}