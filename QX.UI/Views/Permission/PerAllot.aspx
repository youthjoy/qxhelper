<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Sys_Function>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="mmenu" style='height: 40px;'>
        <input type="button" id="btnSave" value="保存" style="display: block; float: left;" />
        <input type="button" id="Refresh" value="刷新" style="display: block; float: left;" />
        <input type="button" id="Back" value="返回" style="display: block; float: left;" />
    </div>
    <div class="left_tree" style="width: auto; clear: both;">
        <%= Html.TreeView<QX.Model.Sys_Function>(
                        "DictList",
                        ViewData["FunList"] as IEnumerable<QX.Model.Sys_Function>,
                        d => d.Childrens,
                        d => "<a id='"+d.Fun_Code+"'>" + d.Fun_Name + "</a>",false,"",false,""
                       )%>
    </div>

    <script type='text/javascript'>
        function GetMenuIds() {
            var ids = "";
            $("#DictList").find(".jstree-checked, .jstree-undetermined ").each(function() {
                var isChild = true;
                if ($(this).length != 0) {
                    ids = ids + ($(this).find("a").attr("id")) + ",";
                    isChild = false;
                }

            });
            return ids;
        }

        $(document).ready(function() {
            //保存数据
            $("#btnSave").click(function() {
                $.ajax({
                    type: "post",
                    data: { data: GetMenuIds() },
                    url: "/Permission/UpdatePermission/" + '<%=ViewData["UserId"] %>',
                    success: function(re, textStatus) {
                        alert(re.Msg);
                    }
                });    //ajax
            });
            $("#Refresh").click(function() {
                window.location.reload();
            });

            $("#Back").click(function() {
                window.location = "/Permission/Index";
            });
            //            
            $("#DictList").bind("loaded.jstree", function(e, data) {
                $.ajax({
                    type: "post",
                    url: '/Permission/GetUserPermission/<%=ViewData["UserId"] %>',
                    success: function(re, textStatus) {
                        $.each(re, function(i, item) {
//                            if (item.PU_FunCode != '') {

//                                $("#" + item.PU_FunCode).parent().removeClass("jstree-unchecked jstree-undetermined").addClass("jstree-checked");
//                            }
//                            else {//移除选中状态
//                                $("#" + item.PU_FunCode).parent().removeClass("jstree-checked jstree-undetermined").addClass("jstree-unchecked");
                        //                            }

                        //如果存在该权限点则自动勾选
                        if (item.PU_FunCode != '' ) {

                            $("#" + item.PU_FunCode).parent().removeClass("jstree-unchecked jstree-undetermined").addClass("jstree-undetermined");
                        }
                        else {
                            $("#" + item.PU_FunCode).parent().removeClass("jstree-checked jstree-undetermined").addClass("jstree-unchecked");
                        }
                        });
                    }
                });
            });

            $('#DictList').jstree({
                'core': { 'animation': 0 },
                'plugins': ['themes', 'html_data', 'checkbox', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'unique'],
                'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': true, 'icons': true },
                'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }
            });



        }) //end
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
