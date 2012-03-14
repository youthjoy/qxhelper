<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.WH_Supplier>" %>


<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    客户信息编辑
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    

    <script type="text/javascript">
        $(function() {


            Customer_Operation.InitData();


        });  //end

        function custToolBarAdd() {

        }


        function custToolBarEdit() {
            var grid = $('#custgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.PUM_RCode == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
        }

        function custToolBarDelete() {

        }
             
    </script>
  <%=Html.BindValidateToControl<QX.Model.WH_Supplier>("customerInfoForm")%>
    <div id="customerInfo">
        <form id="customerInfoForm" method='post' action="/Sales/CustomerOperation">
        <input type='hidden' name='CustomerFormoper' id='CustomerFormoper' value='edit' />
        <%=Html.BindComModelToControl<QX.Model.WH_Supplier>("SD_CustMain",Model)%>
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">基本信息</a></li>
                <li><a href="#tabs-2">联系人</a></li>
                <li><a href="#tabs-3">联系地址</a></li>
                <li><a href="#tabs-4">采购往来</a></li>
                <li><a href="#tabs-5">结算情况</a></li>
                <li><a href="#tabs-6">付款情况</a></li>
               <%-- <li><a href="#tabs-7">附件</a></li>--%>
            </ul>
            <div id="tabs-1">
                <%=Html.BindComModelToControl<QX.Model.WH_Supplier>("SD_CustDet", Model)%>
            </div>
        </form>
        <div id="tabs-2">
            <%=Html.AttachComponent("Bse_ContactsModule", "Bse_Contacts","Customer", Model.WHS_CustCode)%>
        </div>
        <div id="tabs-3">
            <%=Html.AttachComponent("Bse_AddressModule", "Bse_Address", "Customer", Model.WHS_CustCode)%>
        </div>
        <div id="tabs-4">
            <%Html.RenderPartial("ToolBarControl", "PU"); %>
            <%Html.RenderPartial("GridControl", "pu"); %>
        </div>
        <div id="tabs-5">
            <%Html.RenderPartial("GridControl", "ban"); %>
        </div>
        <div id="tabs-6">
            <%Html.RenderPartial("GridControl", "pay"); %>
        </div>
       <%-- <div id="tabs-7">
        
        </div>--%>
    </div>
    </div>
    <input class="hide" type='button' name='button' value='提交' onclick='Customer_Operation.SaveData()' />
    <input type='button' name='cancle' value='返回' onclick='Customer_Operation.CancelEdit()' />
    </div>
    <% Html.RenderPartial("DialogControl"); %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
<script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
