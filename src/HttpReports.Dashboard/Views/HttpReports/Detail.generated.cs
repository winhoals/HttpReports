﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HttpReports.Dashboard.Views
{
    using System;
    
    #line 3 "..\..\Views\HttpReports\Detail.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class Detail : HttpReports.Dashboard.Views.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




            
            #line 4 "..\..\Views\HttpReports\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

    var nodes = ViewData["nodes"] as List<string>;

    var lang = ViewData["Language"] as HttpReports.Dashboard.Services.Language.ILanguage;

    Layout = new HttpReports.Dashboard.Views.HttpReportsTemplate { Context = Context, ViewData = ViewData };



            
            #line default
            #line hidden
WriteLiteral(@"

<script src=""/HttpReportsStaticFiles/Content/js/mSlider.min.js""></script>
<script src=""/HttpReportsStaticFiles/Content/js/jquery.nicescroll.js""></script>

<style type=""text/css"">

    .pagination {
        float: right;
        margin: 0;
        margin-top: -18px;
    }

    .pull-left {
        margin-top: 20px;
        padding-left: 20px;
    }

    .pull-right {
        margin-top: 20px;
        padding-right: 20px;
    }

    tbody {
        margin-bottom: 20px;
    }
</style>

<div class=""panel panel-default"">

    <div class=""panel-body"" style=""padding-left:30px;padding-right:30px;padding-top:30px;min-height:720px;padding-bottom:30px"">

        <div class=""row"" style=""padding-left:13px;padding-right:13px"">

            <div class=""panel panel-default"">
                <div class=""panel-body shadow-box"" style=""padding-bottom:20px"">

                    <div class=""form-inline form"">

                        <div class=""col-sm-12"" style=""margin-top:10px"">

                            <b> <b><i class=""glyphicon glyphicon-signal""></i> ");


            
            #line 55 "..\..\Views\HttpReports\Detail.cshtml"
                                                                         Write(lang.Index_ServiceNode);

            
            #line default
            #line hidden
WriteLiteral("</b></b>\r\n\r\n                            <span class=\"glyphicon glyphicon-info-sig" +
"n serviceTip\" style=\"font-size:20px;top:0.2em;cursor:pointer\"></span>\r\n\r\n       " +
"                     ");



WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"col-sm-12" +
" node-row\" style=\"margin-top:8px;margin-bottom:8px;min-height:44px\">\r\n\r\n");


            
            #line 66 "..\..\Views\HttpReports\Detail.cshtml"
                             foreach (var item in nodes)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <button onclick=\"check_node(this)\" style=\"width:1" +
"20px;margin-left:20px;border-radius:4px;\" class=\"btn btn-info service-button\">");


            
            #line 68 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                          Write(item);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");


            
            #line 69 "..\..\Views\HttpReports\Detail.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral(@"                        </div>
                    </div>

                    <div class=""form-inline form"" style=""margin-bottom:30px;"">

                        <div class=""col-sm-3"">
                            <label class=""form-label"">TraceId</label>
                            <input type=""text"" class=""form-control traceId"">
                        </div>

                        <div class=""col-sm-3"">
                            <label class=""form-label"">");


            
            #line 81 "..\..\Views\HttpReports\Detail.cshtml"
                                                 Write(lang.StatusCode);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input type=\"text\" class=\"form-control stat" +
"usCode\">\r\n                        </div>\r\n\r\n                        <div class=\"" +
"col-sm-3\">\r\n                            <label class=\"form-label\">");


            
            #line 86 "..\..\Views\HttpReports\Detail.cshtml"
                                                 Write(lang.StartTime);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                            <input type=""text"" onfocus=""ClearTimeRange()"" class=""form-control laydate start"">
                        </div>

                        <div class=""col-sm-3"">
                            <label class=""form-label"">");


            
            #line 91 "..\..\Views\HttpReports\Detail.cshtml"
                                                 Write(lang.EndTime);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input onfocus=\"ClearTimeRange()\" type=\"tex" +
