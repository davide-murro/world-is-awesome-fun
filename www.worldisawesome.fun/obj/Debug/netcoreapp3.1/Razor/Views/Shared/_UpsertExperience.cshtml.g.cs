#pragma checksum "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "050525581d0acb9dee6279d38110ae15fe386c5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UpsertExperience), @"mvc.1.0.view", @"/Views/Shared/_UpsertExperience.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"050525581d0acb9dee6279d38110ae15fe386c5a", @"/Views/Shared/_UpsertExperience.cshtml")]
    public class Views_Shared__UpsertExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"input-container\" id=\"experience-name-container\">\r\n    <label for=\"experience-name\" class=\"label\" style=\"font-size: 1em;\">Name*</label>\r\n    <input type=\"text\" placeholder=\"Name of your experience!\"");
            BeginWriteAttribute("value", " value=\"", 209, "\"", 269, 1);
#nullable restore
#line 3 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 217,  ViewBag.IsUpdate ? ViewBag.Experience.Name : "" , 217, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""experience-name"" class=""input"" style=""font-size: 1.2em;"" autocomplete=""off"" required autofocus/>
</div>
<div class=""input-container mdi-container"" id=""experience-media-container"">
    <div class=""d-flex"">
        <label for=""experience-media"" class=""label flex-auto"">Media*</label>
        <a title=""Remove media"" onclick=""removeExperienceMedia()"" id=""experience-media-remove-button""");
            BeginWriteAttribute("class", " class=\"", 663, "\"", 733, 1);
#nullable restore
#line 8 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 671,  ViewBag.IsUpdate && ViewBag.IsSetMediaFile ? "" : "d-none", 671, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove media</a>\r\n    </div>\r\n\r\n    <div id=\"experience-media-file-container\">\r\n");
#nullable restore
#line 12 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
         if (ViewBag.IsUpdate && ViewBag.IsSetMediaFile)
        {
            if (ViewBag.Experience.FileType.StartsWith("image/"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 986, "\"", 1011, 1);
#nullable restore
#line 16 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 992, ViewBag.FileStream, 992, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"experience media\" onerror=\"onMediaError(this.parentElement)\" id=\"experience-media-img\" class=\"mdi-filecontainer\" onclick=\"document.getElementById(\'experience-media\').click()\" />\r\n");
#nullable restore
#line 17 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
            }
            else if (ViewBag.Experience.FileType.StartsWith("video/"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <video");
            BeginWriteAttribute("src", " src=\"", 1321, "\"", 1346, 1);
#nullable restore
#line 20 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 1327, ViewBag.FileStream, 1327, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" controls onerror=\"onMediaError(this.parentElement)\" id=\"experience-media-video\"></video>\r\n");
#nullable restore
#line 21 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
            }
            else if (ViewBag.Experience.FileType.StartsWith("audio/"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <audio");
            BeginWriteAttribute("src", " src=\"", 1562, "\"", 1587, 1);
#nullable restore
#line 24 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 1568, ViewBag.FileStream, 1568, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" controls onerror=\"onMediaError(this.parentElement)\" id=\"experience-media-audio\"></audio>\r\n");
#nullable restore
#line 25 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img src=\"/images/icons/media_default.svg\" alt=\"experience media\" onerror=\"onMediaError(this.parentElement)\" id=\"experience-media-img\" class=\"mdi-filecontainer\" onclick=\"document.getElementById(\'experience-media\').click()\" />\r\n");
#nullable restore
#line 30 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <small id=""experience-media-error"" class=""error-color d-block""></small>
    <small class=""hint t-right"">Max size: 20MB</small>

    <input type=""file"" placeholder=""Media"" id=""experience-media"" class=""input d-none mdi-fileinput""
           accept=""audio/*,video/*,image/*"" enctype=""multipart/form-data""
           onchange=""experienceMediaChange(this)"" />
</div>
<div class=""input-container"" id=""experience-description-container"">
    <label for=""experience-description"" class=""label"">Description*</label>
    <textarea placeholder=""Give a very good description to your experience! Describe the moment, the location, the entire day and how it was... Remember that you will read it in the future, maybe, with a little melancholy!""
              id=""experience-description"" class=""input"" rows=""5"" style=""resize: vertical;"" autocomplete=""off""
              required>");
#nullable restore
#line 43 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
                   Write(ViewBag.IsUpdate ? ViewBag.Experience.Description : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n</div>\r\n<div class=\"input-container\" id=\"experience-date-container\">\r\n    <label for=\"experience-date\" class=\"label\">Date*</label>\r\n    <input type=\"date\" placeholder=\"Date of experience\"");
            BeginWriteAttribute("value", " value=\"", 3127, "\"", 3221, 1);
#nullable restore
#line 47 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 3135,  ViewBag.IsUpdate ? ViewBag.Experience.Date : @DateTime.Now.ToString("yyyy-MM-dd") , 3135, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"experience-date\" class=\"input\" required />\r\n</div>\r\n<div class=\"input-container\" id=\"experience-time-container\">\r\n    <label for=\"experience-time\" class=\"label\">Time</label>\r\n    <input type=\"time\" placeholder=\"Time of experience\"");
            BeginWriteAttribute("value", " value=\"", 3457, "\"", 3517, 1);
#nullable restore
#line 51 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 3465,  ViewBag.IsUpdate ? ViewBag.Experience.Time : "" , 3465, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"experience-time\" class=\"input\" />\r\n</div>\r\n<div class=\"input-container\" id=\"morningnight-enum-radio-container\">\r\n    <label for=\"experience-morningnight-enum\" class=\"label\">Daytime*</label>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 3724, "\"", 4066, 2);
            WriteAttributeValue("", 3732, "morningnight-enum-radio", 3732, 23, true);
#nullable restore
#line 56 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue(" ", 3755,  (ViewBag.IsUpdate && ViewBag.IsSetMorningNight && ViewBag.Experience.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Morning) || (!ViewBag.IsUpdate && ViewBag.MorningNightEnum != null && ViewBag.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Morning) ? "active" : "" , 3756, 310, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"radio\" name=\"experience-morningnight-enum\"\r\n               id=\"experience-morningnight-enum-morning\" value=\"1\"\r\n               onchange=\"selectMorningnightRadio(this)\" required ");
#nullable restore
#line 59 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
                                                             Write( (ViewBag.IsUpdate && ViewBag.IsSetMorningNight && ViewBag.Experience.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Morning) || (!ViewBag.IsUpdate && ViewBag.MorningNightEnum != null && ViewBag.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Morning) ? "checked" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n        <label for=\"experience-morningnight-enum-morning\">\r\n            <img src=\"/images/icons/sun.svg\" alt=\"sun\" title=\"Morning\" />\r\n            Morning\r\n        </label>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 4778, "\"", 5116, 2);
            WriteAttributeValue("", 4786, "morningnight-enum-radio", 4786, 23, true);
#nullable restore
#line 65 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue(" ", 4809,  (ViewBag.IsUpdate && ViewBag.IsSetMorningNight && ViewBag.Experience.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Night) || (!ViewBag.IsUpdate && ViewBag.MorningNightEnum != null && ViewBag.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Night) ? "active" : "" , 4810, 306, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"radio\" name=\"experience-morningnight-enum\"\r\n               id=\"experience-morningnight-enum-night\" value=\"2\"\r\n               onchange=\"selectMorningnightRadio(this)\" required ");
#nullable restore
#line 68 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
                                                             Write( (ViewBag.IsUpdate && ViewBag.IsSetMorningNight && ViewBag.Experience.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Night) || (!ViewBag.IsUpdate && ViewBag.MorningNightEnum != null && ViewBag.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Night) ? "checked" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n        <label for=\"experience-morningnight-enum-night\">\r\n            <img src=\"/images/icons/star.svg\" alt=\"star\" title=\"Night\" />\r\n            Night\r\n        </label>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 5818, "\"", 6160, 2);
            WriteAttributeValue("", 5826, "morningnight-enum-radio", 5826, 23, true);
#nullable restore
#line 74 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue(" ", 5849,  (ViewBag.IsUpdate && ViewBag.IsSetMorningNight && ViewBag.Experience.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Evening) || (!ViewBag.IsUpdate && ViewBag.MorningNightEnum != null && ViewBag.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Evening) ? "active" : "" , 5850, 310, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"radio\" name=\"experience-morningnight-enum\"\r\n               id=\"experience-morningnight-enum-evening\" value=\"3\"\r\n               onchange=\"selectMorningnightRadio(this)\" required ");
#nullable restore
#line 77 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
                                                             Write( (ViewBag.IsUpdate && ViewBag.IsSetMorningNight && ViewBag.Experience.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Evening) || (!ViewBag.IsUpdate && ViewBag.MorningNightEnum != null && ViewBag.MorningNightEnum == www.worldisawesome.fun.Models.MorningNightEnum.Evening) ? "checked" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(@" />
        <label for=""experience-morningnight-enum-evening"">
            <img src=""/images/icons/sunset.svg"" alt=""sunset"" title=""Evening"" />
            Evening
        </label>
    </div>
</div>
<div class=""input-container"" id=""experience-place-container"">
    <div class=""d-flex"">
        <label for=""experience-place"" class=""label flex-auto"">Place*</label>
        <a title=""Remove place"" onclick=""removeExperiencePlace()"" id=""experience-place-remove-button""");
            BeginWriteAttribute("class", "\r\n           class=\"", 7146, "\"", 7219, 2);
            WriteAttributeValue("", 7166, "remove-button", 7166, 13, true);
