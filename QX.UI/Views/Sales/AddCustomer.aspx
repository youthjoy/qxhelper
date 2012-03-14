<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AddCustomer
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <script type="text/javascript">
        $(function() {
               Customer_Operation.InitData();

        });   //end

        function custToolBarAdd() {

        }

        function custToolBarEdit() {
            var grid = $('#supgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.PUM_RCode == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
        }

        function supToolBarDelete() {

        }
             
    </script>    
    
    <div id="customerInfo">
        <form id="WH_Supplier_Top_Form" method='post' action="/Sales/CustomerOperation">
        <input type='hidden' name='CustomerFormoper' id='CustomerFormoper' value='add' />
    <%=Html.AutoBindForm("WH_CustModule", "WH_Supplier_Top", false, false, false)%>
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">基本信息</a></li>
                <li><a href="#tabs-2">联系人</a></li>
                <li><a href="#tabs-3">联系地址</a></li>
            </ul>
            <div id="tabs-1">
                       <%=Html.AutoBindForm("WH_CustModule", "WH_SupplierOther", false, false, false)%> 
            </div>
        </form>
        <div id="tabs-2">            
            <%=Html.AttachComponent("Bse_ContactsModule", "Bse_Contacts", "Customer", "$('#WHS_CustCode')")%>
        </div>
        <div id="tabs-3">
            <%=Html.AttachComponent("Bse_AddressModule", "Bse_Address", "Customer", "$('#WHS_CustCode')")%>
        </div>
    </div>
    <input type='button' name='button' value='提交' onclick='Customer_Operation.SaveData()' />
    <input type='button' name='cancle' value='返回' onclick='Customer_Operation.CancelEdit()' />


    <%=Html.AutoBindValidate("WH_CustModule")%>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
