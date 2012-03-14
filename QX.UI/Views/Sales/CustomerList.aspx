<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CustomerList
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <%=Html.JqGridListPage("WH_CustModule",
                     "WH_Supplier",
                "Cust",
               "","",true)%>

    <script type="text/javascript">

        function WH_Supplier_WH_CustModuleToolBarAdd() {
            window.location = '/Sales/AddCustomer';
        }


        //cl:查看
        $(function() {
        $("#WH_Supplier_WH_CustModule_view").unbind();
        $("#WH_Supplier_WH_CustModule_view").live("click", function() {
            All_CustomerList();
            });

        });

        //cl:查看
        function All_CustomerList() {
            var grid = $('#WH_Suppliergrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.WHS_CustCode == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            else {
                window.location = '/Sales/EditCustomer/' + data.WHS_CustCode + '?view=1';
            }
        }
        
        
        
        
        
        

        function WH_Supplier_WH_CustModuleToolBarEdit() {
            var grid = $('#WH_Suppliergrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.WHS_CustCode == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            window.location = '/Sales/EditCustomer/' + data.WHS_CustCode;
        }

        function WH_Supplier_WH_CustModuleToolBarSearch() {

            WH_Supplier_WH_CustModule_GridControl.Search();
        }
        function WH_Supplier_WH_CustModuleToolBarDelete() {
            var grid = $('#WH_Suppliergrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.WHS_CustCode == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    WH_Supplier_WH_CustModule_GridControl.Delete(data.WHS_CustCode);
                }
            });
        }
    </script>
  
    

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
