<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<script type="text/javascript">
    $(document).ready(function() {
    $("#CHR_CanteenItemCode").click(function() {
            Bse_CanteenItemModuleBse_CanteenItemOpenRefer('Bse_CanteenItemModule', 'Bse_CanteenItem',
            function(data) {
                $("#CIR_CanteenItemCode").val(data.CanteenItem_Code);
                $("#CHR_Company").val(data.CanteenItem_Company);
                $("#CHR_Dept").val(data.CanteenItem_Department);

            });
        })

    });
</script>

<%=Html.ReferControl("Bse_CanteenItemModule", "Bse_CanteenItem")%>  