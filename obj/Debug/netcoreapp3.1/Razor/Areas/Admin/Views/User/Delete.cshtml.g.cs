#pragma checksum "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36e4cf7f13b2cf3b6548b8d2448d83ab1392a5f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "D:\VSprojects\Finances\Areas\Admin\Views\_ViewImports.cshtml"
using Finances.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VSprojects\Finances\Areas\Admin\Views\_ViewImports.cshtml"
using Finances.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36e4cf7f13b2cf3b6548b8d2448d83ab1392a5f0", @"/Areas/Admin/Views/User/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90dec3e53776dc5d925d46d6d559c3c9d63891be", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Finances.Domain.Entities.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Видалення</h1>\r\n\r\n<h3>Ви впевнені, що хочете видалити цього користувача?</h3>\r\n<div class=\"row\">\r\n    <h4>EntityBase</h4>\r\n    <hr />\r\n    <dl>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
#nullable restore
#line 34 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
     using (Html.BeginForm("Delete", "User"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Видалити\" class=\"btn btn-danger\" />\r\n");
#nullable restore
#line 38 "D:\VSprojects\Finances\Areas\Admin\Views\User\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Finances.Domain.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
