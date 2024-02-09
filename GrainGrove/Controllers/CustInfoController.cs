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

    /// <summary>
    /// �s�W�U��
    /// </summary>
    [HttpPost]
    public Task<InsertCustInfoResponse> InsertCustInfo(InsertCustInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// �s���U��
    /// </summary>
    [HttpPost]
    public Task<EditCustInfoResponse> EditCustInfo(EditCustInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// �R���U��
    /// </summary>
    [HttpPost]
    public Task<DeleteCustInfoResponse> DeleteCustInfo() => Mediator!.Send(new DeleteCustInfoRequest());
}