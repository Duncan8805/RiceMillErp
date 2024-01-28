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
}