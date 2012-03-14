<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Equ_MRecords>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Equ_MRecords
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <script type="text/javascript">
        $(document).ready(function() {

            Equ_Operation.Init("edit")
            $("#finaceEditLists").dialog({ autoOpen: false, width: 800, minWidth: 810 });
            var options = {
                success: function(data) { Equ_Shared_GridControl.AfterSaveEdit(data); },
                width: 800,
                timeout: 3000
            };
            $('#editRecords').ajaxForm(options);
        });
        function ToolBarAdd() {
            Equ_Shared_GridControl.AddNewRecord();
        }
        function ToolBarEdit() {
            var grid = $("#mvrgrid");
            var curid = grid.getGridParam("selrow");
            var data = grid.getRowData(curid);
            if (data.MR_ECode == undefined) {
                alert("请选中编辑行");
                return;
            }
            Equ_Shared_GridControl.EditRecordsLists(data.MR_ECode);
            //window.location = "/HR/Edit/" + data.Stuff_Code;
        }
        function ToolBarDelete() {

        } 
    </script> <%Html.RenderPartial("ToolBarControl",""); %>
        <%Html.RenderPartial("GridControl", "mvr"); %>
         <div id="finaceEditLists">
        <% using (Html.BeginForm("SaveEidtRecords", "Equ", FormMethod.Post, new { id = "editRecords", name = "editRecords" }))
           {  %>
        <%=Html.BindModelToControl<QX.Model.Equ_MRecords>("Equ_MRecords")%> 
        <input type="hidden" name="MR_ID" id="MR_ID" value='' />
        <input type="button" value="保存" onclick="Equ_Shared_GridControl.SaveEditData()" />
        <input type="button" value="取消" onclick="Equ_Shared_GridControl.CancelEdit()" />
        <%} %>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
