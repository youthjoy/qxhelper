<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	编辑客户合同信息
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <script type="text/javascript">
        $(function() {

               Contract_Operation.InitData();

        });   //end

        function contrToolBarAdd() {

        }

        function contrToolBarEdit() {
            var grid = $('#contrgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDC_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
        }

        function contrToolBarDelete() {

        }
             
    </script>
    <%=Html.ReferControl("Ref_Cusomter", "WH_Supplier",false)%>
    <%=Html.BindValidateToControl<QX.Model.SD_Contract>("ContractInfoForm") %>
    <div id="ContractInfo">
        <form id="ContractInfoForm" method='post' action="/Sales/ContractOperation">
        <input type='hidden' name='ContractFormoper' id='ContractFormoper' value='add' />
        <%=Html.BindComModelToControl<QX.Model.SD_Contract>("SD_ConMain")%>
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">基本信息</a></li>
                <li><a href="#tabs-2">联系人</a></li>
                <li><a href="#tabs-3">联系地址</a></li>
            </ul>
            <div id="tabs-1">
                <%=Html.BindComModelToControl<QX.Model.SD_Contract>("SD_ConDet")%>
            </div>
        </form>
        <div id="tabs-2">
            <% Html.RenderPartial("DialogControl"); %>
            <%=Html.AttachComponent("Bse_ContactsModule", "Bse_Contacts","Contract","")%>
        </div>
        <div id="tabs-3">
            <%=Html.AttachComponent("Bse_AddressModule", "Bse_Address", "Contract", "")%>
        </div>
    </div>
    <input type='button' name='button' value='草稿' onclick='Contract_Operation.SaveDraft()' />
   <%-- <input type='button' name='button' value='提交' onclick='Contract_Operation.SaveData()' />    --%>
    <input type='button' name='cancle' value='返回' onclick='Contract_Operation.CancelEdit()' />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Session.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
