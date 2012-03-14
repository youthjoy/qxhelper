<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<script src="../../Scripts/ContractS/ContractS.js" type="text/javascript"></script>
<div id="finaceOperation">
    <%Html.RenderPartial("ToolBarControl", ""); %>
    <%Html.RenderPartial("GridControl", ""); %>
</div>
<script type="text/javascript">
    $(document).ready(function() {
    WH_ContractS_GridControl.Init("/Vendor/ContractallLists", "");
        //初始化编辑表单
        $("#finaceOperation").dialog({ autoOpen: false, width: 600, minWidth: 810, title: "合同选择" });
        var options = {
        success: function(data) { WH_ContractS_GridControl.AfterSaveEdit(data); },  // post-submit callback
            width: 800,
            timeout: 3000
        };
        $('#stuff').ajaxForm(options);
    });
</script>


