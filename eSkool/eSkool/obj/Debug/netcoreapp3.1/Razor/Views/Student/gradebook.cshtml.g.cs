#pragma checksum "F:\ESkool\eSkool\eSkool\Views\Student\gradebook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f931ed09fdb1689bc289699962b93878a8744300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_gradebook), @"mvc.1.0.view", @"/Views/Student/gradebook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f931ed09fdb1689bc289699962b93878a8744300", @"/Views/Student/gradebook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_gradebook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\ESkool\eSkool\eSkool\Views\Student\gradebook.cshtml"
  
    ViewBag.Title = "gradebook";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>


    #attendance-sheet {
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

    #absent {
        color: red;
    }

    th {
        background-color: #338da1;
        color: #f6eff5;
    }

    #attendance-sheet h1 {
        color: #c1becd;
        text-shadow: 2px 2px #954587;
    }

    #attendance-sheet h3 {
        color: #c1becd;
        text-shadow: 1px 1px #954587;
    }
</style>

<div id=""attendance-sheet"">

    <h1>Result Sheet</h1>

    <table>
        <tbody>
            <tr>
                <th>Type</th>
                <th>Total Marks</th>
                <th>Obtained Marks</th>
          ");
            WriteLiteral(@"      <th>Percentage</th>
            </tr>
            <tr>
                <td>Quiz 1</td>
                <td>50</td>
                <td>40</td>
                <td>85%</td>
            </tr>
            <tr>
                <td>Total </td>
                <td>1</td>
                <td>0</td>
                <td>0</td>
            </tr>
        </tbody>
    </table>

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
