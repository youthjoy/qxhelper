<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
 
<%=Html.BindComModelToControl<QX.Model.PU_Detail>("PU_Detail")%>