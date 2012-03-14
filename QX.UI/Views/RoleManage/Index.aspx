<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <%=Html.RoleManage((IList<QX.Model.Sys_Function>)ViewData["RoleTree"])%>
    
    
    <%--<div>
        <ul>
        <li>xxx1<input type="checkbox" name="xx" id="xx" checked="checked" />
            <div>
                <ul>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                </ul>
            </div>
        </li>      
        <li>
            xxx2
             <div>
                <ul>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                </ul>
            </div></li>
        <li> <div>
                <ul>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                </ul>
            </div></li>
        <li> <div>
                <ul>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                	<li>sssss</li>
                </ul>
            </div></li>
        </ul>
    </div>
--%>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
