#pragma checksum "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d965270bf109b578267af404e26f853c30d79ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InfoRekamMedis_Details), @"mvc.1.0.view", @"/Views/InfoRekamMedis/Details.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Rantau\Rantau\Views\_ViewImports.cshtml"
using Rantau;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Rantau\Rantau\Views\_ViewImports.cshtml"
using Rantau.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d965270bf109b578267af404e26f853c30d79ca", @"/Views/InfoRekamMedis/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d7dd76f3626309a0cb611dd30c157c29bcd84a", @"/Views/_ViewImports.cshtml")]
    public class Views_InfoRekamMedis_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rantau.ViewModels.InfoRekamMedisVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <br />\r\n    <h4>Detail Info Rekam Medis</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.NoRekamMedis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.NoRekamMedis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.TanggalPemeriksaan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.TanggalPemeriksaan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.BeratBadan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.BeratBadan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.TinggiBadan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.TinggiBadan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.IndeksMassaTubuh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.IndeksMassaTubuh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.DenyutNadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.DenyutNadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.TekananDarahSistolik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.TekananDarahSistolik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.TekananDarahDiastolik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.TekananDarahDiastolik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.Saturasi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.Saturasi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.JarakUjiJalan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.JarakUjiJalan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.JarakUjiWaktu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.JarakUjiWaktu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.VO2Max));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.VO2Max));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.METs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.METs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.infoRekamMedis.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
       Write(Html.DisplayFor(model => model.infoRekamMedis.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4201, "\"", 4312, 4);
            WriteAttributeValue("", 4211, "showPopupSendMessage(\'", 4211, 22, true);
#nullable restore
#line 112 "C:\Users\user\Desktop\Rantau\Rantau\Views\InfoRekamMedis\Details.cshtml"
WriteAttributeValue("", 4233, Url.Action("Create","HistoriPesan",Model.historiPesan,"https"), 4233, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4296, "\',\'Kirim", 4296, 8, true);
            WriteAttributeValue(" ", 4304, "Pesan\')", 4305, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" style=\"color:white\">Kirim Pesan</a>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d965270bf109b578267af404e26f853c30d79ca14151", async() => {
                WriteLiteral("Kembali");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rantau.ViewModels.InfoRekamMedisVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
