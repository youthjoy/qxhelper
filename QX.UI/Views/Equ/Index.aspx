<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Equ_Information>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function() {
        $("#div_EidtEquInfo").dialog({ autoOpen: false,width:900 });
        var options = {
            success: function(data) {
                Equ_Index.AfterSaveNew(data);
            },
            width: 800,
            timeout: 3000
        };
        $('#formEidt').ajaxForm(options);
    });

    function ToolBarAdd() {
        window.location = "/Equ/Equ_add"
    }
    function ToolBarEdit() {
        var grid = $("#grid");
        var curid = grid.getGridParam("selrow");
        var data = grid.getRowData(curid);
        if (data.EquInfo_Code == undefined) {
            alert("请选中编辑行");
            return;
        }
        //Equ_Index.InitEdit(data.EquInfo_Code);
        window.location = "/Equ/Edit/" + data.EquInfo_Code;
    }
    function ToolBarDelete() {

    }
</script>
 <%Html.RenderPartial("ToolBarControl",""); %>
    <div>
        <div id="search">
        </div>
        <table id="grid"  cellpadding="0" cellspacing="0">
        </table>
        <div id="pager"   style="text-align: center;">
        </div>
    </div> 
    <div id="div_EidtEquInfo">
     <%using (Html.BeginForm("AddNewEqu", "Equ", FormMethod.Post, new { id = "formEidt", name = "formEdit" }))
       { %>
       <%=Html.BindModelToControl<QX.Model.Equ_Information>("Equ_Information")%>
       <input type=button value="保存" onclick="Equ_Index.SubmitForm()" />
       <input type=button value="取消" onclick="Equ_Index.ChanlEidt()" />
     <%} %>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
