<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.WH_Contract>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	WH_Contract
</asp:Content>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"> 
 <%Html.RenderPartial("ToolBarControl",""); %>
 
<%Html.RenderPartial("GridControl", "ht"); %>
    <script src="/Scripts/Shared/jquery.query-2.1.7.js" type="text/javascript"></script>
<script src="../../Scripts/Shared/Dict.js" type="text/javascript"></script>
<script language="javascript" type="text/javascript">
    $(document).ready(function() {
        WH_ContractS_GridControl.Init("/Vendor/ContractallLists", "ht");
        //Contract_Func
        Common_Select_Dict.Init($("#Contract_Func"), "CONTRACTSTYLE");
        Common_Select_Dict.Init($("#Contract_Type"), "CONTRACTMODALITY");
    });
</script>
 <div id="finaceOperation">
        <% using (Html.BeginForm("EditContact", "Vendor", FormMethod.Post, new { id = "stuff", name = "stuff" }))
           { %>
        <%=Html.BindModelToControl<QX.Model.WH_Contract>("WH_Contract")%>
        <input type="hidden" name="Contract_ID" id="Contract_ID" value='' />
        <input type="button" value="保存" onclick="WH_ContractS_GridControl.SaveEditData()" />
        <input type="button" value="取消" onclick="WH_ContractS_GridControl.CancelEdit()" />
        <% } %>
    </div>

   <script type="text/javascript">
       $(document).ready(function() {

           //window.onerror = function() { return true; }
           //初始化编辑表单
           $("#finaceOperation").dialog({ autoOpen: false, width: 800, minWidth: 810 });







           var make = $.query.get("make");
           // alert(make);
           debugger;
           if (make == -1) {//通过地址传过来的参数make判断是否是从左边点击  0表示添加
               $("#finaceOperation").dialog("open");
           }
           else if (make == 0) {

           }
           else {
               WH_ContractS_GridControl.InitEdit(make);
           }






           var options = {
               success: function(data) { WH_ContractS_GridControl.AfterSaveEdit(data); },  // post-submit callback
               width: 800,
               timeout: 3000
           };
           $('#stuff').ajaxForm(options);
       });

       function ToolBarAdd() {
           WH_ContractS_GridControl.AddPlan();
       }
       function ToolBarEdit() {
           var grid = $("#htgrid");
           var curid = grid.getGridParam("selrow"); //获取选择行的id
           var data = grid.getRowData(curid); //获取行号为curid的数据
           if (data.Contract_Code == undefined) {
               alert("请选中编辑行");
               return;
           }
           WH_ContractS_GridControl.InitEdit(data.Contract_Code);
           //window.location = "/HR/Edit/" + data.Stuff_Code;
       }
       function ToolBarDelete() {

       }
   </script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
