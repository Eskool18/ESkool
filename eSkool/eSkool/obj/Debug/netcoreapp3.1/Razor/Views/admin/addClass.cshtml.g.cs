#pragma checksum "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c0262646c2baf468efd2ce0c02eaa57bca5b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_admin_addClass), @"mvc.1.0.view", @"/Views/admin/addClass.cshtml")]
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
#line 1 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c0262646c2baf468efd2ce0c02eaa57bca5b3f", @"/Views/admin/addClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_admin_addClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "t1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "s1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "s2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "s3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reg-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/addClass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml"
  
    ViewBag.Title = "addClass";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    form {
        display: flex;
        flex-direction: column;
        padding: 2%;
        margin: 2%;
        /*  border: 2px dashed #954587;     */
        background-color: #f6eff5;
    }
    .tab {
        display: none;
    }
    .step {
        height: 15px;
        width: 15px;
        margin: 0 2px;
        background-color: #bbbbbb;
        border: none;
        border-radius: 50%;
        display: inline-block;
        opacity: 0.5;
    }
        .step.finish {
            background-color: #04AA6D;
        }
        .step.active {
            opacity: 1;
        }
    .dlt-row {
        color: red;
        border: 1px solid #ff0000;
        width: 12%;
        font-weight: bold;
        cursor: pointer;
        background: #ff000014;
    }
    .form-tab input {
        border-color: #22a1b782;
        margin: 1%;
        padding: 1%;
        width: 50%;
    }

    #assign tr {
        border: 1px dashed grey;
        background-color: #457a");
            WriteLiteral(@"8b1f;
    }

    #assign {
        width: 30%;
    }

        #assign tr td {
            padding: 5% 0%;
        }

    h2 {
        text-align: center;
        color: #22a1b782;
    }

    .add-btn input:hover {
        box-shadow: -6px 6px 0px 0 #22a1b782;
        background: rgb(145 74 140 / 45%);
    }

    .add-btn input {
        color: #ffffff;
        width: 100%;
        box-shadow: -6px 6px 0px 0 rgb(145 74 140 / 45%);
        font-size: 18px;
        border: none;
        padding: 3%;
        /* border: 1px solid #7b5c92d9; */
        background: #22a1b782;
    }
    .assign-btn {
        text-align: center;
        background: #75b1c65c;
        border: 2px dashed #269cb2;
        padding: 1%;
 
    }
    .assign-btn i {
        color: #22a0b6;
        font-size: 20px;
    }
    .assign-btn:hover{
        cursor:pointer;
    }
    h3 {
        font-size: 20px;
        text-align: left;
        color: #bfaacf8f;
    }

    .add-btn {
     
     ");
            WriteLiteral(@"   color: #ffffff;
        box-shadow: -6px 6px 0px 0 rgb(145 74 140 / 45%);
        font-size: 18px;
        border: none;
        width: 15%;
        margin: 2% 2%;
        padding: 1%;
        background: #22a1b782;
    }

    .add-btn:hover, .add-btn:focus, .add-btn:visited {
        box-shadow: -6px 6px 0px 0 #22a1b782;
        background: rgb(145 74 140 / 45%);
    }
    

    .form-tab label {
        width: 20%;
        margin: 1%;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c0262646c2baf468efd2ce0c02eaa57bca5b3f8325", async() => {
                WriteLiteral(@"
      <h2>ADD CLASS</h2>
    <div class=""tab"">

        <div class=""form-tab"">
            <label for=""class-name"">Class name </label>
            <input id=""class-name"" oninput=""this.className = ''"" type=""text"" placeholder=""e.g Pre 9th"" />
        </div>
        <div class=""form-tab"">
            <label for=""grade"">Class Grade </label>
            <input id=""grade"" type=""text"" oninput=""this.className = ''"" placeholder=""e.g; 9th"" />
        </div>
        <div class=""form-tab"">
            <label for=""classTeacher-name"">Class Incharge </label>
            <input id=""classTeacher-name"" oninput=""this.className = ''"" type=""text"" placeholder=""e.g; Sir XYZ"" />
        </div>
        <div class=""form-tab"">
            <label for=""strength""> Class Strength </label>
            <input id=""strength"" oninput=""this.className = ''"" type=""text"" placeholder=""e.g; 45"" />
        </div>
    </div>
    
        <div class=""tab"" style=""text-align:center;"">
            <h3>ASSIGN TEACHERS</h3>
         ");
                WriteLiteral("   <div class=\"form-tab\">\r\n                <label for=\"teacher-name\" style=\"margin:5%; width:10%;\">Teacher</label>\r\n                <select id=\"teacher-name\" style=\"padding:1%;\" oninput=\"this.className = \'\'\" ");
                WriteLiteral(">\r\n");
#nullable restore
#line 154 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml"
                      
                        foreach (var Teacher in Model)
                        {
                            if (Teacher.Role == "T")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c0262646c2baf468efd2ce0c02eaa57bca5b3f10359", async() => {
#nullable restore
#line 159 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml"
                                          Write(Teacher.UserName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 160 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    \r\n                </select>\r\n                <label for=\"subject-name\"style=\"margin:2%;width:10%;\">Subject</label>\r\n                <select id=\"subject-name\" style=\"padding:1%;\" oninput=\"this.className = \'\'\"  ");
                WriteLiteral(">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c0262646c2baf468efd2ce0c02eaa57bca5b3f12338", async() => {
                    WriteLiteral("English");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c0262646c2baf468efd2ce0c02eaa57bca5b3f13583", async() => {
                    WriteLiteral("Urdu");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c0262646c2baf468efd2ce0c02eaa57bca5b3f14825", async() => {
                    WriteLiteral("Science");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n                <a onclick=\"assign();\" class=\"assign-btn\">  <i class=\"fa fa-plus\"></i></a>\r\n");
                WriteLiteral(@"                <table id=""assign"">
                    <thead>
                        Assigned:
                    </thead>
                </table>
            </div>
        </div>

        <div class=""tab"">
            <h3>STUDENTS ENROLLED</h3>
            <div class=""form-tab"">
                
                <ul>
");
#nullable restore
#line 188 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml"
                      
                        foreach (var Student in Model)
                        {
                            if (Student.Role == "S")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li id=\"s1\">");
#nullable restore
#line 193 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml"
                                       Write(Student.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 194 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\addClass.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                  
                </ul>

            </div>
        </div>
    <div style=""overflow:auto;"">
    <div style="" text-align: center;"">
      <button type=""button"" class =""add-btn"" id=""prevBtn"" onclick=""nextPrev(-1)"">Previous</button>
      <button type=""button"" class =""add-btn"" id=""nextBtn"" onclick=""nextPrev(1)"">Next</button>
    </div>
  </div>
       
        <div style=""text-align:center;margin-top:40px;"">
            <span class=""step""></span>
            <span class=""step""></span>
            <span class=""step""></span>
        </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
