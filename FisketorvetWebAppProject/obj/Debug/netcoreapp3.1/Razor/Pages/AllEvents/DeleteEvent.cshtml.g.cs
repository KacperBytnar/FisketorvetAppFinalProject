#pragma checksum "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cca86e70e5face11fcd76ccded1698204d0c24f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FisketorvetWebAppProject.Pages.AllEvents.Pages_AllEvents_DeleteEvent), @"mvc.1.0.razor-page", @"/Pages/AllEvents/DeleteEvent.cshtml")]
namespace FisketorvetWebAppProject.Pages.AllEvents
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
#line 1 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\_ViewImports.cshtml"
using FisketorvetWebAppProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cca86e70e5face11fcd76ccded1698204d0c24f", @"/Pages/AllEvents/DeleteEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4157e8560287d99002cff277c60cc165b63049", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AllEvents_DeleteEvent : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml"
   ViewData["Title"] = "Delete Event"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete Event</h1>\n<h3>Are you sure you want to delete this Event</h3>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cca86e70e5face11fcd76ccded1698204d0c24f3905", async() => {
                WriteLiteral("\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 11 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml"
           Write(Html.DisplayNameFor(model => model.Events.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 14 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml"
           Write(Html.DisplayFor(model => model.Events.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 17 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml"
           Write(Html.DisplayNameFor(model => model.Events.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 20 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml"
           Write(Html.DisplayFor(model => model.Events.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 23 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml"
           Write(Html.DisplayNameFor(model => model.Events.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\FisketorvetWebAppProject\FisketorvetWebAppProject\Pages\AllEvents\DeleteEvent.cshtml"
           Write(Html.DisplayFor(model => model.Events.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </dd>\n        </dl>\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\n    ");
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
            WriteLiteral("\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FisketorvetWebAppProject.AllEvents.DeleteEventModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FisketorvetWebAppProject.AllEvents.DeleteEventModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FisketorvetWebAppProject.AllEvents.DeleteEventModel>)PageContext?.ViewData;
        public FisketorvetWebAppProject.AllEvents.DeleteEventModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
