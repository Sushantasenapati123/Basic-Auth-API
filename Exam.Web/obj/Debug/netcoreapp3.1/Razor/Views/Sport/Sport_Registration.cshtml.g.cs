#pragma checksum "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a1f961c7bcb715cc590f31fa99e40d2fd9cc702147d2bfa110d75a759251fc61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sport_Sport_Registration), @"mvc.1.0.view", @"/Views/Sport/Sport_Registration.cshtml")]
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
#nullable restore
#line 1 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\_ViewImports.cshtml"
using Exam.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\_ViewImports.cshtml"
using Exam.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a1f961c7bcb715cc590f31fa99e40d2fd9cc702147d2bfa110d75a759251fc61", @"/Views/Sport/Sport_Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"925023c6e89c953f3033738b9907e08547443eeec05a5e6b1980ff70ab9187a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sport_Sport_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam.Domain.Sports.Spot>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Club"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("GetAllSubCatByCId()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/validation/validation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
  
    ViewData["Title"] = "AddDoctor";

    
 
    var ResultData = ViewBag.Result as List<Exam.Domain.Sports.Spot>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-title"">
    <div class=""title-details"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb p-0 mb-0 bg-transparent"" id=""navigation"">
            </ol>
        </nav>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card"">
            <div class=""card-header"">

                <div class=""indicatorslist"">
                    <a");
            BeginWriteAttribute("title", " title=\"", 1015, "\"", 1023, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:void(0)"" id=""backIcon"" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Back""><i class=""icon-arrow-left1""></i></a>
                    <center><h2>Sport Registration Forms </h2></center>
                </div>
            </div>
           

            <!-- BASIC FORM ELEMENTS -->
            <!--===================================================-->
        <div class=""card-body"">
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Club Name  <span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-6 col-xl-4"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1f961c7bcb715cc590f31fa99e40d2fd9cc702147d2bfa110d75a759251fc617316", async() => {
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 60 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.UnitName,"club_id","club_name"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Sports Name  <span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-6 col-xl-4"">
                    <select id=""Sports"" class=""form-control"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1f961c7bcb715cc590f31fa99e40d2fd9cc702147d2bfa110d75a759251fc619470", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
            </div>

         
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">AppliCant Name  <span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-6 col-xl-4"">
                    <input id=""NAme"" class=""form-control"" />
                </div>

            </div>

         
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Email  <span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-6 col-xl-4"">
                    <input id=""Email"" type=""email"" class=""form-control"" onchange=""emailValidate('Email','lblError')"" />
                    <span id=""lblError"" style=""color:red""></span>
                </div>

            </div>

          
            <div class=""form-group row"">
                <label class=""");
            WriteLiteral(@"col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Mobile  <span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-6 col-xl-4"">
                    <input id=""Mobile"" class=""form-control"" onchange=""Phonevalidate('Mobile','lblErrorPhone')"" />
                    <span id=""lblErrorPhone"" style=""color:red""></span>
                </div>
            </div>
          


         
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Gender<span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-4 col-xl-4"">
                    <input type=""radio"" id=""SchoolType"" name=""SchoolType"" class=""s_type "" value=""Male"" />Male
");
            WriteLiteral("                    <input type=\"radio\" id=\"SchoolType\" name=\"SchoolType\" class=\"s_type \" value=\"Female\" />Female\r\n");
            WriteLiteral(@"                </div>
            </div>
        
            <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Image  <span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-6 col-xl-4"">
                    <input id=""Image"" class=""form-control"" type=""file"" />

                </div>

            </div>

        <div class=""form-group row"">
                <label class=""col-12 col-md-2 col-xl-2 control-label"" for=""demo-email-input"">Dob  <span class=""text-danger"">*</span></label>
                <div class=""col-12 col-md-6 col-xl-4"">
                    <input type=""date"" id=""db"" class=""form-control"" />
");
            WriteLiteral("                    \r\n                </div>\r\n             </div>\r\n        </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    <label class=\"control-label\">Image</label>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5939, "\"", 5945, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""30"" height=""30"" id=""si"" />


                </div>

          

      



      


        <div class=""form-group col-md-4"">

            <input id=""PatientID"" class=""form-control"" hidden />
        </div>


        <div class=""form-group row"">
            <label class=""col-12 col-md-2 col-xl-2 control-label""></label>
            <div class=""col-12 col-md-6 col-xl-4"">
                <button class=""btn btn-primary mb-1"" id=""btnSubmit"">Submit</button>
                <button class=""btn btn-danger mb-1"" id=""btnCancel"">Reset</button>
            </div>
        </div>
    </div>

    <div class=""card-body "">
");
#nullable restore
#line 170 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
         if (ResultData != null && ResultData.ToList().Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""table-responsive"">
            <table data-toggle=""table"" id=""tblDoctor"" class=""table"">
                <thead>
                    <tr>
                        <th width=""60px"" class=""align-top text-center"">Sl#</th>
                        <th width=""150px"" class=""align-top"">
                            Name
                        </th>
                        <th width=""150px"" class=""align-top"">
                            Email
                        </th>

                        <th width=""150px"" class=""align-top"">
                            Mobile
                        </th>
                        <th width=""150px"" class=""align-top"">
                            Club Name
                        </th>

                        <th width=""150px"" class=""align-top"">
                            Sports Name
                        </th>
                        <th width=""150px"" class=""align-top"">
                            Image
                        </th>
");
            WriteLiteral("\r\n\r\n\r\n\r\n                        <th width=\"150px\" class=\"align-top\">Action</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 205 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                      
                        int count = 1;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                     foreach (var list in ResultData)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 211 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 213 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                           Write(list.Applicant_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 216 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                           Write(list.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 219 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                           Write(list.Mobile_no);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 222 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                           Write(list.club_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 225 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                           Write(list.sprot_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                               \r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 8813, "\"", 8839, 2);
            WriteAttributeValue("", 8820, "../", 8820, 3, true);
#nullable restore
#line 230 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
WriteAttributeValue("", 8823, list.image_path, 8823, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:blue\"");
            BeginWriteAttribute("download", "  download=\"", 8859, "\"", 8871, 0);
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 8877, "\"", 8902, 2);
            WriteAttributeValue("", 8883, "../", 8883, 3, true);
#nullable restore
#line 230 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
WriteAttributeValue("", 8886, list.image_path, 8886, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\" /></a>\r\n");
            WriteLiteral("\r\n\r\n                            </td>\r\n\r\n                            <td>\r\n");
            WriteLiteral("                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 9586, "\"", 9626, 3);
            WriteAttributeValue("", 9596, "Edit(\'", 9596, 6, true);
#nullable restore
#line 239 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
WriteAttributeValue("", 9602, list.Registration_Id, 9602, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9623, "\');", 9623, 3, true);
            EndWriteAttribute();
            WriteLiteral("> Edit</button>\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 243 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
                        count++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>

            <div class=""form-group row"">
               
                <div class=""col-12 col-md-6 col-xl-4"">
                    <button class=""btn btn-danger mb-1"" id=""download"">Download all Data</button>
                </div>
            </div>

           
        </div>
");
#nullable restore
#line 257 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"norecord\"> No Record Found</div>\r\n");
#nullable restore
#line 261 "D:\#A\Subhasmiyta oracle\API\FstMonthExam\Exam.Web\Views\Sport\Sport_Registration.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""clearfix col-sm-12""></div>
    </div>
    <!--===================================================-->
    <!-- END BASIC FORM ELEMENTS -->
</div>

 <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.10.3/moment.min.js""></script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1f961c7bcb715cc590f31fa99e40d2fd9cc702147d2bfa110d75a759251fc6122361", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1f961c7bcb715cc590f31fa99e40d2fd9cc702147d2bfa110d75a759251fc6123425", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
  
    
  
    $(document).ready(function () {
      
       
        
    });

    $(""#download"").click(function () {
        var doc = {
            Registration_Id: 1
        }
        alert(""click"");
        $.ajax({
            url: ""/Sport/Download"",
            data: doc,
            type: ""GET"",
            success: function (result) {
               
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
        
    });
    //function nowAsDuration() {
    //    return moment.duration({
    //        hours: moment().hour(),
    //        minutes: moment().minute(),
    //        seconds: moment().second()
    //    });
    //}


    //$("".mystyle"").on(""change"", function () {
    //    var a = moment(this.value);
    //    var b = nowAsDuration();
    //    var c = a.add(b);
    //    this.setAttribute(""my-date"", c.format(this.getAttribute(""my-date-format""))
    //    ");
            WriteLiteral(@")
    //}).trigger(""change"")

    //function ChangeDateFormat() {

    //    $("".mystyle"").on(""change"", function () {
    //        var a = moment(this.value);
    //        var b = nowAsDuration();
    //        var c = a.add(b);
    //        this.setAttribute(""my-date"", c.format(this.getAttribute(""my-date-format""))
    //        )
    //    }).trigger(""change"")
    //}
  

    function GetAllSubCatByCId() {

        $.ajax({
            url: ""/Sport/GetSubCatByCId?clubid="" + $('#Club').val(),
            type: ""GET"",
            success: function (result) {
                data = JSON.parse(result);
                var v = ""<option value='0'>--Select--</option>"";
                $.each(data, function (i, item) {
                    v += ""<option value="" + item.Value + "">"" + item.Text + ""</option>"";
                });
                $(""#Sports"").html(v);
            },
            error: function (error) {
                jsonValue = jQuery.parseJSON(error.responseText);
    ");
            WriteLiteral(@"            bootbox.alert(""Error : "" + jsonValue);
            }
        });
    }

    function validate() {
          if ($('#Club').val() == ""0"") {
            alert(""Please Select Club !"");
            return false;
            $('#Club').focus();
        }

        else if ($('#Sports').val() == ""0"") {
            alert(""Please Select Sports !"");
            return false;
            $('#Sports').focus();
        }
       else if ($('#NAme').val() == """") {
            alert(""Please Enter Name!"");
            $('#NAme').focus();
            return false;
        }
        else if ($('#Email').val() == """") {
            alert(""Please Enter Email!"");
            return false;
            $('#Email').focus();
        }
        else if ($('#Mobile').val() == """") {
            alert(""Please Enter Mobile"");
            $('#Mobile').focus();
            return false;
          }
          else if ($('#dob').val() == """") {
              alert(""Please Select dob !"");
             ");
            WriteLiteral(@" return false;
              $('#dob').focus();
          }
        else if ($('#Gender').val() == ""0"") {
            alert(""Please Select Gender!"");
            $('#Gender').focus();
            return false;
        }
      

         
          else if ($('#Image').val() == """") {
              alert(""Please Select Image !"");
              return false;
              $('#Image').focus();
          }
        else
            return true;
      
       

    }
    function reset() {
        $('#PatientID').val("""");
        $(""#NAme"").val("""");
        $(""#Email"").val("""");
        $(""#Mobile"").val("""");
      
        $(""#db"").val("""");
      
        $(""#Gender"").val(""0"");
        $(""#Club"").val(""0"");
        $(""#Sports"").val(""0"");
    }
    $(""#btnCancel"").click(function () { reset()});

    $(""#btnSubmit"").click(function () {

        var files = $('#Image').prop(""files"");


        var url = ""Sport/UploadImage"";
        formData = new FormData();
        formData.app");
            WriteLiteral(@"end(""MyUploader"", files[0]);
      
        jQuery.ajax({
            type: 'POST',
            url: url,
            data: formData, 
            cache: false,
            contentType: false,
            processData: false,
            beforeSend: function (xhr) {
                xhr.setRequestHeader(""XSRF-Token"",
                    $('input:hidden[name=""__RequestVerificationToken""]').val());
            },
            success: function (repo) {
                if (repo.status == ""success"") {
                    //alert(""File : "" + repo.filename + "" is uploaded successfully"");
                }
            },
            error: function () {
                alert(""Error occurs"");
            }

        });



        var doc = {
            Registration_Id: $(""#PatientID"").val(),
            Applicant_name: $(""#NAme"").val(),
            Email: $(""#Email"").val(),
            Mobile_no: $(""#Mobile"").val(),
            image_path: $(""#Image"").val(),
            Gender: $("".s_typ");
            WriteLiteral(@"e:checked"").val(),
            dob: $(""#db"").val(),
            club_id: $(""#Club"").val(),
            sport_Id: $(""#Sports"").val(),
           

        };
        if (validate() && emailValidate('Email', 'lblError') == true && Phonevalidate('Mobile', 'lblErrorPhone') == true) {

            $.ajax({
                url: ""/Sport/Add"",
                data: doc,
                type: ""POST"",
                success: function (result) {
                    if (result == ""Record Saved Successfully"") {
                        alert(result)
                        window.location.href = ""/Sport/Sport_Registration"";
                    }
                    else if (result == ""Record Update Successfully"") {
                        alert(result)
                        window.location.href = ""/Sport/Sport_Registration"";
                    }
                    else
                        alert(result);
                },
                error: function (errormessage) {
                  ");
            WriteLiteral(@"  alert(errormessage.responseText);
                }
            });
        }
    });
    //UPDATE
    function Edit(id) {
       // ChangeDateFormat();
        $(""#btnSubmit"").html('Update')
        $.ajax({
            url: ""/Sport/MedicineGetById?id="" + id,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (result) {
                $(""#PatientID"").val(id);
                $(""#NAme"").val(result.Applicant_name);
                $(""#Email"").val(result.Email);
                $(""#Mobile"").val(result.Mobile_no);

                $.ajax({
                    url: ""/Sport/GetSubCatByCId?clubid="" + result.club_id,
                    type: ""GET"",
                    success: function (result1) {
                        data = JSON.parse(result1);
                        var v = ""<option value='0'>--Select--</option>"";
                        $.each(data, function (i, item) {
                 ");
            WriteLiteral(@"           v += ""<option value="" + item.Value + "">"" + item.Text + ""</option>"";
                        });

                        $(""#Sports"").html(v);
                        $(""#Sports"").val(result.sport_Id);
                       
                    },
                    error: function (error) {
                        jsonValue = jQuery.parseJSON(error.responseText);
                        bootbox.alert(""Error : "" + jsonValue);
                    }
                });
          
                $('input[type=""radio""]').each(function () {
                    if ($(this).val() == result.Gender) {
                        $(this).attr('checked', 'checked');
                    }
                });
                $(""#db"").val(result.dob);
             
                $(""#Club"").val(result.club_id);

                $(""#si"").attr(""src"",""../""+result.image_path);
               
            },
            error: function (errormessage) {
                alert(errormessage.resp");
            WriteLiteral("onseText);\r\n            }\r\n        });\r\n        return false;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam.Domain.Sports.Spot> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
