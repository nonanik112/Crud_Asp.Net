#pragma checksum "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0b00df22c489937d418f58aa5276eea109a2dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Speakers_Edit), @"mvc.1.0.view", @"/Views/Speakers/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0b00df22c489937d418f58aa5276eea109a2dec", @"/Views/Speakers/Edit.cshtml")]
    public class Views_Speakers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crud_First.Models.Speaker>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Speaker</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""SpeakerName"" class=""control-label""></label>
                <input asp-for=""SpeakerName"" class=""form-control"" />
                <span asp-validation-for=""SpeakerName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Qualification"" class=""control-label""></label>
                <input asp-for=""Qualification"" class=""form-control"" />
                <span asp-validation-for=""Qualification"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SpeakTime"" class=""control-label""></label>
                <input asp-for=""SpeakTime"" class=""form-control"" />
   ");
            WriteLiteral(@"             <span asp-validation-for=""SpeakTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Venue"" class=""control-label""></label>
                <input asp-for=""Venue"" class=""form-control"" />
                <span asp-validation-for=""Venue"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProfilePicture"" class=""control-label""></label>
                <input asp-for=""ProfilePicture"" class=""form-control"" />
                <span asp-validation-for=""ProfilePicture"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crud_First.Models.Speaker> Html { get; private set; }
    }
}
#pragma warning restore 1591
