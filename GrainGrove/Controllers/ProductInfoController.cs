using GrainGrove.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrainGrove.Controllers;

public class ProductInfoController : BaseApiController
{
    /// <summary>
    /// 新增產品
    /// </summary>
    [HttpPost]
    public Task<InsertProductInfoResponse> InsertProductInfo(InsertProductInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// 刪除產品
    /// </summary>
    [HttpPost]
    public Task<DeleteProductInfoResponse> DeleteProductInfo() => Mediator!.Send(new DeleteProductInfoRequest());
}