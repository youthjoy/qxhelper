<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	供应商管理
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">  
 <%Html.RenderPartial("ToolBarControl",""); %>      
     <%Html.RenderPartial("GridControl", ""); %>    
     <script type="text/javascript">
         function ToolBarAdd() {
             window.location="/Vendor/Create";
         }
         function ToolBarEdit() {
             var grid = $("#grid");
             var curid = grid.getGridParam("selrow"); //获取选择行的id
             var data = grid.getRowData(curid); //获取行号为curid的数据
             if (data.MV_CustCode == undefined) {
                 alert("请选中编辑行");
                 return;
             }

             window.location = "/Vendor/Edit/" + data.MV_CustCode;
         }
         function ToolBarDelete() {

         }
     </script>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="TopMenu">
  </asp:Content>

