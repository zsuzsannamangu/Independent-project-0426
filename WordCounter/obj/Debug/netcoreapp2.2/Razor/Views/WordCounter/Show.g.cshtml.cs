#pragma checksum "/Users/zsuzsannamangu/Desktop/Epicodus/WordCounter.Solution/WordCounter/Views/WordCounter/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86e7b6467871072a321dde1d6fa0f1b081d6d20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WordCounter_Show), @"mvc.1.0.view", @"/Views/WordCounter/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WordCounter/Show.cshtml", typeof(AspNetCore.Views_WordCounter_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86e7b6467871072a321dde1d6fa0f1b081d6d20", @"/Views/WordCounter/Show.cshtml")]
    public class Views_WordCounter_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zsuzsannamangu/Desktop/Epicodus/WordCounter.Solution/WordCounter/Views/WordCounter/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 340, true);
            WriteLiteral(@"
<div class=""container text-center"">
  <h2>What is word?</h2>
  <p>Your word has to be a single word that contains many alphabetical characters. No spaces, hyphens and punctuation marks can be used.
  <br>
  <br>
  <h2>What is sentence?</h2>
  <p>A sentence contains many words. No spaces, hyphens and punctuation marks can be used.
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591