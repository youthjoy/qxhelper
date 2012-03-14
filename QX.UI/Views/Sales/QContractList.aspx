<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	业务合同管理
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="tabs">
        <ul>
           <%-- <li><a href="#tabs-1">销售合同</a></li>
            <li><a href="#tabs-2">审核中合同</a></li>--%>
            <li><a href="#tabs-3">全部合同</a></li>
         <%--   <li><a href="#tabs-4">我的草稿</a></li>--%>
        </ul>
        <%--<div id="tabs-1">
        <%=Html.Common_ToolBarForListPage("LastAudit", "addN:'添加合同',addFunJs:'Add(\"" + ViewData["CType"] + "\")',editN:'查看合同',editFunJs:'View()',delN:'合同失效',delFunJs:'Delete(\"CStat\")',searchN:'搜索',searchFunJs:'',exportN:'修订合同',exportFunJs:'Edit()',viewN:'查看',viewFunjs:'View()'")%>
         <%=Html.JqGrid("SD_ContractModule", "LastAudit", "Cust", "LastAudit")%>   
                 
        </div>
        <div id="tabs-2">
        <%=Html.Common_ToolBarForListPage("OnAudit", "addN:'添加合同',addFunJs:'Add(\"" + ViewData["CType"] + "\")',editN:'查看合同',editFunJs:'View()',delN:'合同失效',delFunJs:'Delete(\"CStat\")',searchN:'合同审核',searchFunJs:'Audit()',viewN:'查看',viewFunjs:'View()'")%>
        <%=Html.JqGrid("SD_ContractModule", "OnAudit", "Cust", "OnAudit")%>
        </div>--%>
        <div id="tabs-3">
       <%-- <%=Html.Common_ToolBarForListPage("All", "add:'false',editN:'查看合同',editFunJs:'View()',searchN:'搜索',searchFunJs:'',viewN:'查看',viewFunjs:'View()'")%>--%>
        <%=Html.Common_ToolBarForListPage("All", "searchN:'搜索',searchFunJs:'',viewN:'查看',viewFunjs:'View()'")%>
          <%=Html.JqGrid("SD_ContractModule", "All", "Cust", "All")%>
        </div>
    <%--    <div id="tabs-4">
        <%=Html.Common_ToolBarForListPage("Draft", "addN:'添加合同',addFunJs:'Add(\"" + ViewData["CType"] + "\")',editN:'查看合同',editFunJs:'View()',delN:'删除合同',delFunJs:'Delete(\"Stat\")',searchN:'编辑合同',searchFunJs:'Edit()',viewN:'查看',viewFunjs:'View()'")%>
        <%=Html.JqGrid("SD_ContractModule", "Draft", "Cust", "Draft")%>   
        </div>--%>
    </div>
 <% Html.RenderPartial("AuditControl");%>
<script type="text/javascript">
   $(function() {
    $("#tabs").tabs();
})

function LastAudit_ToolBarSearch() {
    LastAudit_SD_ContractModule_GridControl.Search();
}

function All_ToolBarSearch() {
    All_SD_ContractModule_GridControl.Search();
}
</script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Comonlist.js" type="text/javascript"></script>
    <script src="/Scripts/Sales/Contract_JS.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
