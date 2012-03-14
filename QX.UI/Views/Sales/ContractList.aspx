<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ContractList
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <%--    <%Html.RenderPartial("ToolBarControl", "contr"); %>
    <%Html.RenderPartial("GridControl", "contr"); %>--%>
  
    <script type="text/javascript">
        var ContractList_CType = '<%=ViewData["CType"] %>';
        var ContractList_VStep = '<%=ViewData["VStep"] %>';
        $(function() {
            $("#tabs").tabs();
            Sales_ContractList.InitData();
        });
        

        function contrToolBarAdd() {
            location = "/Sales/AddContract/" + ContractList_CType;
        }

        function contrToolBarEdit() {
            var grid = $('#contrgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDC_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            location = "/Sales/EditContract/" + data.SDC_Code +"-"+ ContractList_CType;
        }

        function contrToolBarDelete() {
            var grid = $('#contrgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDC_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    $.ajax({
                        type: 'post',
                        url: '/Sales/DeleteContract',
                        data: { code: data.SDC_Code },
                        success: function(data) {
                            if (data == "success") {
                                grid.trigger('reloadGrid');
                            }
                            else {
                                ShowMsg("删除失败!");
                            }
                        }
                    });
                }
            });

        }
        //end

    </script>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">销售合同</a></li>
            <li><a href="#tabs-2">审核中合同</a></li>
            <li><a href="#tabs-3">全部合同</a></li>
            <li><a href="#tabs-4">我的草稿</a></li>
        </ul>
        <div id="tabs-1">
            <%Html.RenderPartial("ToolBarControl", "contr"); %>
            <%Html.RenderPartial("GridControl", "contr"); %>
            
        </div>
        <div id="tabs-2">
            <%Html.RenderPartial("ToolBarControl", "onAudit"); %>
            <%Html.RenderPartial("GridControl", "onAudit"); %>
        </div>
        <div id="tabs-3">
            <%Html.RenderPartial("ToolBarControl", "allContr"); %>
            <%Html.RenderPartial("GridControl", "allContr"); %>
        </div>
        <div id="tabs-4">
            <%Html.RenderPartial("ToolBarControl", "draft"); %>
            <%Html.RenderPartial("GridControl", "draft"); %>
        </div>
    </div>
    
    
    <% Html.RenderPartial("AuditControl");%>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
