<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.System_Menu>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <script type="text/javascript">
         $(function() {
             MenusOperation.Init("Create");
         });
    </script>

    <% using (Html.BeginForm("Create", "Menus"))
       {
    %>
    
    <div id="container" style="width: 831px;">
        <div id="leftSide">
            <fieldset style="width: 800px;">
                <legend>基本信息</legend>
                <%=Html.BindModelToControl<QX.Model.System_Menu>("System_Menu", Model)%>
            </fieldset>
        </div>
    </div>
    <div class="clear">
    </div>
    <input class="button_style" type="submit" value="提交" />
    <input class="button_style" type="button" value="返回" onclick="javascript:location='/Menus/Index'" />
    <%}%>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
