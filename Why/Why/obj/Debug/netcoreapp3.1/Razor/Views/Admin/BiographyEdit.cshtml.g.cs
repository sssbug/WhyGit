#pragma checksum "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "007e8006f6612cc693bfc7ff28edd723140675d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BiographyEdit), @"mvc.1.0.view", @"/Views/Admin/BiographyEdit.cshtml")]
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
#line 1 "E:\GitHub\WhyGit\Why\Why\Views\_ViewImports.cshtml"
using Why;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\WhyGit\Why\Why\Views\_ViewImports.cshtml"
using Why.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml"
using Why.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007e8006f6612cc693bfc7ff28edd723140675d3", @"/Views/Admin/BiographyEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86890f158a3ad25a31c6e6e723c3db84a2fee873", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_BiographyEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Biography>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml"
  
    ViewData["Title"] = "BiographyEdit";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>BiographyEdit</h1>\r\n\r\n<div style=\"border:1px #e8e8e8 solid;margin:0px 0px 10px 0px;\">\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "007e8006f6612cc693bfc7ff28edd723140675d34001", async() => {
                WriteLiteral("\r\n        <input  type=\"hidden\" name=\"ThumbsId\"");
                BeginWriteAttribute("value", " value=\"", 307, "\"", 330, 1);
#nullable restore
#line 13 "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml"
WriteAttributeValue("", 315, Model.ThumbsId, 315, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 331, "\"", 342, 0);
                EndWriteAttribute();
                WriteLiteral(@">

        <div style=""border-bottom:1px #e8e8e8 solid;
					background-color:#f3f3f3;padding:8px;
					font-size:13px;font-weight:700;color:#45484d;"">
            Biograpfy 
        </div>
        <div style=""padding:8px;font-size:13px;"" >
            <textarea style=""width:100%;"" name=""BiographyContent"" >
");
#nullable restore
#line 22 "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml"
               Write(Model.BiographyContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml"
                                           
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                \r\n            </textarea>\r\n        </div>\r\n        <h6>");
#nullable restore
#line 29 "E:\GitHub\WhyGit\Why\Why\Views\Admin\BiographyEdit.cshtml"
       Write(ViewBag.bioId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n        <div class=\"user-box\">\r\n            <input class=\"btn btn-primary\" type=\"submit\" value=\"Save\" name=\"submit\">\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Biography> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
