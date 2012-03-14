<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<%--<script type="text/javascript">
    $(document).ready(function() {
        $("#GMSR_SCode").bind("click", function() {
            GM_SealModuleGM_SealOpenRefer('GM_SealModule', 'GM_Seal', function(data) {
            $('#GM_SealRecord_Form').find('#GMSR_SCode').val(data.GMSE_Code);
            $('#GM_SealRecord_Form').find('#GMSR_SName').val(data.GMSE_Name);
            });
        });
    });
</script>--%>
<%=Html.ReferControl("Plant_RecordModule", "Plant_Record")%>  