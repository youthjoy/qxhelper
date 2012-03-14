<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<script type="text/javascript">
    $(document).ready(function() {
    $("#HUsage_HRentalCode").bind("click", function() {
            House_RentalModuleHouse_RentalOpenRefer('House_RentalModule', 'House_Rental', function(data) {
            $("#HUsage_HRentalCode").val(data.HRental_Code);

//            $("#HCost_Company").val(data.HRental_Company);
//            $("#HCost_Dept").val(data.HRental_Dept);

             
            
            });
        });

        $("#HCost_User").bind("click", function() {
      
        HR_StuffModuleHR_StuffOpenReferWithFilter(" Stuff_DepName='" + $("#HCost_Dept").val() + "' ", function(data) {
            $("#HCost_User").val(data.Stuff_Name);
            });
        });
        
//        $("#HUsage_HRentalCode").bind("click", function() {
//            House_RentalModuleHouse_RentalOpenRefer('House_RentalModule', 'House_Rental', function(data) {
//            $("#HUsage_HRentalCode").val(data.HRental_Code); 
//            });
//        });
    });
</script>
  <%=Html.ReferControl("HR_StuffModule", "HR_Stuff",false)%>
<%=Html.ReferControl("House_RentalModule", "House_Rental")%>    