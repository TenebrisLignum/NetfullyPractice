#pragma checksum "D:\VSprojects\Finances\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfd76ce525bfa6e24ba4ad1c59cfb3f7cb664f6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfd76ce525bfa6e24ba4ad1c59cfb3f7cb664f6d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"814a08dba6c4abb914e9feab18ef72cbdf268538", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"textarea\">\r\n    <form id=\"main_form\">\r\n        <p><strong>Додати запис:</strong></p><br>\r\n        <p><input id=\"text\" maxlength=\"25\" size=\"40\"");
            BeginWriteAttribute("value", " value=\"", 154, "\"", 162, 0);
            EndWriteAttribute();
            WriteLiteral(@" required pattern=""\d+(.\d{2})?""></p>
        <p><input type=""button"" onClick=""build();"" value=""Додати""></p>
        <input id=""income"" type=""radio"" value=""income"" checked name=""tech"" />Дохід&nbsp
        <input id=""consumption"" type=""radio"" value=""consumption"" checked name=""tech"" />Витрати
        <select>
            <option>Продукти</option>
            <option>Не продукти</option>
        </select>
    </form>
</div>
<div id=""archive"">
    <table id=""archive_table"">
    </table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
