#pragma checksum "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "004e90c3d909b60b6e56198b582a4fc4442580c8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorEmpwage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using BlazorEmpwage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\_Imports.razor"
using BlazorEmpwage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
using BlazorEmpwage.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
using BlazorEmpwage.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empwage")]
    public partial class EmpApp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
 if (Checksubmit)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p class=\"alert-warning\">Emp details saved Successfully</p>\n");
#nullable restore
#line 11 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, @"<header class=""header-content header"">
    <div class=""logo-content"">
        <a href=""./EmployeePayrollHome.html""> <img src=""/assets/logo.png"" alt=""logo image""></a>
        <div>
            <span class=""emp-text"">EMPLOYEE</span><br>
            <span class=""emp-text emp-payroll"">PAYROLL  </span>
        </div>
    </div>
</header>


");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-content");
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                      Emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                                      CreateCustomer

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"form-head\">Employee Payroll form</div>\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row-content");
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.AddMarkupContent(14, "<label class=\"label text\" for=\"name\">Name</label>\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "class", "input");
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "id", "name");
                __builder2.AddAttribute(19, "required", true);
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                                                                     Emp.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Emp.Name = __value, Emp.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n\n            <error-output class=\"name-error\" for=\"name\"></error-output>\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.AddMarkupContent(24, @"<div class=""row-content"">
            <label class=""label text"" for=""profile"">Profile image</label>
            <div class=""profile-radio-content"">
                <label>
                    <input type=""radio"" id=""profile1"" name=""profile"" value=""../assets/profile-images/Ellipse -3.png"">
                    <img class=""profile"" id=""image1"" src=""/assets/Ellipse -1.png"">
                </label>
                <label>
                    <input type=""radio"" id=""profile2"" name=""profile"" value=""../assets/profile-images/Ellipse 1.png"" required>
                    <img class=""profile"" id=""image2"" src=""/assets/Ellipse -2.png"">
                </label>
                <label>
                    <input type=""radio"" id=""profile3"" name=""profile"" value=""../assets/profile-images/Ellipse -8.png"" required>
                    <img class=""profile"" id=""image3"" src=""/assets/Ellipse -3.png"">
                </label>
                <label>
                    <input type=""radio"" id=""profile4"" name=""profile"" value=""../assets/profile-images/Ellipse -7.png"" required>
                    <img class=""profile"" id=""image4"" src=""/assets/Ellipse -4.png"">
                </label>
            </div>
        </div>

    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row-content");
                __builder2.AddMarkupContent(27, "\n\n        ");
                __builder2.AddMarkupContent(28, "<label class=\"label text\" for=\"gender\">Gender</label>\n        ");
                __builder2.OpenElement(29, "select");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                        Emp.Gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Emp.Gender = __value, Emp.Gender));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.OpenElement(34, "option");
                __builder2.AddAttribute(35, "value", true);
                __builder2.AddContent(36, "-- Select Gender --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenElement(38, "option");
                __builder2.AddAttribute(39, "value", "Male");
                __builder2.AddContent(40, "Male");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n            ");
                __builder2.OpenElement(42, "option");
                __builder2.AddAttribute(43, "value", "Female");
                __builder2.AddContent(44, "Female");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "row-content");
                __builder2.AddMarkupContent(50, "\n        ");
                __builder2.AddMarkupContent(51, "<label class=\"label text\" for=\"gender\">Department</label>\n        ");
                __builder2.OpenElement(52, "select");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                        Emp.Department

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Emp.Department = __value, Emp.Department));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(56, "\n            ");
                __builder2.OpenElement(57, "option");
                __builder2.AddAttribute(58, "value", true);
                __builder2.AddContent(59, "-- Select Department --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n            ");
                __builder2.OpenElement(61, "option");
                __builder2.AddAttribute(62, "value", "HR");
                __builder2.AddContent(63, "HR");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n            ");
                __builder2.OpenElement(65, "option");
                __builder2.AddAttribute(66, "value", "Engineer");
                __builder2.AddContent(67, "Engineer");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\n            ");
                __builder2.OpenElement(69, "option");
                __builder2.AddAttribute(70, "value", "Finanace");
                __builder2.AddContent(71, "Finanace");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "row-content");
                __builder2.AddMarkupContent(77, "\n            ");
                __builder2.AddMarkupContent(78, "<label class=\"label text\" for=\"name\">Salary</label>\n            ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "class", "input");
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "id", "salary");
                __builder2.AddAttribute(83, "required", true);
                __builder2.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                                                                       Emp.Salary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Emp.Salary = __value, Emp.Salary));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n\n            <error-output class=\"name-error\" for=\"name\"></error-output>\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n        \n\n        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "row-content");
                __builder2.AddMarkupContent(90, "\n            ");
                __builder2.AddMarkupContent(91, "<label class=\"label text\" for=\"startdate\">StartDate</label>\n            ");
                __builder2.OpenElement(92, "input");
                __builder2.AddAttribute(93, "class", "input");
                __builder2.AddAttribute(94, "type", "text");
                __builder2.AddAttribute(95, "id", "startdate");
                __builder2.AddAttribute(96, "required", true);
                __builder2.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 176 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                                                                    Emp.StartDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Emp.StartDate = __value, Emp.StartDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\n\n            <error-output class=\"name-error\" for=\"name\"></error-output>\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n        \n        ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "row-content");
                __builder2.AddMarkupContent(103, "\n            ");
                __builder2.AddMarkupContent(104, "<label class=\"label text\" for=\"Notes\">Notes</label>\n            ");
                __builder2.OpenElement(105, "textarea");
                __builder2.AddAttribute(106, "id", "notes");
                __builder2.AddAttribute(107, "name", "Notes");
                __builder2.AddAttribute(108, "class", "input1");
                __builder2.AddAttribute(109, "placeholder", "");
                __builder2.AddAttribute(110, "stye", "height:100px");
                __builder2.AddAttribute(111, "required", true);
                __builder2.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 183 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
                                                                                                       Emp.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Emp.Notes = __value, Emp.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\n        ");
                __builder2.AddMarkupContent(116, @"<div class=""button-content"">
            <a href=""/emphome"" class=""add-button"">Cancel</a>
            <div class=""submit-reset"">
                <button type=""submit"" class=""submitButton button"" id=""submitButton"">Submit</button>
                <a href=""/empwage"" class=""add-button"">Reset </a>

            </div>
        </div>

    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(117, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 220 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpApp.razor"
        
    public bool Checksubmit = true;
    Employee Emp = new Employee();
    //Employee objCI = new Employee();
    protected void CreateCustomer()
    {
        ObjService.Create(Emp);
        navigation.NavigateTo("empwage");
    }
    void Cancel()
    {
        navigation.NavigateTo("empwage");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmpServices ObjService { get; set; }
    }
}
#pragma warning restore 1591
