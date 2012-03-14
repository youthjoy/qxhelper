<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.ChartConfig>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	物料采购计划数量趋势
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="formOP" name="formOp" action="/ChartReport/MMPPTrend/Report_MMPP">
    <div id="GeneralOne_toolbar" class="toolbar">
        <ul>
            <li style="float: left"><span>部门:</span>
                <input type="hidden" name="DeptCode" id="DeptCode" value="<%=ViewData["DeptCode"]%>" />
                <input type="text" readonly="true" class="form_textbox  TextBoxReadOnly  popup" name="Dept"
                    id="Dept" value="<%=ViewData["Dept"]%>" />
            </li>
            <li style="float: left; margin-left: -20px;"><span>公司:</span>
                <input type="hidden" name="CompanyCode" id="CompanyCode" value="<%=ViewData["CompanyCode"]%>" />
                <input type="text" readonly="true" class="form_textbox  TextBoxReadOnly" name="Company"
                    id="Company" value="<%=ViewData["Company"]%>" />
            </li>
            <li style="float: left; margin-left: -20px;"><span>分组条件:</span>
                <select id="Xit" name="Xit">
                    <option value="Days">天</option>
                    <option value="Months">月</option>
                    <option value="Years">年</option>
                </select>
            </li>
            <li style="float: left; margin-left: -20px;"><span>开始时间:</span>
                <input onclick="WdatePicker()" class="date_icon" type="text" name="StartDate" id="StartDate"
                    value="<%=ViewData["StartDate"]%>" />
            </li>
            <li style="float: left; margin-left: -20px;"><span>结束时间:</span>
                <input onclick="WdatePicker()" class="date_icon" type="text" name="EndDate" id="EndDate"
                    value="<%=ViewData["EndDate"]%>" />
            </li>
            <li style="display: block" id="" class=""><a id="btnSubmit" name="btnSubmit" style="cursor: pointer">
                确定 </a></li>
        </ul>
    </div>
       </form>
  <%=Html.ChartToolBar("Report_MMPP")%>
        
       
    <DIV style=" clear:both; float: left">
    <%Html.RenderPartial("QXChart", (QX.Model.ChartConfig)Model);%>
    </DIV>
    
    <script type="text/javascript">

        var FilterType = '<%=ViewData["Xit"]%>';

        $(function() {
            var dept = $("#Dept");
            var deptCode = $("#DeptCode");
            var company = $("#Company");
            var companyCode = $("#CompanyCode");
            var Start = $("#StartDate");
            var End = $("#EndDate");
            
            
            Common_Tree_Dept.Init("Dept", function(code, name, rootCode, rootName) {
                dept.val(name);
                deptCode.val(code);
                company.val(rootCode);
                companyCode.val(rootName);
            });
            
            
            $("#btnSubmit").click(function() {
                if (dept.val() == "" || company.val() == "" || Start.val() == "" || End.val() == "") {
                    ShowMsg("请将选择条件填定完整");
                } else {
                    $("#formOP").submit();
                }
            });

            $("#Xit").val(FilterType);
        })
    </script>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
