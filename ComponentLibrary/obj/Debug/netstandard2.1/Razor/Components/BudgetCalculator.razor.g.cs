#pragma checksum "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9d7604a48bb6cc345c4aded42b08c23bab2183"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLibrary.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class BudgetCalculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Budget Calculator</h3>\r\n");
            __builder.AddMarkupContent(1, "<p><em>Demonstrates data binding, onclick events, and putting data into a List.</em></p>\r\n<hr class=\"my-4\">\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "class", "form-inline my-2");
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
                                               newBill

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
                                                                       AddBill

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-inline my-2");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "p");
                __builder2.AddContent(18, "Paycheck amount:   ");
                __Blazor.ComponentLibrary.Components.BudgetCalculator.TypeInference.CreateInputNumber_0(__builder2, 19, 20, "form-control mx-2", 21, 
#nullable restore
#line 11 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
                                                                                      Paycheck

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Paycheck = __value, Paycheck)), 23, () => Paycheck);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "p");
                __builder2.AddContent(26, "Enter bill amount: ");
                __Blazor.ComponentLibrary.Components.BudgetCalculator.TypeInference.CreateInputNumber_1(__builder2, 27, 28, "form-control mx-2", 29, 
#nullable restore
#line 12 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
                                                                                      newBill.Amount

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBill.Amount = __value, newBill.Amount)), 31, () => newBill.Amount);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n        ");
                __builder2.AddMarkupContent(34, "<div class=\"card-footer\">\r\n            <button class=\"btn btn-outline-primary align-self-end\" type=\"submit\">Add Bill</button>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n");
            __builder.OpenElement(37, "ul");
            __builder.AddAttribute(38, "class", "list-group");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 23 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
     foreach (var bill in billList)
    {

        Total += bill.Amount;


#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "list-group-item list-group-item-secondary");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.AddContent(44, 
#nullable restore
#line 29 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
              bill.Number

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(45, ". $");
            __builder.AddContent(46, 
#nullable restore
#line 29 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
                              bill.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 31 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n");
            __builder.OpenElement(50, "p");
            __builder.AddContent(51, "Remaining balance: $");
            __builder.AddContent(52, 
#nullable restore
#line 35 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
                         Paycheck - Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n<hr class=\"my-4\">\r\n\r\n");
#nullable restore
#line 38 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
 foreach (var bill in billList)
{
    Total = Total - bill.Amount;
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "G:\ComponentLibrary\ComponentLibrary\Components\BudgetCalculator.razor"
       

    [Required]
    private float Paycheck;
    private float Total;
    private int Num = 1;
    private List<BillModel> billList = new List<BillModel>();
    private BillModel newBill = new BillModel();


    public class BillModel
    {
        public string Name { get; set; }

        [Required]
        public float Amount { get; set; }
        public int Number { get; set; }
    }

    public void AddBill()
    {
        if (newBill.Amount.Equals(0))
                return;
        newBill.Number = Num++;
        billList.Add(newBill);

        newBill = new BillModel();
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ComponentLibrary.Components.BudgetCalculator
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
