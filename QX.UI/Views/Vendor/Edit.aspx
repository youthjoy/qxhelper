<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.WH_Supplier>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit.aspx
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
     $(function() {
        VendorOperation.Init("edit");
     });
    </script>
    <%using (Html.BeginForm("EditCEItem", "Vendor"))
      { %>
    <div id="container" style="width: 831px;">
        <div id="leftSide">
            <fieldset style="width: 800px;">
                <legend>基本信息</legend>
                 <input type="hidden" name="MV_CustCode" id="MV_CustCode" value='<%= ViewData.Model.MV_CustCode%>' />
                 <input type="hidden" name="MV_IDS" id="MV_IDS" value='<%= ViewData.Model.MV_IDS%>' />
                <%=Html.BindModelToControl<QX.Model.WH_Supplier>("WH_Supplier", Model)%>
            </fieldset>
        </div>
    </div>
    <div class="clear">
    </div>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">供应商评审</a></li>
            <li><a href="#tabs-2">供应商发票</a></li>
            <li><a href="#tabs-3">供应商财务</a></li>
            <li><a href="#tabs-4">供应商合同</a></li>                      
            <li><a href="#tabs-5">联系人</a></li>    
            <li><a href="#tabs-6">附件</a></li>                
        </ul>    
        
        <div id="tabs-1">
   
            <%Html.RenderPartial("GridControl", "ps");%>
        </div>
         <div id="tabs-2">
         <%Html.RenderPartial("ToolBarControl",""); %>  
         <%Html.RenderPartial("GridControl", "fp");%>
        </div>
         <div id="tabs-3">
           <%Html.RenderPartial("ToolBarControl","cw"); %> 
            <%Html.RenderPartial("GridControl", "cw"); %>
        </div>
         <div id="tabs-4">
           <%Html.RenderPartial("ToolBarControl","ht"); %> 
            <%Html.RenderPartial("GridControl", "ht"); %>
        </div>
         <div id="tabs-5">
           
        </div>
         <div id="tabs-6">
            
        </div>
      
    </div>
    <input type="submit" value="提交" />
    <input type="button" value="返回" onclick="javascript:location='<%=Url.Action("index","EquProcurement")%>'" />
    <%} %>
    
    <script type="text/javascript">  
    
    //发票     
     function ToolBarAdd() {
         window.location = "/Invoice/Index/?make=-1";
        }
        function ToolBarEdit() {
            debugger;
            var grid = $("#fpgrid");
            
            var curid = grid.getGridParam("selrow");
            var data = grid.getRowData(curid);
            if (data.WHI_SCode == undefined) {
                alert("请选中编辑行");
                return;
            }
            window.location = "/Invoice/Index/?make=" + data.WHI_SCode;
        }
        function ToolBarDelete() {

        }

//财务

//合同
        function htToolBarAdd() {
            window.location = "/Vendor/WH_Contract/?make=-1";
        }
        function htToolBarEdit() {
            debugger;
            var grid = $("#htgrid");

            var curid = grid.getGridParam("selrow");
            var data = grid.getRowData(curid);
            if (data.Contract_Code == undefined) {
                alert("请选中编辑行");
                return;
            }
            window.location = "/Vendor/WH_Contract/?make=" + data.Contract_Code;
        }
        function htToolBarDelete() {

        }
        
        
        </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
