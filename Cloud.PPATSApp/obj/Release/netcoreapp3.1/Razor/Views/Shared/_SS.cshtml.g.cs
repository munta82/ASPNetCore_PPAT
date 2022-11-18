#pragma checksum "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52fdeb2ec69d8a49d2d5ab9b91926bf666845a49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SS), @"mvc.1.0.view", @"/Views/Shared/_SS.cshtml")]
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
#line 1 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\_ViewImports.cshtml"
using Cloud.PPATSApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\_ViewImports.cshtml"
using Cloud.PPATSApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52fdeb2ec69d8a49d2d5ab9b91926bf666845a49", @"/Views/Shared/_SS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e26895ecaae628631d088b24d76faad02f80ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("go"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/btn_go_blue.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("25px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("25px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .modal-dialog {
        width: 250px !important;
    }

    #tblPreview td {
        height: 5px;
    }
</style>
<h4>SS</h4>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#ddlMeasuringApp"").on(""change"", function () {
            $(""#hdnMeasuringApp"").val($(this).find(""option:selected"").text());
        });
        //Loading of page
        $(""#ddlStates"").prop(""disabled"", true);
        $(""#ddlParliament"").prop(""disabled"", true);
        $(""#ddlAssembly"").prop(""disabled"", true);
        $(""#ddlMandal"").prop(""disabled"", true);
        $(""#ddlVillage"").prop(""disabled"", true);
        if ($(""#txtPSName"").val() == null || $(""#txtPSName"").val() == """") {
            $(""#txtPSName"").prop(""disabled"", false);
        }
        else {
            $(""#txtPSName"").prop(""disabled"", true);
        }
        //Loading of page

        $(""#btnPSGo"").click(function () {

            var psCodeval = $(""#txtPSCode"").val();
            if (psCodeval == ");
            WriteLiteral(@""""") {
                alert(""Please enter PS Code"");
                return false;
            }
            $.ajax({
                type: ""POST"",
                url: ""/PPAT/GetPPATPollingStationData"",
                dataType: ""json"",
                cache: false,
                async: false,
                data: {
                    PSCode: psCodeval
                },
                success: function (data) {
                    //debugger;
                    $(""#ddlStates"").val(data.stateCode);
                    $(""#ddlParliament"").val(data.pccode);
                    $(""#ddlAssembly"").val(data.accode);
                    $(""#ddlMandal"").val(data.mandalCode);
                    $(""#ddlVillage"").val(data.villageCode);
                    $(""#txtPSName"").val(data.psname);

                    $(""#ddlStates"").prop(""disabled"", true);
                    $(""#ddlParliament"").prop(""disabled"", true);
                    $(""#ddlAssembly"").prop(""disabled"", true);
               ");
            WriteLiteral(@"     $(""#ddlMandal"").prop(""disabled"", true);
                    $(""#ddlVillage"").prop(""disabled"", true);
                    if (data.psname == null || data.psname == """") {
                        $(""#txtPSName"").prop(""disabled"", false);
                    }
                    else {
                        $(""#txtPSName"").prop(""disabled"", true);
                    }
                    console.log(data);
                },
                error: function (jqXhr, textStatus, errorMessage) {
                    //debugger;

                    //console.log(""AJAX ERROR:"", data);
                }
            });
        });


        $(""#txtSubCaste"").autocomplete({
            source: function (request, response) {
                $.ajax({
                    type: ""POST"",
                    url: ""/PPAT/GetPPATSubCasteData"",
                    dataType: ""json"",
                    cache: false,
                    async: false,
                    maxShowItems: 5,
           ");
            WriteLiteral(@"         minLength: 2,
                    data: {
                        searchString: $(""#txtSubCaste"").val(),
                        communityCode: $(""#ddlCommunity"").val()
                    },
                    success: function (data) {
                        //debugger;
                        response($.map(data, function (item) {
                            //debugger;
                            return {
                                label: item.subCasteName,
                                value: item.subCasteCode

                            }
                        }));

                        console.log(data);
                    },
                    error: function (jqXhr, textStatus, errorMessage) {
                        //debugger;
                        if (jqXhr.responseText.indexOf('maxJsonLength') > -1) {
                            alert(""Search results exceeds max records. Plese refine your search with more characters"");
                        }
 ");
            WriteLiteral(@"                   }
                });
            },
            minLength: 2,
            select: function (evet, ui) {
                //debugger;
                var subcastecode = ui.item.value;
                $(""#txtSubCaste"").val(ui.item.label);
            }
        });

        $(""#btnSave"").click(function () {
            //e.preventDefault();
            //var selectedOption = $(""#CountryId option:selected"").text();
            //// Add the selected drop down text to a hidden field
            //$(""<input/>"", { type: 'hidden', name: 'countryName' }).val(selectedOption).appendTo(""#someForm"");


            $(""#ddlStates"").prop(""disabled"", false);
            $(""#ddlParliament"").prop(""disabled"", false);
            $(""#ddlAssembly"").prop(""disabled"", false);
            $(""#ddlMandal"").prop(""disabled"", false);
            $(""#ddlVillage"").prop(""disabled"", false);
            $(""#txtPSName"").prop(""disabled"", false);

            $(""form"").attr(""action"", ""/SS/SaveSSForm"");
 ");
            WriteLiteral(@"       });

        $(""#btnPreview"").click(function () {

            $(""#ddlStates"").prop(""disabled"", false);
            $(""#ddlParliament"").prop(""disabled"", false);
            $(""#ddlAssembly"").prop(""disabled"", false);
            $(""#ddlMandal"").prop(""disabled"", false);
            $(""#ddlVillage"").prop(""disabled"", false);
            $(""#txtPSName"").prop(""disabled"", false);

            $(""#lblMeasuringApplication"").text($(""#ddlMeasuringApp option:selected"").text());
            $(""#lblState"").text($(""#ddlStates option:selected"").text());
            $(""#lblParliament"").text($(""#ddlParliament option:selected"").text());
            $(""#lblAssembly"").text($(""#ddlAssembly option:selected"").text());
            $(""#lblMandal"").text($(""#ddlMandal option:selected"").text());
            $(""#lblVillage"").text($(""#ddlVillage option:selected"").text());

            $(""#lblPSName"").text($(""#txtPSName"").val());
            $(""#lblPSCode"").text($(""#txtPSCode"").val());
            $(""#lblName"").te");
            WriteLiteral(@"xt($(""#txtUserDisplayName"").val());
            $(""#lblAge"").text($(""#txtUserAge"").val());
            $(""#lblGender"").text($(""#ddlGender option:selected"").text());
            $(""#lblMobile"").text($(""#txtMobile"").val());
            $(""#lblEducation"").text($(""#ddlEducation option:selected"").text());
            $(""#lblOccupation"").text($(""#txtOccupation"").val());

            $(""#lblCommunity"").text($(""#ddlCommunity option:selected"").text());
            $(""#lblSubCaste"").text($(""#txtSubCaste"").val());
            $(""#lblIF"").text($(""#ddlIFParty option:selected"").text());
            $(""#lblSF"").text($(""#ddlPPAT_SF option:selected"").text());
            $(""#lblPRF"").text($(""#ddlPPAT_VPF option:selected"").text());
            $(""#lblVPF"").text($(""#ddlPPAT_VPF option:selected"").text());
            $(""#lblPIF"").text($(""#ddlPPAT_PIF option:selected"").text());
            $(""#lblRemarks"").text($(""#txtRemarks"").val());
        });

        $(""#btnPreviewClose,#btnClosePreview"").click(function () ");
            WriteLiteral(@"{
            $(""#ddlStates"").prop(""disabled"", true);
            $(""#ddlParliament"").prop(""disabled"", true);
            $(""#ddlAssembly"").prop(""disabled"", true);
            $(""#ddlMandal"").prop(""disabled"", true);
            $(""#ddlVillage"").prop(""disabled"", true);
            $(""#txtPSName"").prop(""disabled"", true);
            //$(""form"").attr(""action"", ""/PPAT/ClearForm"");
        });

        $(""#btnClear"").click(function () {
            //$(""input:text"").val("""");
            //$(""select#elem"").prop('selectedIndex', 0);
        })

    });
</script>
");
#nullable restore
#line 189 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table border=\"1\">\r\n        <tbody>\r\n            <tr>\r\n                <td>\r\n");
            WriteLiteral("                    <input type=\"hidden\" id=\"hdnMeasuringApp\" name=\"hdnMeasuringApp\"");
            BeginWriteAttribute("value", " value=\"", 8056, "\"", 8064, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <table class=""tblRoundCorner"" style=""width:100%"">
                        <tr>
                            <td>
                                Measuring Applications<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlMeasuringApp""
                                                            data-valmsg-replace=""true"">*</span>
                            </td>
                            <td>
                                ");
#nullable restore
#line 204 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                           Write(Html.DropDownList("ddlMeasuringApp", (IEnumerable<SelectListItem>)ViewBag.ddlMeasuringApp, "Select",
                                new
                                    {
                                        @class = "form-control valid PPATDropdownlist",
                               @data_val = "true",
                                        @data_val_required = " required"
                                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tr>\r\n                    </table>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"height:5px;\">\r\n");
            WriteLiteral(@"                </td>
            </tr>
            <tr>
                <td>
                    <table border=""1"" style=""width:100%"" class=""tblRoundCorner"">
                        <tr>
                            <td>
                                State<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlStates""
                                           data-valmsg-replace=""true"">*</span><br />
                                ");
#nullable restore
#line 227 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                           Write(Html.DropDownList("ddlStates", (IEnumerable<SelectListItem>)ViewBag.ddlStates, "Select",
                               new { @class = "form-control valid PPATDropdownlist", @data_val = "true", @data_val_required = " required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(@"
                        </td>
                        <td>
                            Parliament<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlParliament""
                                            data-valmsg-replace=""true"">*</span><br />
                            ");
#nullable restore
#line 233 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.DropDownList("ddlParliament", ViewBag.ddlParliament as SelectList, "Select",
                           new { @class = "form-control PPATDropdownlist valid", @data_val = "true", @data_val_required = " required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Assembly<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlAssembly""
                                          data-valmsg-replace=""true"">*</span><br />
                            ");
#nullable restore
#line 241 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.DropDownList("ddlAssembly", ViewBag.ddlAssembly as SelectList, "Select",
                           new { @class = "form-control PPATDropdownlist valid", @data_val = "true", @data_val_required = " required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td>
                            Mandal<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlMandal""
                                        data-valmsg-replace=""true"">*</span><br />
                            ");
#nullable restore
#line 247 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.DropDownList("ddlMandal", ViewBag.ddlMandal as SelectList, "Select",
                           new { @class = "form-control PPATDropdownlist valid", @data_val = "true", @data_val_required = " required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Village<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlVillage""
                                         data-valmsg-replace=""true"">*</span><br />
                            ");
#nullable restore
#line 255 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.DropDownList("ddlVillage", ViewBag.ddlVillage as SelectList, "Select",
                           new { @class = "form-control PPATDropdownlist valid", @data_val = "true", @data_val_required = " required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            PS Name<br />\r\n                            ");
#nullable restore
#line 260 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.TextBox("txtPSName", (object)ViewBag.PSName, new { @class = "form-control PPATtextbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td>
                            PS Code<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""txtPSCode""
                                         data-valmsg-replace=""true"">*</span><br />
                            ");
#nullable restore
#line 267 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.TextBox("txtPSCode", (object)ViewBag.PSCode,
                           new { @class = "form-control PPATtextbox valid", @data_val = "true", @data_val_required = " required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td align=\"center\" valign=\"middle\">\r\n");
            WriteLiteral("                            <a href=\"#\" id=\"btnPSGo\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52fdeb2ec69d8a49d2d5ab9b91926bf666845a4920317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style=""height:5px;""></td>
        </tr>
        <tr>
            <td>
                <table border=""1"" style=""width:100%"" class=""tblRoundCorner"">
                    <tr>
                        <td>
                            Community<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlCommunity""
                                           data-valmsg-replace=""true"">*</span><br />
                            ");
#nullable restore
#line 290 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.DropDownList("ddlCommunity", ViewBag.ddlCommunity as SelectList, "Select",
                           new { @class = "form-control PPATDropdownlist valid", @data_val = "true", @data_val_required = " required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Sub Caste<br />\r\n                            ");
#nullable restore
#line 295 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.TextBox("txtSubCaste", null, new { @class = "form-control PPATtextbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>


                    <tr>
                        <td>
                            Voters<span class=""field-validation-valid field-validation-error"" data-valmsg-for=""ddlGrade""
                                        data-valmsg-replace=""true"">*</span><br />
                            ");
#nullable restore
#line 304 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.TextBox("txtVoters", string.Empty, null, new { @class = "form-control PPATtextbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td colspan=\"2\">\r\n                            Remarks<br />\r\n                            ");
#nullable restore
#line 308 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
                       Write(Html.TextArea("txtRemarks", string.Empty, 3, 18,null));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td colspan=""2"" align=""center"">
                            <table id=""tblPIGButtons"">
                                <tr>
                                    <td>
");
            WriteLiteral(@"                                        <input id=""btnPreview"" value=""Preview""
                                               formnovalidate=""formnovalidate""
                                               type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"" />
                                    </td>
                                    <td style=""width:5px;""></td>
                                    <td>
");
            WriteLiteral(@"                                        <input type=""submit"" id=""btnSave"" value=""Save"" class=""btn btn-primary"" />
                                    </td>
                                    <td style=""width:5px;""></td>
                                    <td>
");
            WriteLiteral(@"                                        <input type=""button"" id=""btnClear"" value=""Clear"" class=""btn btn-primary cancel"" />
                                    </td>
                                </tr>
                            </table>
                        </td>

                    </tr>
                </table>
                <!-- Modal -->
                <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
");
            WriteLiteral(@"                            <div>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" id=""btnClosePreview"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <table border=""1"" id=""tblPreview"">
                                    <tr>
                                        <td>Measuring Application</td>
                                        <td>:</td>
                                        <td><label id=""lblMeasuringApplication""></label></td>
                                    </tr>
                                    <tr>
                                        <td>State</td>
                                        <td>:</td>
                                        <td><label id=""lblState""></label></td>
                                    </tr>
   ");
            WriteLiteral(@"                                 <tr>
                                        <td>Parliament</td>
                                        <td>:</td>
                                        <td><label id=""lblParliament""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Assembly</td>
                                        <td>:</td>
                                        <td><label id=""lblAssembly""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Mandal</td>
                                        <td>:</td>
                                        <td><label id=""lblMandal""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Village</td>
                                        <td>:</td>
                                      ");
            WriteLiteral(@"  <td><label id=""lblVillage""></label></td>
                                    </tr>
                                    <tr>
                                        <td>PS Name</td>
                                        <td>:</td>
                                        <td><label id=""lblPSName""></label></td>
                                    </tr>
                                    <tr>
                                        <td>PS Code</td>
                                        <td>:</td>
                                        <td><label id=""lblPSCode""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Name</td>
                                        <td>:</td>
                                        <td><label id=""lblName""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Age</td>
                  ");
            WriteLiteral(@"                      <td>:</td>
                                        <td><label id=""lblAge""></label></td>
                                    <tr>
                                        <td>Gender</td>
                                        <td>:</td>
                                        <td><label id=""lblGender""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Mobile</td>
                                        <td>:</td>
                                        <td><label id=""lblMobile""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Education</td>
                                        <td>:</td>
                                        <td><label id=""lblEducation""></label></td>
                                    </tr>
                                    <tr>
                                       ");
            WriteLiteral(@" <td>Occupation</td>
                                        <td>:</td>
                                        <td><label id=""lblOccupation""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Community</td>
                                        <td>:</td>
                                        <td><label id=""lblCommunity""></label></td>
                                    </tr>
                                    <tr>
                                        <td>Sub-Caste</td>
                                        <td>:</td>
                                        <td><label id=""lblSubCaste""></label></td>
                                    </tr>
                                    <tr>
                                        <td>IF</td>
                                        <td>:</td>
                                        <td><label id=""lblIF""></label></td>
                                    <");
            WriteLiteral(@"/tr>
                                    <tr>
                                        <td>SF</td>
                                        <td>:</td>
                                        <td><label id=""lblSF""></label></td>
                                    </tr>
                                    <tr>
                                        <td>PRF</td>
                                        <td>:</td>
                                        <td><label id=""lblPRF""></label></td>
                                    </tr>
                                    <tr>
                                        <td>VPF</td>
                                        <td>:</td>
                                        <td><label id=""lblVPF""></label></td>
                                    </tr>
                                    <tr>
                                        <td>PIF</td>
                                        <td>:</td>
                                        <td><label id=""lblPIF""></");
            WriteLiteral(@"label></td>
                                    </tr>
                                    <tr>
                                        <td>Remarks</td>
                                        <td>:</td>
                                        <td><label id=""lblRemarks""></label></td>
                                    </tr>
                                </table>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"" id=""btnPreviewClose"">Close</button>
");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 479 "C:\Users\Satish Kumar\Projects\Cloud.PPATSApp\Cloud.PPATSApp\Views\Shared\_SS.cshtml"
}

#line default
#line hidden
#nullable disable
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
