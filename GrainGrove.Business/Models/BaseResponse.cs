﻿namespace GrainGrove.Business.Models;

/// <summary>
/// Api 基底 Response
/// </summary>
/// <typeparam name="T"></typeparam>
public class BaseResponse<T>
{
    /// <summary>
    /// 回傳碼
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// 資料
    /// </summary>
    public List<T>? Data { get; set; }

    /// <summary>
    /// 訊息
    /// </summary>
    public string? Msg { get; set; }
}
