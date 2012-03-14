<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.System_Menu>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <script src="/Scripts/Shared/JsTree/jquery.jstree.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/jquery.form.js" type="text/javascript"></script>
    <%--不兼容--%>
    <%--<script src="/Scripts/Shared/jquery.validate.js" type="text/javascript"></script>--%>
    <%--<script src="/Scripts/Shared/MicrosoftMvcJQueryValidation.js" type="text/javascript"></script>--%>
    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>
    
    <script type="text/javascript">
        $(function() {
            System_Menu_GridControl.Init("/Menus/List/", "");
            MenusOperation.Init("Edit");
            Common_Select_Dict.Init($("#Menu_Location"), "MENUSLOCATION");
            $("#MenuForm2 *:only-child").each(function(key, element) {
                if (element.type == "select-one") {
                    Common_Select_Dict.Init($(element), "MENUSLOCATION");
                }
            });
        });
    </script>    
   <%Html.EnableClientValidation();%>         
    <div id="tabs" style="width:98%; height:100%">
        <ul>
            <li><a href="#tabs-1">菜单管理</a></li>
            <li><a href="#tabs-2">顶部菜单</a></li>
        </ul>
        <div id="tabs-1">
            <table>
                <tr valign="top">
                    <td style="width:150px;height:190px;" class="left_tree">
                       <%= Html.TreeView<QX.Model.System_Menu>(
                                        "Menu",
                        ViewData["MenuList"] as IEnumerable<QX.Model.System_Menu>,
                                        d => d.ChildrenMenus,
                        d => "<a id='" + d.Menu_Code + "'>" + d.Menu_Title + "</a>")%>
                    </td>
                    <td>
                        <div id="container" style="width:100%">
                            <div id="leftSide">
                                <fieldset style="width: auto;height:250px;">
                                    <legend>基本信息</legend>
                                    <div class="FormStyle">
                                    <form id="MenuForm" name="MenuForm" method="post" action="/Menus/Menusadd">
                                    <%=Html.BindModelToControl<QX.Model.System_Menu>("System_Menu", Model)%>
                       </form>
                                    </div>
                                </fieldset>
                            </div>
                            <div style="float: right; margin-right: 200px; margin-top: -20px">
                                <input id="MenuForm_OK" class="button_style" type="submit" value="确定" onclick="Edit();" />
                                <input id="MenuForm_Cancle" class="button_style" type="submit" value="取消" />
                                <%--<input id="MenuForm_Apply" class="button_style" type="submit" value="应用" onclick="Edit();" />--%>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
             
        </div>
        <div id="tabs-2" style="width:100%">
            <%Html.RenderPartial("GridControl", "top"); %>
        </div>  
       
        <%-- <input type="button" value="返回" onclick="javascript:location='/Bse/Index'" />--%>
    </div>
    
          <div id="finaceOperation">
        <% using (Html.BeginForm("EditContact", "Menus", FormMethod.Post, new { id = "MenuForm2", name = "MenuForm2" }))
           { %> 
          
        <%=Html.BindModelToControl<QX.Model.System_Menu>("System_Menu")%>
        <input type="button" value="提交" onclick="System_Menu_GridControl.SaveEditData()" />
        <input type="button" value="取消" onclick="System_Menu_GridControl.CancelEdit()" />
        <% } %>
    </div>
     <script type="text/javascript">
         $(document).ready(function() {

             //window.onerror = function() { return true; }
             //初始化编辑表单
             $("#finaceOperation").dialog({ autoOpen: false, width: 800, minWidth: 810 });
             var options = {
                 success: function(data) { System_Menu_GridControl.AfterSaveEdit(data); },  // post-submit callback
                 width: 800,
                 timeout: 3000
             };
             $('#stuff').ajaxForm(options);
         });
    </script>
    <script type="text/javascript">
        function Edit() {
            var MenuLeftData = $("#MenuForm").serialize();
            var ajaxProjectListOptions = {
                url: '/Menus/Menusadd',
                type: 'post',
                data: MenuLeftData,
                success: function(result) {
                    if (result == "fail") {
                        ShowMsg("提交失败");
                    } else {
                        ShowMsg("提交成功");
                        var Title = $("#Menu_Title").val();
                        $("#" + result).html("<ins class='jstree-icon'></ins>" + Title);
                    }
                }
            };
            $.ajax(ajaxProjectListOptions);
        }
        //]]>
</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
 
