#pragma checksum "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\AddEmp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cfc38fb125c0b2c6ace0d1dd65453c1cd5d7421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AddEmp), @"mvc.1.0.razor-page", @"/Pages/AddEmp.cshtml")]
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
#line 2 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\AddEmp.cshtml"
using BlazorEmpwage.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/AddEmp")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfc38fb125c0b2c6ace0d1dd65453c1cd5d7421", @"/Pages/AddEmp.cshtml")]
    public class Pages_AddEmp : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<h1>Create</h1>
<h3>Employee</h3>

<div class=""row"">
    <div class=""col-md-4"">
        <form>
            <div class=""form-group"">
                <label for=""Name"" class=""control-label"">Name</label>
                <input for=""Name"" class=""form-control""");
            BeginWriteAttribute("bind", " bind=\"", 301, "\"", 317, 1);
#nullable restore
#line 15 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\AddEmp.cshtml"
WriteAttributeValue("", 308, emp.Name, 308, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"form-group\">\n                <label asp-for=\"Gender\" class=\"control-label\">Gender</label>\n                <select asp-for=\"Gender\" class=\"form-control\"");
            BeginWriteAttribute("bind", " bind=\"", 516, "\"", 534, 1);
#nullable restore
#line 19 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\AddEmp.cshtml"
WriteAttributeValue("", 523, emp.Gender, 523, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <option");
            BeginWriteAttribute("value", " value=\"", 564, "\"", 572, 0);
            EndWriteAttribute();
            WriteLiteral(@">-- Select Gender --</option>
                    <option value=""Male"">Male</option>
                    <option value=""Female"">Female</option>
                </select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Department"" class=""control-label"">Department</label>
                <input asp-for=""Department"" class=""form-control""");
            BeginWriteAttribute("bind", " bind=\"", 948, "\"", 970, 1);
#nullable restore
#line 27 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\AddEmp.cshtml"
WriteAttributeValue("", 955, emp.Department, 955, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n\n            <div class=\"form-group\">\n                <button type=\"submit\" class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1093, "\"", 1103, 0);
            EndWriteAttribute();
            WriteLiteral(">Save</button>\n                <button class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1154, "\"", 1164, 0);
            EndWriteAttribute();
            WriteLiteral(">Cancel</button>\n            </div>\n        </form>\n    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\AddEmp.cshtml"
            
    Employee emp = new Employee();
    protected async Task CreateEmployee()
    {

    }
    void cancel()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_AddEmp> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_AddEmp> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_AddEmp>)PageContext?.ViewData;
        public Pages_AddEmp Model => ViewData.Model;
    }
}
#pragma warning restore 1591
