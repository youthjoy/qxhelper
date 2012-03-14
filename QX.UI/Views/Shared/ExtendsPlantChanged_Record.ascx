<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>

<%=Html.ReferControl("Plant_RecordModule", "Plant_Record")%>
<script type="text/javascript">
    $(document).ready(function() {
        //原品名
        $("#PCR_OldName").bind("click", function() {
            Plant_RecordModulePlant_RecordOpenRefer('Plant_RecordModule', 'Plant_Record', function(data) {
                $("#PR_Position").val(data.PR_Position);
                $("#PCR_OldName").val(data.PR_Category);
                //$("#PDR_Amount").val(data.PR_Amount);
                $("#PCR_Count").val(data.PR_Count);
                $("#PCR_Price").val(data.PR_Price);
                $("#PCR_Company").val(data.PR_Company);
                $("#PCR_Dept").val(data.PR_Dept);
                $("#tempCode").val(data.PR_Code);

            });
        });
    });
    function PlantChanged_Record_FormLoadAfter() {
        //$("#PlantChanged_Record_FormOK").Remove();
    }
    </script>