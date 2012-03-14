<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Test
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<script src="../../Scripts/Shared/JsTree/jquery.jstree.js" type="text/javascript"></script>

    <script src="../../Scripts/Shared/Dict.js" type="text/javascript"></script>
    

    <script src="../../Scripts/Shared/Dept.js" type="text/javascript"></script>
   
    <input type="text" id="test" value="22" />
    
    <input type="text" id="tt" value="33" />
    <script type="text/javascript">
        $(document).ready(function() {
            Common_Tree_Dict.Init("test", "GENDER", function(code, name) { ShowMsg(code + "," + name); $("#test").val(name); });
            //            Common_Tree_Dict.Init("tt", "TIMESHEET", function(code, name) { ShowMsg(code + "," + name); $("#tt").val(name); });
            Common_EmpTree_Dept.Init("tt", function(code, name) { ShowMsg(code+","+name); });
            //        $("#tree").jstree({ 
            //             'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            //                "json_data": {
            //                    "ajax": {
            //                        "url": "/Dict/GetDictTreeData/GENDER"
            //                    }
            //                },
            //              
            //                'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': false, 'icons': true },
            //                'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }
            //            });
        });
    </script>--%>

    <script type="text/javascript">
        $(document).ready(function() {

        });
        
    </script>

    <div id="mmenu" style="height: 30px; overflow: auto;">
        <input type="button" id="Add_folder" value="添加" style="display: block; float: left;" />
        <input type="button" id="Edit_folder" value="修改" style="display: block; float: left;" />
        <input type="button" id="Del_folder" value="删除" />
    </div>
    <div class="left_tree" style="width: 250px; float: left;">

                  <%= Html.TreeView<QX.Model.Bse_Dict>(
                        "DictList",
                        ViewData["DictList"] as IEnumerable<QX.Model.Bse_Dict>,
                        d => d.ChildDictList,
                        d => "<a id='"+d.Dict_Code+"'>" + d.Dict_Name + "</a>",false,"",false,""
                       )%>
      
    </div>

    <script type='text/javascript'>
        function SetCheckNode() {
            //            $("#DictList").jstree("uncheck_node", $("#DocCate"));
            // $("#DictList").jstree("check_node", function() {
            //    // alert($("#" + obj.nodeid).attr("class"));removeClass("jstree-checked jstree-unchecked").addClass("jstree-undetermined"); 
            // $("#561000000002").removeClass("jstree-unchecked jstree-undetermined").addClass("jstree-checked");
            // });
            
        }
        $(document).ready(function() {
            $("#Edit_folder").click(function() {
                SetCheckNode();
            });
            $("#Add_folder").click(function() {
                var idArray = new Array();
                $("#DictList").find(".jstree-checked, .jstree-undetermined ").each(function() {
                    var isChild = true;
                    if ($(this).length != 0) {
                        idArray.push($(this).find("a").attr("id"));
                        isChild = false;
                    }
                    if (isChild) { idArray.push($(this).attr("id")); }
                });
                //var ids=idArray.join(',');
                alert(idArray);
            });
            $("#DictList").bind("loaded.jstree", function(e, data) {

                $.ajax({
                    type: "post",
                    url: "/Dict/GetCheckNode",
                    //data: { nodeCode: code, nodeKey: Itype },
                    success: function(re, textStatus) {
                        $.each(re, function(i, item) {
                            if (item.Dict_Code != '') {
//                                $("#DictList").jstree("check_node", function() {
//                                    $("#" + item.Dict_Code).parent().removeClass("jstree-unchecked jstree-undetermined").addClass("jstree-checked");
//                                    return $("#" + item.Dict_Code).parent();
                                //                                });
                                $("#" + item.Dict_Code).parent().removeClass("jstree-unchecked jstree-undetermined").addClass("jstree-checked");
                            }
                            else {

                            }
                        });
                    }
                });
            });

            $('#DictList').jstree({
                'core': { 'animation': 0 },
                'plugins': ['themes', 'html_data', 'checkbox', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys',  'unique'],
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
