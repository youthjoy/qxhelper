
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.WH_Contract>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	WH_ContractAdd
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <% using (Html.BeginForm("WH_Contractadd", "Vendor"))
       {%>
    <div id="container" style="width: 831px;">
        <div id="leftSide">
            <fieldset style="width: 800px;">
                <legend>基本信息</legend>
                <%=Html.BindModelToControl<QX.Model.WH_Contract>("WH_Contract", Model)%>
            </fieldset>
        </div>
    </div>
    <div class="clear">
    </div>
    <input type="submit" value="提交" />
    <%}%>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
