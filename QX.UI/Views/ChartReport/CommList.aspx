<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CommList
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="width:100%">    
        <div>
        
        <form id="FormOP" action="/ChartReport/GetData/<%=ViewData["Module"].ToString()%>/">
            <%=Html.ChartToolBar(ViewData["Module"].ToString())%>    
        </form>
        
        </div>
        <div style="clear:both">
        <%=Html.SysComm_JqGrid(ViewData["Module"].ToString(), "RptDetail", "/ChartReport/GetData/"+ViewData["Module"], "", "", "", "", true)%>   
        </div>       
    </div>
    
    <script>
        var FormID = "#FormOP";
        var grid = $("#RptDetailgrid");
        $(function() {
            var options = {
                success: function(data) { if (data.result == "success") {   } },  // post-submit callback
                width: 800,
                timeout: 3000
            };
            //采购主表表单
            $(FormID).ajaxForm(options);
            
        });
        function SubMitData() {
            //$(FormID).submit();
            //alert($(FormID).serialize());
            grid.setGridParam({ postData: { data: $(FormID).serialize() }, url: '/ChartReport/GetData/<%=ViewData["Module"].ToString()%>' }).trigger('reloadGrid');                    
        }
        
        
        
    </script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
