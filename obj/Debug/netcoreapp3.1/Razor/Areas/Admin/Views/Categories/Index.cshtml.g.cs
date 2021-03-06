#pragma checksum "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8464ef88975d9daed190e50e0bb33e8352bcc7e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8464ef88975d9daed190e50e0bb33e8352bcc7e6", @"/Areas/Admin/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90dec3e53776dc5d925d46d6d559c3c9d63891be", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Finances.Domain.Entities.Categories>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Категорії";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Категорії</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 11 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
Write(Html.ActionLink("Додати", "Create", "Categories", new { area = "Admin" }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Дохід/Витрати\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 31 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
                 if (item.Direction == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Дохід</p>\r\n");
#nullable restore
#line 34 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Витрати</p>\r\n");
#nullable restore
#line 38 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.ActionLink("Редагувати", "Edit", "Categories", new { area = "Admin", id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 42 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
           Write(Html.ActionLink("Видалити", "Delete", "Categories", new { area = "Admin", id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Finances.Domain.Entities.Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
