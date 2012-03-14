<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<%=Html.ReferControl("WH_SupplierModule", "WH_Supplier", false)%>


<script type="text/javascript">
    $(document).ready(function() {
    $("#PUD_Udef1").bind("click", function() {
        WH_SupplierModuleWH_SupplierOpenReferWithFilter(" PCTI_iType='logistics'  and PCTI_Status<>'15' ", function(data) {
        $("#PUD_Udef1").val(data.WHS_CustCode);
        $("#PUD_Udef2").val(data.WHS_CustName);
            });
        });
    });
</script>