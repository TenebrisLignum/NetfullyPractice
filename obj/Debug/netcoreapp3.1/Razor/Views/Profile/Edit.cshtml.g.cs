#pragma checksum "D:\VSprojects\Finances\Views\Profile\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11fb55b77364c385120dda59a0a8efdd1f0e62af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Edit), @"mvc.1.0.view", @"/Views/Profile/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11fb55b77364c385120dda59a0a8efdd1f0e62af", @"/Views/Profile/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f87752b1146bdd975aad3dec6c1fa22a4bcb00d", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Finances.Domain.Entities.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadPicture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Редагувати інформацію</h1>\r\n\r\n<h4>Інформація</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11fb55b77364c385120dda59a0a8efdd1f0e62af4463", async() => {
                WriteLiteral("\r\n        <p>\r\n            Аватар<br />\r\n            <input name=\"Avatar\" type=\"file\" class=\"form-control\" />\r\n            <input type=\"submit\" value=\"Додати\" />\r\n        </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(">\r\n");
#nullable restore
#line 20 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
     using (Html.BeginForm("Edit", "Profile"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset>\r\n            <legend> Редагування </legend>\r\n            <p>\r\n                Нікнейм: <br />\r\n                ");
#nullable restore
#line 26 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
           Write(Html.EditorFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p>\r\n                Ім\'я: <br />\r\n                ");
#nullable restore
#line 31 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
           Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p>\r\n                Фамілія: <br />\r\n                ");
#nullable restore
#line 36 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
           Write(Html.EditorFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p>\r\n                Email: <br />\r\n                ");
#nullable restore
#line 41 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
           Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p>\r\n                Дата народження: <br />\r\n                ");
#nullable restore
#line 46 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
           Write(Html.EditorFor(model => model.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p>\r\n                Номер телефону: <br />\r\n                ");
#nullable restore
#line 51 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
           Write(Html.EditorFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n            <p>\r\n                <input type=\"submit\" value=\"Змінити\" />\r\n            </p>\r\n\r\n        </fieldset>\r\n");
#nullable restore
#line 59 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 61 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
   Write(Html.ActionLink("Назад", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "D:\VSprojects\Finances\Views\Profile\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Finances.Domain.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
