#pragma checksum "F:\ESkool\eSkool\eSkool\Views\Student\class_announcement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "942a46099ae8d533fb3f4bc45c0311aa18e1e8cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_class_announcement), @"mvc.1.0.view", @"/Views/Student/class_announcement.cshtml")]
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
#line 1 "F:\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942a46099ae8d533fb3f4bc45c0311aa18e1e8cd", @"/Views/Student/class_announcement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_class_announcement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/profilepic.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\ESkool\eSkool\eSkool\Views\Student\class_announcement.cshtml"
  
    ViewBag.Title = "class_announcement";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>


    .sub-div {
        background-color: #f9e9f3;
        display: flex;
        flex-direction: row;
        margin: 10px;
        width: 25%;
        height: 50%;
    }


    

    .image-card {
        width: 20%;
        padding: 2px;
        height: 100%;
        text-align: center;
    }

        .image-card img {
            width: 100%;
            height: 100%;
        }

    .post {
        display: flex;
        flex-direction: row;
    }

    .post-card {
        margin: 8px;
       
        height: 8%;
        padding: 0;
        display: flex;
        flex-direction: column;
    }

        .post-card p {
            margin: 0;
        }

    .post-details {
        padding: 10px;
        width: 60%;
        margin: 10px;
        background-color: #f9e9f3;
    }
</style>


    <div class=""post"">
        <div class=""sub-div"">
            <div class=""image-card"">
                <i class=""far fa-user""></i>
            </div>
   ");
            WriteLiteral(@"         <div class=""post-card"">
                <p > Ali Iftikhar </p>
                <p style=""font-style: italic; color:#8080809c;""> Dec 3, 2021</p>
            </div>

        </div>
        <div class=""post-details"">
            <h3>Slides 3</h3>
            <p>Above are the slides of first lecture. At the end of slides, there is an assignmnet which you need to submit in next lecture.</p>
        </div>
    </div>
    <div class=""post"">
        <div class=""sub-div"">
            <div class=""image-card"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "942a46099ae8d533fb3f4bc45c0311aa18e1e8cd5291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""post-card"">
                <p style=""font-weight:bold;""> Ali Iftikhar </p>
                <p style=""font-style:italic; color:grey;""> Dec 2, 2021</p>
            </div>

        </div>
        <div class=""post-details"">
            <h3>Slides 2</h3>
            <p>Above are the slides of first lecture. At the end of slides, there is an assignmnet which you need to submit in next lecture.</p>
        </div>
    </div>
    <div class=""post"">
        <div class=""sub-div"">
            <div class=""image-card"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "942a46099ae8d533fb3f4bc45c0311aa18e1e8cd6920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""post-card"">
                <p style=""font-weight:bold;""> Ali Iftikhar </p>
                <p style=""font-style:italic; color:grey;""> Dec 1, 2021</p>
            </div>

        </div>
        <div class=""post-details"">
            <h3>Slides 1</h3>
            <p>Above are the slides of first lecture. At the end of slides, there is an assignmnet which you need to submit in next lecture.</p>
        </div>
    </div>
");
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
