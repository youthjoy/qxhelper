<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.WH_Supplier>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    供应商添加
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <script type="text/javascript">
     $(function() {
         VendorOperation.Init("edit");
     });
    </script>
    <%using (Html.BeginForm("VendorADD", "Vendor"))
      { %>
    <div id="container" style="width: 831px;">
        <div id="leftSide">
            <fieldset style="width: 800px;">
                <legend>基本信息</legend>   
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
            <%Html.RenderPartial("GridControl", "fp");%>
        </div>
         <div id="tabs-3">
            <%Html.RenderPartial("GridControl", "cw"); %>
        </div>
         <div id="tabs-4">
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
