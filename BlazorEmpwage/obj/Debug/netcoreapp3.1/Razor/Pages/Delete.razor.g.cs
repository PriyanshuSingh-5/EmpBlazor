#pragma checksum "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58c9f7ff80d854e29d41569cfeb315b502bd2a20"
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
#line 2 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\Delete.razor"
using BlazorEmpwage.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\Delete.razor"
using BlazorEmpwage.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete/{CurretnID}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete</h3>\n");
            __builder.AddMarkupContent(1, "<h2>Delete</h2>\n");
            __builder.AddMarkupContent(2, "<h3>Are you sure you want to delete employee ?</h3>\n<br>\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\n            ");
            __builder.AddMarkupContent(12, "<label>Customer ID:</label>\n            ");
            __builder.OpenElement(13, "label");
            __builder.AddContent(14, 
#nullable restore
#line 14 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\Delete.razor"
                    objCI.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.AddMarkupContent(20, "<label>Name:</label>\n            ");
            __builder.OpenElement(21, "label");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\Delete.razor"
                    objCI.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.AddMarkupContent(29, "\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-md-4");
            __builder.AddMarkupContent(32, "\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\n            ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\Delete.razor"
                                            DeleteCustomers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\Delete.razor"
        //Employee emp = new Employee();
            [Parameter]
            public string CurretnID { get; set; }
            Employee objCI = new Employee();

            protected override async Task OnInitializedAsync()
            {
                objCI = ObjCustomService.GetCustomerByID(Convert.ToInt32(CurretnID));
            }
            protected void DeleteCustomers()
            {
                ObjCustomService.DeleteCustomer(objCI);
                // NavigationManager.NavigateTo("Customer");
            }
            void Cancel()
            {
                // NavigationManager.NavigateTo("Customer");
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmpServices ObjCustomService { get; set; }
    }
}
#pragma warning restore 1591
