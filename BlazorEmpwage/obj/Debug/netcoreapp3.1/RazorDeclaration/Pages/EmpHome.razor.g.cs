// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpHome.razor"
using BlazorEmpwage.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpHome.razor"
using BlazorEmpwage.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/emphome")]
    public partial class EmpHome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\Admin\Downloads\BlazorEmpwage-master (1)\BlazorEmpwage-master\BlazorEmpwage\Pages\EmpHome.razor"
        // public Employee emp = new Employee();
            List<Employee> Emp;
            protected override async Task OnInitializedAsync()
            {
                //EmpServices objCS = new EmpServices();
                //Emp = await Task.Run(() => objCS.GetEmployee());
                Emp = await Task.Run(() => _db.GetEmployee());
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmpService employeeServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmpServices _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmpServices services { get; set; }
    }
}
#pragma warning restore 1591