#nullable restore
#line 88 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue(" ", 7179,  ViewBag.IsSetPlace ? "" : "d-none" , 7180, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove place</a>\r\n    </div>\r\n    <input type=\"search\" placeholder=\"Place where you were\"");
            BeginWriteAttribute("value", " value=\"", 7310, "\"", 7377, 1);
#nullable restore
#line 90 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue("", 7318,  ViewBag.IsSetPlace ? ViewBag.Experience.PlaceName : "" , 7318, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""experience-place"" class=""input""
           autocomplete=""off"" />
    <div class=""search-results-container"" id=""experience-place-search-results-container""></div>
</div>
<div class=""input-container"" id=""privacylevel-radio-container"">
    <label for=""experience-privacylevel"" class=""label"">Privacy level (visibility)*</label>

    <div");
            BeginWriteAttribute("class", " class=\"", 7722, "\"", 7922, 3);
            WriteAttributeValue("", 7730, "privacylevel-radio", 7730, 18, true);
            WriteAttributeValue(" ", 7748, "d-inline-block", 7749, 15, true);
#nullable restore
#line 97 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue(" ", 7763,  ViewBag.IsUpdate && ViewBag.IsSetPrivacyLevel && ViewBag.Experience.PrivacyLevel == www.worldisawesome.fun.Models.PrivacyLevelEnum.Public ? "active" : "" , 7764, 158, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"radio\" name=\"experience-privacylevel\"\r\n               id=\"experience-privacylevel-public\" value=\"1\"\r\n               onchange=\"selectPrivacylevelRadio(this)\" required ");
#nullable restore
#line 100 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
                                                             Write( ViewBag.IsUpdate && ViewBag.IsSetPrivacyLevel && ViewBag.Experience.PrivacyLevel == www.worldisawesome.fun.Models.PrivacyLevelEnum.Public ? "checked" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral("/>\r\n        <label for=\"experience-privacylevel-public\" class=\"privacylevel-tag\">\r\n            Public\r\n        </label>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 8413, "\"", 8619, 3);
            WriteAttributeValue("", 8421, "privacylevel-radio", 8421, 18, true);
            WriteAttributeValue(" ", 8439, "d-inline-block", 8440, 15, true);
#nullable restore
#line 105 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue(" ", 8454,  ViewBag.IsUpdate && ViewBag.IsSetPrivacyLevel && ViewBag.Experience.PrivacyLevel == www.worldisawesome.fun.Models.PrivacyLevelEnum.Confidential ? "active" : "" , 8455, 164, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"radio\" name=\"experience-privacylevel\"\r\n               id=\"experience-privacylevel-confidential\" value=\"2\"\r\n               onchange=\"selectPrivacylevelRadio(this)\" required ");
#nullable restore
#line 108 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
                                                             Write( ViewBag.IsUpdate && ViewBag.IsSetPrivacyLevel && ViewBag.Experience.PrivacyLevel == www.worldisawesome.fun.Models.PrivacyLevelEnum.Confidential ? "checked" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n        <label for=\"experience-privacylevel-confidential\" class=\"privacylevel-tag\">\r\n            Only Friends\r\n        </label>\r\n    </div>\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 9135, "\"", 9336, 3);
            WriteAttributeValue("", 9143, "privacylevel-radio", 9143, 18, true);
            WriteAttributeValue(" ", 9161, "d-inline-block", 9162, 15, true);
#nullable restore
#line 113 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
WriteAttributeValue(" ", 9176,  ViewBag.IsUpdate && ViewBag.IsSetPrivacyLevel && ViewBag.Experience.PrivacyLevel == www.worldisawesome.fun.Models.PrivacyLevelEnum.Private ? "active" : "" , 9177, 159, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <input type=\"radio\" name=\"experience-privacylevel\"\r\n               id=\"experience-privacylevel-private\" value=\"3\"\r\n               onchange=\"selectPrivacylevelRadio(this)\" required ");
#nullable restore
#line 116 "C:\Users\Betacom\Documents\GitHub\World is Awesome .fun\WiA\.Net application\www.worldisawesome.fun\Views\Shared\_UpsertExperience.cshtml"
                                                             Write( ViewBag.IsUpdate && ViewBag.IsSetPrivacyLevel && ViewBag.Experience.PrivacyLevel == www.worldisawesome.fun.Models.PrivacyLevelEnum.Private ? "checked" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n        <label for=\"experience-privacylevel-private\" class=\"privacylevel-tag\">\r\n            Private\r\n        </label>\r\n    </div>\r\n</div>");
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
