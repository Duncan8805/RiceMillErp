using GrainGrove.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrainGrove.Controllers;

public class ProductInfoController : BaseApiController
{
    /// <summary>
    /// 取得產品
    /// </summary>
    [HttpPost]
    public Task<GetProductInfoResponse> GetCustInfo(GetProductInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// 新增產品
    /// </summary>
    [HttpPost]
    public Task<InsertProductInfoResponse> InsertProductInfo(InsertProductInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// 編輯產品
    /// </summary>
    [HttpPost]
    public Task<EditProductInfoResponse> EditCustInfo(EditProductInfoRequest request) => Mediator!.Send(request);

    /// <summary>
    /// 刪除產品
    /// </summary>
    [HttpPost]
    public Task<DeleteProductInfoResponse> DeleteProductInfo() => Mediator!.Send(new DeleteProductInfoRequest());
}