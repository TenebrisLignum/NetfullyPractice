#pragma checksum "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d84f9526632765a80fc0ed69a6368625f630065"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Create.cshtml")]
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
#line 2 "D:\VSprojects\Finances\Areas\Admin\Views\_ViewImports.cshtml"
using Finances.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VSprojects\Finances\Areas\Admin\Views\_ViewImports.cshtml"
using Finances.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d84f9526632765a80fc0ed69a6368625f630065", @"/Areas/Admin/Views/Categories/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02f7e692fcb9f7c2ef136678a8b64a5f3e50d39", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Finances.Domain.Entities.Categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>Categories</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 14 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml"
         using (Html.BeginForm("Create", "Categories"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 332, "\"", 351, 1);
#nullable restore
#line 16 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml"
WriteAttributeValue("", 340, ViewBag.Id, 340, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Id\" />\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml"
           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 24 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 27 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml"
   Write(Html.ActionLink("Назад", "Delete", "Categories", new { area = "Admin" }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\VSprojects\Finances\Areas\Admin\Views\Categories\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Finances.Domain.Entities.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591