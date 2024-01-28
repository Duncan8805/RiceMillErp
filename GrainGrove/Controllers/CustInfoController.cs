using GrainGrove.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrainGrove.Controllers;

public class CustInfoController : BaseApiController
{
    /// <summary>
    /// ���o�U�ȸ��
    /// </summary>
    [HttpPost]
    public Task<GetCustInfoResponse> GetCustInfo(GetCustInfoRequest request) => Mediator!.Send(request);
}