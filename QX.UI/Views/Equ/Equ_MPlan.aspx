<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Equ_MPlan>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Equ_MPlan
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function() {

        Equ_Operation.Init("edit");
        //初始化编辑表单
        $("#finaceOperation").dialog({ autoOpen: false, width: 800, minWidth: 810 });
        var options = {
            success: function(data) { Equ_MPlan_GridControl.AfterSaveEdit(data); },  // post-submit callback
            width: 800,
            timeout: 3000
        };
        $('#stuff').ajaxForm(options);
    });

    function ToolBarAdd() {
        Equ_MPlan_GridControl.AddPlan();
    }
    function ToolBarEdit() {
        var grid = $("#mrgrid");
        var curid = grid.getGridParam("selrow");
        var data = grid.getRowData(curid);
        if (data.MP_Code == undefined) {
            alert("请选中编辑行");
            return;
        }
        Equ_MPlan_GridControl.InitEdit(data.MP_Code);
        //window.location = "/HR/Edit/" + data.Stuff_Code;
    }
    function ToolBarDelete() {

    } 
</script>
 <%Html.RenderPartial("ToolBarControl",""); %>
      <%Html.RenderPartial("GridControl", "mr"); %>
      

<%--<script type="text/javascript" language="javascript">
    Equ_MPlan_GridControl.Init("/Equ/MPlanList", "mr");
</script>--%>
 <div id="finaceOperation">
        <% using (Html.BeginForm("EditPlan", "Equ", FormMethod.Post, new { id = "stuff", name = "stuff" }))
           { %>
        <%=Html.BindModelToControl<QX.Model.Equ_MPlan>("Equ_MPlan")%>
        <input type="hidden" name="MP_ID" id="MP_ID" value='' />
        <input type="button" value="保存" onclick="Equ_MPlan_GridControl.SaveEditData()" />
        <input type="button" value="取消" onclick="Equ_MPlan_GridControl.CancelEdit()" />
        <% } %>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
