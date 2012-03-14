<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Equ_Information>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    设备基本信息
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

            $("#finaceEditLists").dialog({ autoOpen: false, width: 800, minWidth: 810 });
            var options = {
                success: function(data) { Equ_Shared_GridControl.AfterSaveEdit(data); },
                width: 800,
                timeout: 3000
            };
            $('#editRecords').ajaxForm(options);
        });
    </script>
 <script type="text/javascript">
     function Edit() {
         var stuff = $("#stuffequ").serialize();
         $.ajax({
         url: '/Equ/EditY',
             data: stuff,
             type: 'post',
             success: function(data) {
                 if (data != "success")
                     alert("保存失败");
             }
         });
     }
    </script>
    <%using (Html.BeginForm("EditEqu", "Equ", FormMethod.Post, new { id = "stuffequ", name = "stuffequ" }))
      { %>
    <div id="container" style="width: 831px;">
        <div id="leftSide">
            <fieldset style="width: 800px;">
                <legend>基本信息</legend>
               <input type="hidden" name="EquInfo_ID" id="EquInfo_ID" value='<%= ViewData.Model.EquInfo_ID%>'/>
                <%=Html.BindModelToControl<QX.Model.Equ_Information>("Equ_BseInfo", Model)%>
            </fieldset>
        </div>
    </div>
    <div id="tabs" style="width: 850px;">
        <ul>
            <li><a href="#tabs-1">基本信息</a></li>
            <li><a href="#tabs-2">设备检修计划</a></li>
            <li><a href="#tabs-3">设备检修记录</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.BindModelToControl<QX.Model.Equ_Information>("Equ_Other", Model)%>
        </div>
        <div id="tabs-2">
            <%Html.RenderPartial("GridControl", "mr"); %>
        </div>
        <div id="tabs-3">
            <%Html.RenderPartial("GridControl", "mvr"); %>
        </div>
    </div>
    
   
    <input type="submit" value="提交" onclick="Edit();" />
    <input type="button" value="返回" onclick="javascript:location='/Equ/Index'" />
    <%} %>
    <div id="finaceOperation">
        <% using (Html.BeginForm("EditPlan", "Equ", FormMethod.Post, new { id = "stuff", name = "stuff" }))
           { %>
        <%=Html.BindModelToControl<QX.Model.Equ_MPlan>("Equ_MPlan")%>
        <input type="hidden" name="MP_ID" id="MP_ID" value='' />
        <input type="button" value="保存" onclick="Equ_MPlan_GridControl.SaveEditData()" />
        <input type="button" value="取消" onclick="Equ_MPlan_GridControl.CancelEdit()" />
        <% } %>
    </div>
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
<asp:Content ID="Content3" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
