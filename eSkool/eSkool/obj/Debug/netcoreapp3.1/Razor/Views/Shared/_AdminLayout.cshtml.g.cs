#pragma checksum "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60457c8ed67c66efe678418381a3453dfb3b6318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#line 1 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60457c8ed67c66efe678418381a3453dfb3b6318", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/pp.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60457c8ed67c66efe678418381a3453dfb3b63184889", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60457c8ed67c66efe678418381a3453dfb3b63185155", async() => {
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
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0-12/css/all.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf/0.9.0rc1/jspdf.min.js""></script>
    <style>

        html, body {
            font-family: system-ui;
            height: 100%;
        }

        .outer-div {
            display: flex;
            flex-direction: row;
            height: 100%;
        }

        .main-div {
            margin-left: 23%;
            width: 77%;
            height: 100%;
        }

        .footer p {
            color: #259db2;
            display: flex;
            justify-content: space-between;
        }

        .footer a {
            color: #259db2;
            font-size: large;
        }

        nav {
            padding: 0px;
            border-bottom: 1px solid #edede");
                WriteLiteral(@"d;
        }

        .bar {
            margin: 2px;
            color: white;
            text-align: center;
            padding: 1%;
            background-image: linear-gradient(to right, white,#813870,white);
        }

        .nav-link {
            /*   border-bottom: groove;
            border-start-end-radius: 2px;*/
            color: #813870;
            margin: 0px 5px;
            padding: 20px;
            /*  border-color: #f7e0e0;
            border-radius: 30px;
            background: #f6e8f9;*/
        }

        .navbar-brand {
            /*   background: #813870;
            color: white;

            padding: 10px;
            border-color: white;*/
            color: #813870;
            padding: 15px;
            margin: 0px;
            /* border-style: groove;
            border-bottom-left-radius: 20px;
            border-top-right-radius: 20px;*/
        }

        #profile-card {
            margin-top: 30%;
            padding: 0;
       ");
                WriteLiteral(@"     text-align: center;
            font-size: large;
            display: flex;
            align-items: center;
            flex-direction: column;
        }

        #announcement p {
            color: red;
        }

        #profile-card p {
            font-style: italic;
            margin-top: 10px;
        }

        #announcement {
            background-color: #f5dede;
            padding: 10px;
            text-align: center;
            width: 30%;
        }

        .side-bar {
            /* background-color: #7e0404;*/
            /* background-image: linear-gradient(to bottom right,#476585,#a342c3, #ce67d5, #cb88b9,#cf6fa4,#c5387f, #c10050);
             */
            background-image: linear-gradient(to bottom,#20a3b9,#4a7485,#885595, #9d3b7e, #7a072d);
            /* background-image: linear-gradient(to bottom,#03788b,#414f95,#885595, #9d3b7e, #7a072d);
         */ color: floralwhite;
            /* height: 100%;*/
            width: 23%;
            font-");
                WriteLiteral(@"size: 15px;
            position: fixed;
            overflow-x: hidden;
            z-index: 1;
            top: 0;
            left: 0;
        }

        .func-div {
            margin: 2%;
        }

        #profile-card img {
            width: 35%;
            height: 35%;
            margin: 10px;
        }


        .side-links {
            margin-top: 10px;
            display: flex;
            padding: 5px;
            flex-direction: column;
            text-align: center;
            color: floralwhite;
        }

            .side-links a {
                margin: 5px 35px;
                padding: 10px;
                border-bottom: groove;
                border-color: #ecc0da;
                display: flex;
                flex-direction: column;
                color: floralwhite;
            }

        #logout {
            margin: 25%;
            border-style: outset;
            border-radius: 60px;
            border-color: #ecc0da;
        ");
                WriteLiteral(@"}
        /*.bg {*/
        /*background-image: linear-gradient(to bottom, #20a3b9, #4a7485, #885595, #9d3b7e, #7a072d);
         */ /*height: 100%;
                    -webkit-filter: blur(5px);
                    background-position: center;
                    background-repeat: no-repeat;
                    background-size: cover;
                }*/
        .nav-item:hover {
            text-decoration: none;
            background-color: rgb(226 209 222);
            color: white;
        }

        .nav-item {
            background-color: #ddbed640;
            font-size:15px;
        }

        .navbar a:hover {
            color: white;
        }

        .footer {
            bottom: 0;
            margin: 1% 2%;
        }

        .side-links a:hover {
            text-decoration: none;
            background-color: #f6e8f9d9;
            color: rgb(129 56 112);
        }
    </style>


");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60457c8ed67c66efe678418381a3453dfb3b631812241", async() => {
                WriteLiteral("\r\n    <div class=\"outer-div\">\r\n        <div class=\"side-bar\">\r\n");
                WriteLiteral("            <div id=\"profile-card\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60457c8ed67c66efe678418381a3453dfb3b631812661", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <p>
                    Maira Malik <br />
                    BSEF18A509<br />
                </p>
            </div>
            <div class=""side-links"">
                <a href=""#"">Manage Profile</a>
                <a href=""#"">Settings</a>
                <a href=""#"">Chat</a>
                <a id=""logout"" href=""#"">Logout</a>
            </div>



        </div>
        <div class=""main-div"">
            <nav class=""navbar navbar-expand-sm "" style=""justify-content: space-between;padding: 0px; "">
                <!-- Brand -->
                <p class=""navbar-brand"" href=""/admin/adminDashboard""> Eskool ");
                WriteLiteral(@" </p>

                <!-- Links -->
                <ul class=""navbar-nav"" style="" color: #7e0404; justify-content: flex-end; "">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/adminDashboard"">Dashboard  </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/addClass"">Add Class</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/addTeacher"">Add Teacher</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/addStudent"">Add Student</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/showClasses"">Show Classes</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/showTea");
                WriteLiteral(@"chers"">Show teachers</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/showStudents"">Show students</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/admin/questionNotification"">Question notifications</a>
                    </li>
                </ul>
            </nav>
");
                WriteLiteral("\r\n            <div class=\"func-div\">\r\n                ");
#nullable restore
#line 253 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Shared\_AdminLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div class=""footer"">
                <p>
                    <i class=""fa fa-phone"" style=""color: #954587; font-size: x-large;"">  <a href=""tel:+090078601""> tel: 090078601 </a> </i>
                    <i class=""fa fa-envelope"" style=""color: #954587; font-size: x-large;""> <a href=""mailto:eskooleims@gmail.com"">eims@eskool.com </a>  </i>
                </p>
            </div>
        </div>

    </div>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60457c8ed67c66efe678418381a3453dfb3b631816779", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 264 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Shared\_AdminLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 266 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Shared\_AdminLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
