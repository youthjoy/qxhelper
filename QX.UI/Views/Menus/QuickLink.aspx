<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<html>
<head>
    <title>快捷方式管理</title>
    <link href="/Content/ui-lightness/jquery-ui-1.8.5.custom.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/Shared/jquery-1.4.2.min.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/JsTree/jquery.jstree.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/jQueryUI/ui.core.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/jQueryUI/ui.draggable.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/jQueryUI/ui.sortable.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/jquery.cookie.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/jquery.hotkeys.js" type="text/javascript"></script>

    <link href="/Content/css/Site.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        .Link
        {
            list-style-type: none;
        }
        .Link li
        {
            margin-top: 6px;
            width: 200px;
            height: 25px;
            line-height: 25px;
            vertical-align: middle;
            background:url('/Content/images/main_18.gif');
            border:solid 1px #adb9c2;
        }
        
        .Link a:hover .Link a:active { color:Black  }
        
        #Menu
        {
            border-bottom: solid 1px #787878;
        }
        
        .jstree-classic.jstree-focused {
            height: 300px;
            overflow: auto;
        }
    </style>

    <script type="text/javascript">
        $(function() {

            var els = ['.Link', '.TrashCan'];
            var $els = $(els.toString());

            $els.sortable({
                revert: true,
                scroll: false,
                items: 'li',
                cursor: 'move',
                helper: 'clone',
                connectWith: els

            });
            //$("#Left").sortable({ revert: true, scroll: false, items: 'a', helper: 'clone', connectWith: '.Link' });

            //            $("#Menu").sortable({ revert: true, scroll: false, items: 'li .jstree-leaf', helper: 'clone' });
            //            $('#Menu').bind('sortout', function(event, ui) {
            //                $(".Link").find(".jstree-icon").remove();
            //            });
            $(".Link").bind("sort", function(event, ui) {
                $(".Link").find(".jstree-icon").remove();
            });

            //数据控件事件绑定
            $("#Menu").bind('dblclick_node.jstree', function(event, data) {

                var $subject = $(data.rslt.obj[0].childNodes[1]);
                var url = $subject.attr("id");
                var code = $subject.attr("tag");
                var text = $subject.text();
                if (url != "") {
                    $(".Link").append("<li  id='" + code + "'><a target='Main' href='" + url + "'>" + text + "</li>");
                }
//                var eventNodeName = event.target.nodeName;
//                if (eventNodeName == 'INS') {
//                    return;
//                } else if (eventNodeName == 'A') {
//                    var $subject = $(event.target);
//                    var url = $subject.attr("id");
//                    var code = $subject.attr("tag");
//                    var text = $subject.text();
//                    if (url != "") {
//                        var check = $(".Link").find("#" + code);

//                        
//                    }

//                }
            });

            $("#save").click(function() {

                $.ajax({
                    url: '/Menus/SaveQuickMenu',
                    type: 'post',
                    data: { Html: $('.link').html() },
                    success: function(data) {
                        if (data == "success") {
                            alert("保存成功");
                        } else { alert("保存失败"); }
                    }
                });
            })

        })
    </script>

</head>
<body>

    <div style="width: 100%">
        <div id="Left" style="float: left; width: 300px; height:550px; overflow:hidden; border: solid 1px #CADCE5;">
            <div class="Desktop_Tool"> <img src="/Content/images/top159.png"/> 菜单组 </div>
            <%= Html.TreeView<QX.Model.System_Menu>(
                                        "Menu",
                        ViewData["MenuList"] as IEnumerable<QX.Model.System_Menu>,
                                        d => d.ChildrenMenus,
                        d => "<a id='" + d.Menu_Url + "' tag='"+d.Menu_Code+"'>" + d.Menu_Title + "</a>")%>
        <div class="TrashCan" style="background-color:#CADCE5;">
            <div class="Desktop_Tool"> <img src="/Content/images/top159.png"/> 快捷方式回收站 </div>
        </div>
        </div>
        <div id="Right" style="float: left; width: 300px; height: 550px; margin-left: 20px;
            border: solid 1px #CADCE5">
            <div class="Desktop_Tool"> <img src="/Content/images/top159.png"/> 用户快捷方式 </div>
            <ul class="Link" style="float: left;  height: 100%; width:100%; overflow:auto">
                <%=ViewData["TopList"]%>                          
            </ul>           
        </div>
        <div>
            <input type="button" id="save" name="save" value="保存"/>
        </div>
    </div>
</body>
</html>
