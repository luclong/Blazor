#pragma checksum "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95448f24e8369d0d7ad5bc308aca20a3c8d3728b"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BaiTap\Blazor\Blazor\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
using Job;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quan-ly-cong-viec")]
    public class ManagerJob : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Quản Lý Công Việc</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<span class=\"col-lg-3\">Công Việc:</span>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-3");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control-sm");
            __builder.AddAttribute(11, "hidden", true);
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                                                           id_

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id_ = __value, id_));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control-sm");
            __builder.AddAttribute(18, "placeholder", "Công Việc");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                                                                                  job

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job = __value, job));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.AddMarkupContent(23, "<span class=\"col-lg-3\">Tình Trạng</span>\r\n    ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "class", "form-control-sm");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                   status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => status = __value, status));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "selected", true);
            __builder.AddMarkupContent(31, "Chưa Bắt Đầu");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "option");
            __builder.AddMarkupContent(34, "Bắt Đầu");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "option");
            __builder.AddMarkupContent(37, "Kết Thúc");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "option");
            __builder.AddMarkupContent(40, "Quá Thời Hạn");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddAttribute(46, "style", "margin-top:5px;");
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.AddMarkupContent(48, "<div class=\"col-lg-3\">\r\n        <span>Thời Gian Bắt Đầu</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-lg-3");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "class", "");
            __builder.AddAttribute(54, "type", "date");
            __builder.AddAttribute(55, "min", "2021-01-02");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                                           starttime

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => starttime = __value, starttime, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.AddMarkupContent(60, "<div class=\"col-lg-3\">\r\n        <span>Thời Gian Kết Thúc</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-lg-3");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "date");
            __builder.AddAttribute(66, "min", "2021-01-02");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                                  endtime

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endtime = __value, endtime, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-success float-right");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                                                      AddJob

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "Thêm Mới");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.OpenElement(77, "table");
            __builder.AddAttribute(78, "class", "table table-hover");
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.AddMarkupContent(80, "<thead>\r\n        <tr>\r\n            <th>Công Việc</th>\r\n            <th>Thời Gian Bắt Đầu</th>\r\n            <th>Thời Gian Kết Thúc</th>\r\n            <th>Tình Trạng</th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(81, "tbody");
            __builder.AddMarkupContent(82, "\r\n");
#nullable restore
#line 49 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
         foreach (var item in lstjob)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "            ");
            __builder.OpenElement(84, "tr");
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "th");
            __builder.AddContent(87, 
#nullable restore
#line 52 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                     item.Namejob

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "th");
            __builder.AddContent(90, 
#nullable restore
#line 53 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                     item.Starttime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "th");
            __builder.AddContent(93, 
#nullable restore
#line 54 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                     item.Endtime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.OpenElement(95, "th");
            __builder.AddContent(96, 
#nullable restore
#line 55 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                     item.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.OpenElement(98, "th");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                                        e=>EditJob(item.IdJob)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "class", "btn-info");
            __builder.AddMarkupContent(102, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.OpenElement(104, "th");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
                                        e=>DeleteJob(item.IdJob)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "class", "btn-danger");
            __builder.AddMarkupContent(108, "Xoá");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 59 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
           

    private DateTime starttime = (DateTime)DateTime.Now;
    private DateTime endtime = (DateTime)DateTime.Now.AddDays(1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\BaiTap\Blazor\Blazor\Blazor\Pages\ManagerJob.razor"
       
    TodoContext db = new TodoContext();
    private IList<Job> lstjob = new List<Job>();
    private string job;
    private string status;
    private int stt = 1;
    private int id = 0;
    private int id_ = 0;
    protected override void OnInitialized()
    {
        lstjob = db.Jobs.ToList();
    }
    public void AddJob()
    {
        if (lstjob.Count(x => x.Namejob == job) != 0&&id!=0)
        {
            var res = db.Jobs.FirstOrDefault(x => x.Namejob == job);
            res.Namejob = job;
            res.Starttime = starttime;
            res.Endtime = endtime;
            res.Status = status == null ? "Chưa Bắt Đầu" : status;
            db.SaveChanges();
            id_ = 0;
        }
        if (!string.IsNullOrWhiteSpace(job) && lstjob.Count(x => x.Namejob == job) == 0)
        {

            db.Jobs.Add(new Job { IdJob = stt, Namejob = job, Starttime = starttime == null ? DateTime.Now : starttime, Endtime = endtime == null ? DateTime.Now.AddDays(1) : endtime, Status = status == null ? "Chưa Bắt Đầu" : status });
            stt++;
        }
    }
    public void DeleteJob(int id)
    {
        var res = db.Jobs.FirstOrDefault(x => x.IdJob == id);
        lstjob.Remove(res);
    }
    public void EditJob(int id)
    {
        var res = db.Jobs.FirstOrDefault(x => x.IdJob == id);
        id = res.IdJob;
        job = res.Namejob;
        starttime = res.Starttime;
        endtime = res.Endtime;
        status = res.Status;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591