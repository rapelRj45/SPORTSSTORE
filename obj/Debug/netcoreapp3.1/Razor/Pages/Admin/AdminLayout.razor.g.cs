#pragma checksum "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\AdminLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64269fd2e97678ff10bc3aa5e01d1abb8e1fe40ba3f19f6719f9d9e3b2367657"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""bg-info text-white p-2"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col"">
                <span class=""navbar-brand ml-2"">SPORTS STORE Administration</span>
            </div>
            <div class=""col-2 text-right"">
                <a class=""btn btn-sm btn-primary"" href=""/account/logout"">Log Out</a>
            </div>
        </div>
    </div>
</div>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", (object)("btn btn-outline-primary btn-block"));
            __builder.AddAttribute(12, "href", (object)("/admin/products"));
            __builder.AddAttribute(13, "ActiveClass", (object)("btn-primary text-white"));
            __builder.AddAttribute(14, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\AdminLayout.razor"
                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\n                Products\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", (object)("btn btn-outline-primary btn-block"));
            __builder.AddAttribute(20, "href", (object)("/admin/orders"));
            __builder.AddAttribute(21, "ActiveClass", (object)("btn-primary text-white"));
            __builder.AddAttribute(22, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 27 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\AdminLayout.razor"
                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\n                Orders\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col");
            __builder.AddMarkupContent(29, "\n            ");
#nullable restore
#line 32 "C:\Users\rapel\Downloads\sports-store-master\sports-store-master\SportsStore\Pages\Admin\AdminLayout.razor"
__builder.AddContent(30, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
