<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<%=Html.ReferControl("PCT_InfoModule", "PCT_Info",false)%>


<script type="text/javascript">
    $(document).ready(function() {
//        $("#PUD_Udef1").bind("click", function() {
//            PCT_InfoModulePCT_InfoOpenReferWithFilter(" PCTI_iType='logistics'  and PCTI_Status<>'15' ", function(data) {
//            $("#PUD_Udef1").val(data.PCTI_NO);
//                $("#PUD_Udef2").val(data.PCTI_DName);
//            });
//        });
    });
</script>