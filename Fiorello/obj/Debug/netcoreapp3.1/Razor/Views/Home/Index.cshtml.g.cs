#pragma checksum "C:\Users\Asus\Desktop\WebUI\Fiorello\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b3fcf61856dba06ecdd20130dfe8414d43a417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\WebUI\Fiorello\Views\Home\Index.cshtml"
using Fiorello.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\WebUI\Fiorello\Views\Home\Index.cshtml"
using Fiorello.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b3fcf61856dba06ecdd20130dfe8414d43a417", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Asus\Desktop\WebUI\Fiorello\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Slider section start -->\r\n<section id=\"slider\">\r\n    <div id=\"slider-summary\">\r\n        ");
#nullable restore
#line 12 "C:\Users\Asus\Desktop\WebUI\Fiorello\Views\Home\Index.cshtml"
   Write(Html.Raw(Model.Summary.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Asus\Desktop\WebUI\Fiorello\Views\Home\Index.cshtml"
   Write(Model.Summary.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 291, "\"", 317, 1);
#nullable restore
#line 14 "C:\Users\Asus\Desktop\WebUI\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 297, Model.Summary.Image, 297, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
             alt=""signaturelogo"">
    </div>
    <!-- Slideshow container -->
    <div class=""slideshow-container fade"">
        <!-- Full images with numbers and message Info -->
        <div class=""Containers"">
            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-slider-background.jpg""
                 style=""width:100%"">
        </div>

        <div class=""Containers"">
            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-slider-background-2.jpg""
                 style=""width:100%"">
        </div>

        <div class=""Containers"">
            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-slider-background-3.jpg""
                 style=""width:100%"">
        </div>

        <!-- Back and forward buttons -->

        <a class=""back"" onclick=""plusSlides(-1)"">
            <p id=""backwrd_slidenum""></p> <i class=""fa-solid fa-arrow-left-long""></i>
        </a>
        <a class=""forward"" ");
            WriteLiteral(@"onclick=""plusSlides(1)"">
            <p id=""forwrd_slidenum""></p><i class=""fa-solid fa-arrow-right-long""></i>
        </a>
    </div>
    <br>

    <!-- The circles/dots -->
    <div style=""text-align:center"">
        <span class=""dots"" onclick=""currentSlide(1)""></span>
        <span class=""dots"" onclick=""currentSlide(2)""></span>
        <span class=""dots"" onclick=""currentSlide(3)""></span>
    </div>



</section>
<!-- Slider section end -->
<!-- Products section start -->
<section id=""products"">
    <div id=""filter"">
        <div id=""categories"">
            <button class=""category active"" data-filter=""*"" onclick=""filterSelection('all')"">ALL</button>
            <button class=""category"" onclick=""filterSelection('cactuses')"">CACTUSES</button>
            <button class=""category"" onclick=""filterSelection('exotic')"">EXOTIC</button>
            <button class=""category"" onclick=""filterSelection('greens')"">GREENS</button>
            <button class=""category"" onclick=""filterSelection('popul");
            WriteLiteral(@"ar')"">POPULAR</button>
            <button class=""category"" onclick=""filterSelection('various')"">VARIOUS</button>
            <button class=""category"" onclick=""filterSelection('winter')"">WINTER</button>
        </div>
        <span id=""filter-span"">
            FILTER <i class=""fa-solid fa-caret-down""></i>
            <div id=""filter-dropdown"">
                <ul id=""sort_by"">
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2807, "\"", 2814, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h2 id=\"sort-h2-font\">Sort By</h2>\r\n                        </a>\r\n                    </li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2965, "\"", 2972, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3018, "\"", 3025, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3074, "\"", 3081, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3127, "\"", 3134, 0);
            EndWriteAttribute();
            WriteLiteral(">Price:Low To High</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3190, "\"", 3197, 0);
            EndWriteAttribute();
            WriteLiteral(">Price:Hogh To Low</a></li>\r\n                </ul>\r\n                <ul id=\"price_range\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3341, "\"", 3348, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h2 id=\"price-h2-font\">Price Range</h2>\r\n                        </a>\r\n                    </li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3504, "\"", 3511, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3553, "\"", 3560, 0);
            EndWriteAttribute();
            WriteLiteral(">$0-$10</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3605, "\"", 3612, 0);
            EndWriteAttribute();
            WriteLiteral(">$10-$20</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3658, "\"", 3665, 0);
            EndWriteAttribute();
            WriteLiteral(">$20-$30</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3711, "\"", 3718, 0);
            EndWriteAttribute();
            WriteLiteral(">$30-$40</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3764, "\"", 3771, 0);
            EndWriteAttribute();
            WriteLiteral(@">40$+</a></li>

                </ul>
            </div>
        </span>
    </div>
    <div id=""product-cards"">
        <div class=""card popular winter cactuses"" data-id=""1"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-14-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary"">
                <p class=""item-name"">MAJESTY PALM</p>
                <button class=""add-to-card"">Add to cart</button>
                <p class=""item-price"">$259</p>
            </div>
        </div>

        <div class=""card popular winter"" data-id=""2"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-13-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary"">
                <p class=""item-name"">FOXGLOVE FLOWER</p>
                <butto");
            WriteLiteral(@"n class=""add-to-card"">Add to cart</button>
                <p class=""item-price"">$259</p>
            </div>
        </div>
        <div class=""card popular winter"" data-id=""3"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-10-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary"">
                <p class=""item-name"">SWEET ALYSSUM</p>
                <button class=""read-more"">Read More</button>
                <p class=""item-price"">$259</p>
            </div>
        </div>
        <div class=""card popular"" data-id=""4"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-11-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary"">
                <p class=""item-name"">SPRING SNOWFLAKE</p>
                <button class=""add");
            WriteLiteral(@"-to-card"">Add to cart</button>
                <p class=""item-price"">$170</p>
            </div>
        </div>
        <div class=""card popular"" data-id=""5"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-12-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary"">
                <p class=""item-name"">SCARLET SAGE</p>
                <button class=""add-to-card"">Add to cart</button>
                <p class=""item-price"">
                    <span style=""text-decoration:line-through ;margin-right:5px ;"">$259</span>$159
                </p>
            </div>
        </div>
        <div class=""card various"" data-id=""6"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-9-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary");
            WriteLiteral(@""">
                <p class=""item-name"">ROCK SOAPWORT</p>
                <button class=""view-products"">View Product</button>
                <p class=""item-price"">$259</p>
            </div>
        </div>
        <div class=""card greens various"" data-id=""7"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-8-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary"">
                <p class=""item-name"">SUMMER SAVORY</p>
                <button class=""add-to-card"">Add to cart</button>
                <p class=""item-price"">$259</p>
            </div>
        </div>
        <div class=""card exotic various"" data-id=""8"">
            <div class=""card-image"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-7-img.jpg""
                     alt=""product image"">
            </div>
            <div class=""card-summary"">
            WriteLiteral(@"
                <p class=""item-name"">WILD ROSES</p>
                <button class=""buy-on-amazon"">Buy on Amazon</button>
                <p class=""item-price"">$259</p>
            </div>
        </div>

    </div>

</section>
<!-- Products section end -->
<!-- Surprise your valentine section start -->
<section id=""surprise_your_valentine"">
    <div id=""video"">
        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-video-img.jpg""
             alt=""video's layer photo"">
        <button id=""play_btn"">
            <div id=""red_triangle""></div>
            <a href=""https://www.youtube.com/watch?time_continue=1&v=K-0cjGCNYfs""></a>
        </button>

    </div>
    <div id=""surprise_your_valentine_summary"">
        <h3>
            Suprise Your <span>Valentine!</span>
            Let us arrange a smile.
        </h3>

        <p>Where flowers are our inspiration to create lasting memories. Whatever the occasion...</p>

        <ul>
            <li><img src");
            WriteLiteral(@"=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png"" alt=""heart-photo"">Hand picked just for you.</li>
            <li><img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png"" alt=""heart-photo"">Unique flower arrangements</li>
            <li><img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png"" alt=""heart-photo"">Best way to say you care.</li>
        </ul>



    </div>

</section>
<!-- Surprise your valentine section end -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591