#pragma checksum "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17006e24d58ab43ff537d9220806b10c157555f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TicketLayout), @"mvc.1.0.view", @"/Views/Shared/_TicketLayout.cshtml")]
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
#line 1 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\_ViewImports.cshtml"
using itmanager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\_ViewImports.cshtml"
using itmanager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17006e24d58ab43ff537d9220806b10c157555f5", @"/Views/Shared/_TicketLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6aff181b18463dd6907d899e983fb4b89e758b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TicketLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Watch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
 if (signInManager.IsSignedIn(User))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
     if (TempData["message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"bg-success p-2\">");
#nullable restore
#line 12 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
                              Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 13 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
     if (!ViewContext.View.Path.Contains("Watch"))
    {
        var session = new TicketSession(Context.Session);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5 class=\"bg-info p-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17006e24d58ab43ff537d9220806b10c157555f55704", async() => {
                WriteLiteral("My Watched Tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("            <span class=\"badge badge-light\">");
#nullable restore
#line 24 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
                                        Write(session.GetMyTicketCount());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </h5>\r\n");
#nullable restore
#line 26 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Traee\source\repos\Github\IT-Manager\Views\Shared\_TicketLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; }
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