"t\" class=\"form-control laydate end\">\r\n                        </div>\r\n\r\n        " +
"                <div class=\"col-sm-3\">\r\n                            <label class" +
"=\"form-label\">");


            
            #line 96 "..\..\Views\HttpReports\Detail.cshtml"
                                                 Write(lang.Request_RequestUrl);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <input type=\"text\" class=\"form-control layd" +
"ate url\">\r\n                        </div>\r\n\r\n                        <div class=" +
"\"col-sm-3\">\r\n                            <label class=\"form-label\">");


            
            #line 101 "..\..\Views\HttpReports\Detail.cshtml"
                                                 Write(lang.Request_IPAddress);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                            <input placeholder="""" type=""text"" class=""form-control laydate ipadress"">
                        </div>


                    </div>

                    <div class=""col-sm-12 timeSelect"" style=""margin-top:20px"">

                        <button type=""button""  data-minute=""15"" onclick=""timeChange(this,15)"" style=""width:60px;margin-right:8px;"" class=""btn btn-default btn-xs"">");


            
            #line 110 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                             Write(lang.Time_15m);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\r\n                        <button type=\"button\" data-minute=\"30\" oncli" +
"ck=\"timeChange(this,30)\" style=\"width:60px;margin-right:8px;\" class=\"btn btn-def" +
"ault btn-xs\">");


            
            #line 112 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                            Write(lang.Time_30m);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\r\n                        <button type=\"button\" data-minute=\"60\" oncli" +
"ck=\"timeChange(this,60)\" style=\"width:60px;margin-right:8px;\" class=\"btn btn-def" +
"ault btn-xs\">");


            
            #line 114 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                            Write(lang.Time_1h);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\r\n                        <button type=\"button\" data-minute=\"240\"  onc" +
"lick=\"timeChange(this,60*4)\" style=\"width:60px;margin-right:8px;\" class=\"btn btn" +
"-default btn-xs\">");


            
            #line 116 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                                Write(lang.Time_4h);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\r\n                        <button type=\"button\" data-minute=\"720\" oncl" +
"ick=\"timeChange(this,60*12)\" style=\"width:60px;margin-right:8px;\" class=\"btn btn" +
"-default btn-xs\">");


            
            #line 118 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                                Write(lang.Time_12h);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\r\n                        <button type=\"button\" data-minute=\"1440\" onc" +
"lick=\"timeChange(this,60*24)\" style=\"width:60px;margin-right:8px;\" class=\"btn bt" +
"n-default btn-xs\">");


            
            #line 120 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                                 Write(lang.Time_24h);

            
            #line default
            #line hidden
WriteLiteral(@"</button>

                    </div>

                    <div class=""col-sm-12"">

                        <div class=""col-sm-3"" style=""padding-left:0"">

                            <button style=""min-width:120px;"" onclick=""QueryClick(this)"" class=""btn btn-info btn-search"">");


            
            #line 128 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                   Write(lang.Query);

            
            #line default
            #line hidden
WriteLiteral(@"</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""panel panel-default"">
                <div class=""panel-body shadow-box"" style=""padding-bottom:20px"">

                    <div class=""col-sm-12"" style=""margin-top:24px;"">

                        <table id=""TableData"" class=""table table-bordered"" style=""background-color:#FFF;width:100%;margin:0 auto; clear:both;border-top:2px solid #67c2ef;""></table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""contextBox"" style=""display:none;"">

    <h3 class=""request_detail_notfound"" style=""display:none"">");


            
            #line 149 "..\..\Views\HttpReports\Detail.cshtml"
                                                        Write(lang.Request_NotFound);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n    <h3 class=\"request_detail_title\" style=\"padding-left:6px;margin-bott" +
"om:16px\"><i class=\"fa fa-star-half-o\" style=\"margin-right:10px\"></i> ");


            
            #line 151 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                        Write(lang.Request_BasicInfo);

            
            #line default
            #line hidden
WriteLiteral(@"</h3>

    <table class=""table table-striped table-bordered"" style=""word-break:break-all"">
        <thead>
            <tr>
                <th width=""160"">Key</th>
                <th>Value</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>RequestId</td>
                <td class=""context_requestId"" style=""text-align:left;font-size:12px;padding-left:8px""></td>
            </tr>
            <tr>
                <td>");


            
            #line 166 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Index_ServiceNode);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_node\" style=\"text-align:left;font-size:" +
"12px;padding-left:8px\"></td>\r\n            </tr>\r\n            <tr>\r\n             " +
"   <td>");


            
            #line 170 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_Route);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_route\" style=\"text-align:left;font-size" +
":12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n          " +
"      <td>");


            
            #line 175 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_Url);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_url\" style=\"text-align:left;font-size:1" +
"2px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n            " +
"    <td>");


            
            #line 180 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_method\" style=\"text-align:left;font-siz" +
"e:12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n         " +
"       <td>");


            
            #line 185 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_Connection);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_requestType\" style=\"text-align:left;fon" +
"t-size:12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n    " +
"            <td>");


            
            #line 190 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_Time);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_milliseconds\" style=\"text-align:left;fo" +
"nt-size:12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n   " +
"             <td>");


            
            #line 195 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_StatusCode);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_statusCode\" style=\"text-align:left;font" +
"-size:12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n     " +
"           <td>");


            
            #line 200 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_RemoteIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_ip\" style=\"text-align:left;font-size:12" +
"px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n             " +
"   <td>");


            
            #line 205 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_RemotePort);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_port\" style=\"text-align:left;font-size:" +
"12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n           " +
"     <td>");


            
            #line 210 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_LocalIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_localIp\" style=\"text-align:left;font-si" +
"ze:12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n        " +
"        <td>");


            
            #line 215 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_LocalPort);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_localPort\" style=\"text-align:left;font-" +
"size:12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n      " +
"          <td>");


            
            #line 220 "..\..\Views\HttpReports\Detail.cshtml"
               Write(lang.Request_CreateTime);

            
            #line default
            #line hidden
WriteLiteral(@"</td>
                <td class=""context_createTime"" style=""text-align:left;font-size:12px;padding-left:6px""></td>
            </tr>


        </tbody>
    </table>

    <h3 class=""request_detail_title"" style=""padding-left:6px; margin-top:20px;margin-bottom:16px""><i class=""fa fa-space-shuttle"" style=""margin-right:10px""></i>  ");


            
            #line 228 "..\..\Views\HttpReports\Detail.cshtml"
                                                                                                                                                            Write(lang.Request_DetailInfo);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n    <table class=\"table table-striped table-bordered\" style=\"word-break:" +
"break-all\">\r\n        <thead>\r\n            <tr>\r\n                <th width=\"160\">" +
"Key</th>\r\n                <th>Value</th>\r\n            </tr>\r\n        </thead>\r\n " +
"       <tbody>\r\n            <tr>\r\n                <td>QueryString</td>\r\n        " +
"        <td class=\"context_queryString\" style=\"text-align:left;font-size:12px\"><" +
"/td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Header</td>\r\n  " +
"              <td class=\"context_header\" style=\"text-align:left;font-size:12px\">" +
"</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Cookie</td>\r\n " +
"               <td class=\"context_cookie\" style=\"text-align:left;font-size:12px\"" +
"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>RequestBody</" +
"td>\r\n                <td class=\"context_requestBody\" style=\"text-align:left;font" +
"-size:12px\"></td>\r\n            </tr>\r\n\r\n\r\n            <tr>\r\n                <td>" +
"ResponseBody</td>\r\n                <td class=\"context_responseBody\" style=\"text-" +
"align:left;font-size:12px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n       " +
"         <td>Error</td>\r\n                <td class=\"context_error\" style=\"text-a" +
"lign:left;font-size:12px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n        " +
"        <td>ErrorStack</td>\r\n                <td class=\"context_errorStack\" styl" +
"e=\"text-align:left;font-size:12px\"></td>\r\n            </tr>\r\n\r\n\r\n        </tbody" +
">\r\n    </table>\r\n\r\n</div>\r\n\r\n<script src=\"/HttpReportsStaticFiles/Content/page/d" +
"etail.js?ver=1.0.5\"></script>");


        }
    }
}
#pragma warning restore 1591
