#pragma checksum "D:\Mio\World is Awesome .fun\Sites\WiA\www.worldisawesome.fun\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97cb110e37d37eb96e213cd083aa7c46feee6be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#line 1 "D:\Mio\World is Awesome .fun\Sites\WiA\www.worldisawesome.fun\Views\Shared\_Footer.cshtml"
using www.worldisawesome.fun;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97cb110e37d37eb96e213cd083aa7c46feee6be5", @"/Views/Shared/_Footer.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<footer>\r\n");
#nullable restore
#line 4 "D:\Mio\World is Awesome .fun\Sites\WiA\www.worldisawesome.fun\Views\Shared\_Footer.cshtml"
     if (Context.Request.Path.Value != "/ContactUs")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/ContactUs\" title=\"Contact us\">Contact us</a>\r\n");
#nullable restore
#line 7 "D:\Mio\World is Awesome .fun\Sites\WiA\www.worldisawesome.fun\Views\Shared\_Footer.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>v. <b id=\"app-version\">");
#nullable restore
#line 8 "D:\Mio\World is Awesome .fun\Sites\WiA\www.worldisawesome.fun\Views\Shared\_Footer.cshtml"
                           Write(AppService.Version);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n</footer>");
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
