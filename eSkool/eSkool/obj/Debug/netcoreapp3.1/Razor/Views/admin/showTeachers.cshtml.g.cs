#pragma checksum "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\showTeachers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b849ba79c04ad03d98a04131d10f460255d28b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_admin_showTeachers), @"mvc.1.0.view", @"/Views/admin/showTeachers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b849ba79c04ad03d98a04131d10f460255d28b4", @"/Views/admin/showTeachers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_admin_showTeachers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eSkool.Models.Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\showTeachers.cshtml"
  
    ViewData["Title"] = "showTeachers";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>


    #teachers {
        margin-top: 5%;
        background-color: #f6eff5;
        text-align: center;
        padding: 5px;
        padding-bottom: 2%
    }

    table, th, td {
        text-align: center;
        margin: auto;
        border: 1px solid #f6eff5;
        border-collapse: collapse;
    }

    th, td {
        padding: 10px 30px;
        background-color: #338da13d;
        color: #267385;
    }



    th {
        background-color: #338da1;
        color: #f6eff5;
    }

    #attendance-sheet h1 {
        color: #ffffff;
        text-shadow: 2px 2px #954587;
    }

    #attendance-sheet h3 {
        color: #75b1c6;
        text-shadow: 1px -1px #ffffff;
    }
</style>

<h1>Teachers List</h1>

<p class=""float-right"">
    <a href=""#"" class=""btn btn-outline-primary"">Create New</a>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 59 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\showTeachers.cshtml"
           Write(Html.DisplayNameFor(model => model.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\showTeachers.cshtml"
           Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 66 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\showTeachers.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\showTeachers.cshtml"
           Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>Edit/Delete</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Ali u Ali u Ali</td>
            <td>Assistant Professor</td>
            <td>M.Phil(CS)</td>
            <td>3 years</td>
            <td>
                <a href=""#"" class=""btn btn-success"">Edit</a>
                <a href=""#"" class=""btn btn-danger"">Delete</a>
            </td>
        </tr>
");
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eSkool.Models.Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591