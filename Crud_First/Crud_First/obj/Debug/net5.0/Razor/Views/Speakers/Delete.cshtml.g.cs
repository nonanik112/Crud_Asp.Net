#pragma checksum "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "273c772e8787e2c70f9b42acbf4360eb86291a2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Speakers_Delete), @"mvc.1.0.view", @"/Views/Speakers/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273c772e8787e2c70f9b42acbf4360eb86291a2c", @"/Views/Speakers/Delete.cshtml")]
    public class Views_Speakers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crud_First.Models.Speaker>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Speaker</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpeakerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpeakerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpeakTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpeakTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Venue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Venue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProfilePicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Metehan\Desktop\Crud\Crud_First\Crud_First\Views\Speakers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProfilePicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
