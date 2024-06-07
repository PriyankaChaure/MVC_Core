#pragma checksum "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ee6345accacc5d31ee1562533b37b903f5d162104c6690f23cbb0d67a2d6146b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetCustomers), @"mvc.1.0.view", @"/Views/Customer/GetCustomers.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ee6345accacc5d31ee1562533b37b903f5d162104c6690f23cbb0d67a2d6146b", @"/Views/Customer/GetCustomers.cshtml")]
    #nullable restore
    public class Views_Customer_GetCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Ex.Models.Customer>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6345accacc5d31ee1562533b37b903f5d162104c6690f23cbb0d67a2d6146b2903", async() => {
                WriteLiteral("\r\n    <title>Customers list</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6345accacc5d31ee1562533b37b903f5d162104c6690f23cbb0d67a2d6146b3930", async() => {
                WriteLiteral("\r\n    <h2>Customers Lists</h2>\r\n    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 11 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
           Write(Html.DisplayNameFor(p => p.customerid));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
           Write(Html.DisplayNameFor(p => p.customername));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
           Write(Html.DisplayNameFor(p => p.customeraddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
           Write(Html.DisplayNameFor(p => p.customeremailid));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
           Write(Html.DisplayNameFor(p => p.customermobileno));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
           Write(Html.DisplayNameFor(p => p.customercreditlimit));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
         foreach (var temp in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
               Write(Html.DisplayFor(p => temp.customerid));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
               Write(Html.DisplayFor(p => temp.customername));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
               Write(Html.DisplayFor(p => temp.customeraddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
               Write(Html.DisplayFor(p => temp.customeremailid));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
               Write(Html.DisplayFor(p => temp.customermobileno));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
               Write(Html.DisplayFor(p => temp.customercreditlimit));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Ankit\MVC_Core\MVC_Ex\MVC_Ex\Views\Customer\GetCustomers.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Ex.Models.Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591