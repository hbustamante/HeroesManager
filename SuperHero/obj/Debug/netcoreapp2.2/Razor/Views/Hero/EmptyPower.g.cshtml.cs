#pragma checksum "C:\Users\heber.bustamante\Desktop\AspNetCore\HeroesManager\SuperHero\Views\Hero\EmptyPower.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "654fac1cb348f816e6a5c028c2713d68b5ce131c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hero_EmptyPower), @"mvc.1.0.view", @"/Views/Hero/EmptyPower.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hero/EmptyPower.cshtml", typeof(AspNetCore.Views_Hero_EmptyPower))]
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
#line 1 "C:\Users\heber.bustamante\Desktop\AspNetCore\HeroesManager\SuperHero\Views\_ViewImports.cshtml"
using SuperHero;

#line default
#line hidden
#line 2 "C:\Users\heber.bustamante\Desktop\AspNetCore\HeroesManager\SuperHero\Views\_ViewImports.cshtml"
using DataLayer.Model;

#line default
#line hidden
#line 3 "C:\Users\heber.bustamante\Desktop\AspNetCore\HeroesManager\SuperHero\Views\_ViewImports.cshtml"
using SuperHero.Models;

#line default
#line hidden
#line 4 "C:\Users\heber.bustamante\Desktop\AspNetCore\HeroesManager\SuperHero\Views\_ViewImports.cshtml"
using SuperHero.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654fac1cb348f816e6a5c028c2713d68b5ce131c", @"/Views/Hero/EmptyPower.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c6d0848271021e6d3fe36d9049915b606c4d3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Hero_EmptyPower : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Power>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 11, true);
            WriteLiteral("<h2>Power: ");
            EndContext();
            BeginContext(26, 10, false);
#line 2 "C:\Users\heber.bustamante\Desktop\AspNetCore\HeroesManager\SuperHero\Views\Hero\EmptyPower.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(36, 19, true);
            WriteLiteral(" has no heros.</h2>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Power> Html { get; private set; }
    }
}
#pragma warning restore 1591
