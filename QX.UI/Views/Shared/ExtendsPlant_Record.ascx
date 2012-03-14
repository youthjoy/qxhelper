<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%=Html.ReferControl("Plant_RecordModule", "Plant_Record")%>
       <script type="text/javascript">
           $(document).ready(function() {
               //植物损坏

               $("#PDR_PlantName").bind("click", function() {
                   Plant_RecordModulePlant_RecordOpenRefer('Plant_RecordModule', 'Plant_Record', function(data) {
                       $("#PR_Position").val(data.PR_Position);
                       $("#PDR_PlantName").val(data.PR_Category);
                       //$("#PDR_Amount").val(data.PR_Amount);
                       // $("#PDR_Count").val(data.PR_Amount);
                       $("#PDR_Price").val(data.PR_Price);
                       $("#PDR_PlantCode").val(data.PR_Code);
                       $("#PDR_Company").val(data.PR_Company);
                       $("#PDR_Dept").val(data.PR_Dept);
                   });
               });




               //金额=单价*数量
               $("#PDR_Count,#PDR_Price,#PDR_Amount").focusout(function() {
                   var product = parseInt($("#PDR_Price").val()) * parseInt($("#PDR_Count").val());
                   if (product == "NaN") {
                       $("#PDR_Amount").val("金额");
                   } else {
                       $("#PDR_Amount").val(product);
                   }
               });
           });</script>