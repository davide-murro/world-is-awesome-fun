#pragma checksum "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf572272c3a9201e5e6773ce345e3e5d9b12800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Places), @"mvc.1.0.view", @"/Views/Search/Places.cshtml")]
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
#line 2 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
using www.worldisawesome.fun;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf572272c3a9201e5e6773ce345e3e5d9b12800", @"/Views/Search/Places.cshtml")]
    public class Views_Search_Places : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font_nunito/Nunito.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_material.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script_vars.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script_apicall.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script_search_places.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
                                  

    if (ViewBag.IsUserSet)
    {
        ViewBag.PictureStream_Preview = Context.Request.Scheme + "://" + Context.Request.Host + Url.Action("GetUserPictureStream", "View", new { pictureId = ViewBag.User.ProfilePhotoFileId, isPreview = true });
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf572272c3a9201e5e6773ce345e3e5d9b128006500", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
       await Html.RenderPartialAsync("_HeadBase"); 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <title>Search places | World is Awesome .fun</title>

    <meta name=""description"" content=""Search places in World is Awesome .fun, WiA"" />
    <meta name=""keywords""
          content=""World is Awesome, World is Awesome .fun, World, Awesome, fun, wia, wia.fun, wia fun, experience, Diary, Travel, Trip, traveller, photo, video, search, places, place, city, country"">


    <!-- external -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aaf572272c3a9201e5e6773ce345e3e5d9b128007448", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- internal -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aaf572272c3a9201e5e6773ce345e3e5d9b128008656", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aaf572272c3a9201e5e6773ce345e3e5d9b128009835", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf572272c3a9201e5e6773ce345e3e5d9b1280011018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf572272c3a9201e5e6773ce345e3e5d9b1280012205", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf572272c3a9201e5e6773ce345e3e5d9b1280013392", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf572272c3a9201e5e6773ce345e3e5d9b1280015287", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
       await Html.RenderPartialAsync("_Base"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 38 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
       await Html.RenderPartialAsync("_Header"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"article-container\" id=\"places-search-list-popup\">\r\n\r\n        <div class=\"article\">\r\n");
#nullable restore
#line 44 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
             if (ViewBag.IsUserSet)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"profile-selected-container\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1703, "\"", 1744, 2);
                WriteAttributeValue("", 1710, "/View/User?UserId=", 1710, 18, true);
#nullable restore
#line 47 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
WriteAttributeValue("", 1728, ViewBag.User.Id, 1728, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"Profile picture\" id=\"userselected-button\" class=\"profile-selected\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1850, "\"", 1886, 1);
#nullable restore
#line 48 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
WriteAttributeValue("", 1856, ViewBag.PictureStream_Preview, 1856, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onerror=\"this.src=\'/images/icons/user_avatar_default.svg\'\" class=\"icon\"\r\n                             alt=\"profile picture\" />\r\n                        <h3 class=\"text\">");
#nullable restore
#line 50 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
                                    Write(ViewBag.User.Nickname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"article-header d-flex align-items\">\r\n                <img src=\"/images/icons/place_search.svg\" class=\"article-icon\" alt=\"search places\" />\r\n                <h2 class=\"article-title flex-auto\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
                Write(ViewBag.IsUserSet ? "Places" : "Global Places");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </h2>
            </div>
            <div class=""article-body"">
                <div class=""search-list-container"">
                    <div class=""input-container search-container"" id=""places-search-container"">
                        <label for=""places-search"" class=""label"">Search</label>
                        <div class=""d-flex align-items"">
                            <input type=""search"" placeholder=""Bogotá, Bogota D.C., Colombia"" id=""places-search""
                                   class=""input"" />

                            <div id=""morningnight-button"" class=""small icon ml-05"" title=""Change daytime"" onclick=""changeMorningNight()""></div>
");
#nullable restore
#line 70 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
                             if (ViewBag.IsUserSet)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div id=\"changetype-button\" class=\"small icon ml-05\" title=\"Change view\" onclick=\"changeView()\"></div>\r\n");
#nullable restore
#line 73 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""t-left"">
                        <b id=""place-count""></b>
                    </div>
                    <div class=""list-container"" id=""places-list-container""></div>
                </div>
            </div>
        </div>
    </div>


");
#nullable restore
#line 86 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
       await Html.RenderPartialAsync("_Footer"); 

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1276, "loading", 1276, 7, true);
#nullable restore
#line 34 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
AddHtmlAttributeValue(" ", 1283, ViewBag.IsUserLogged ? "logged" : "", 1284, 39, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Betacom\Documents\GitHub\world-is-awesome-fun\www.worldisawesome.fun\Views\Search\Places.cshtml"
AddHtmlAttributeValue(" ", 1323, ViewBag.IsMine ? "ismine" : "", 1324, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
