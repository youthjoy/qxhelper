/// <reference path="../Shared/jquery-1.4.1.min-vsdoc.js" />

$(document).ready(function() {
    $("#Menu").bind('click.jstree', function(event) {
        var eventNodeName = event.target.nodeName;
        if (eventNodeName == 'INS') {
            return;
        } else if (eventNodeName == 'A') {
            var $subject = $(event.target);
            var deptcode = $subject.attr("id");
            var url = '/Menus/Index/' + deptcode;
            //            window.location = url;
            $.ajax(
            {
                type: "GET",
                url: url,
                data: null,
                dataType: "json",
                success: function(data, textStatus) {
                    for (var p in data) {
                        $("#" + p).val(data[p]);
                    }
                }
            });
        }
    });
});
MenusOperation =
{
    Init: function(type) {
        $("#tabs").tabs({ select: function(event, ui) {
            switch (ui.index) {
                case 1:
                    System_Menu_GridControl.Init("/Menus/List/", "top");
                    break;
            }
        }
        });
        if (type != undefined && type == "edit") {
            MenusOperation.InitEdit();
        }
        else {
            MenusOperation.InitCreate();
        }
    },
    InitEdit: function() {
    },
    InitCreate: function() {
    },
    InitGender: function() {
    }
}
var System_Menu_GridControl = {
    setupSystem_MenuGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            url: dataurl,
            mtype: "post",
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '信息列表',
            footerrow: false,
            colNames: ['操作', 'id', '菜单编码', '菜单名称', '菜单排序', "位置移动"],
            colModel: [
            { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Menu_ID', index: 'Menu_ID', width: 100, align: 'center', sortable: false, hidden: true },
            { name: 'Menu_Code', index: 'Menu_Code', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Menu_Title', index: 'Menu_Title', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Menu_Order', index: 'Shortcut', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Move', index: 'Shortcut', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var create = "<a href='#' onclick='javascript:System_Menu_GridControl.AddPlan()'><img src='../../Content/images/add1.png' border='0';alt='添加' /></a>&nbsp;";
                    var objEvent = "onclick='javascript:System_Menu_GridControl.InitEdit(\"" + ret.Menu_Code + "\");'";
                    var be = "<a href='#' " + objEvent + "><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp";
                    var del = "<a href='#'" + objEvent + "><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";

                    var dragDown = "<a onclick=javascript:System_Menu_GridControl.MoveItemDown('" + (i + 1) + "') href='#'><img src='../../Content/images/down.png' border='0';alt='下移' /></a>";
                    var dragUp = "  <a onclick=javascript:System_Menu_GridControl.MoveItemUp('"
                    + (i + 1) + "') href='#'><img src='../../Content/images/up.png' border='0';alt='上移' /></a>";
                    //grid.jqGrid('setRowData', ids[i], { Edit: create + be });
                    grid.jqGrid('setRowData', ids[i], { Edit: create + be + del, Move: dragUp + dragDown });

                }


            },
            userDataOnFooter: true
        });
    },
    AddPlan: function() {
        debugger;
        $("#MenuForm2")[0].reset();
        $("#Menu_ID").val("0");
        $("#finaceOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/Menus/Stuff_ContactEdit",
            data: { id: code },
            dataType: "json",
            success: function(data, textStatus) {
                if (textStatus != "success") {
                    return;
                }
                //*取出MenuForm2所有的子元素
                $("#MenuForm2 *:only-child").each(function(key, element) {
                    //debugger;
                    //var idObj = $("#Menu_ID");
                    for (var p in data) {
                        if (p == element.id) {
                            if (element.type == "checkbox") {//页面上的复选框
                                element.checked = data[p];
                            } else if (element.type == "text") {
                                element.value = data[p];

                            } else if (element.type == "select-one") {//页面上的下拉菜单
                                var e = $(element);
                                e.val(data[p]);
                            }
                        }
                    }
                    //ShowMsg($("#Menu_ID").val());
                });
            }
        });
        $("#finaceOperation").dialog("open");
    },
    SaveEditData: function() {
        var formdata = $("#MenuForm2").serialize(); ;
        debugger
        $.ajax({
            url: '/Menus/EditContact',
            data: formdata,
            type: 'post',
            success: function(result) {
                if (result == "success") {
                    $("#finaceOperation").dialog("close");
                    $("#topgrid").trigger("reloadGrid");
                }
                else {
                    ShowMsg('提交失败!');
                }
            }
        });

    },

    AfterSaveEdit: function(data) {
        if (data == "success") {
            $("#finaceOperation").dialog("close");
            $("#grid").trigger("reloadGrid");
        }
        else {
            ShowMsg('提交失败!');
        }
    },
    CancelEdit: function() {
        $("#finaceOperation").dialog("close");
    },
    MoveItemUp: function(data) {
        //debugger;    
        var PreRowId;
        var NextRowId;
        //获取上下文
        var grid = $("#topgrid");
        if (data != undefined) {
            grid.setSelection(data);
        }
        var sumRow = grid.getGridParam("reccount");
        var CurRowId = grid.getGridParam("selrow");
        if (CurRowId > 0) {
            PreRowId = parseInt(CurRowId) - 1;
            NextRowId = parseInt(CurRowId) + 1;

            var PreRowData = grid.getRowData(PreRowId);
            var CurRowData = grid.getRowData(CurRowId);
            //var NextRowData = grid.getRowData(NextRowId);
            //            ShowMsg(PreRowData.Menu_Order); ShowMsg(CurRowData.Menu_Order); ShowMsg(NextRowData.Menu_Order);

        }

        $.ajax({
            url: "/Menus/MoveItemUp",
            type: 'post',
            data: { preId: PreRowData.Menu_ID, curId: CurRowData.Menu_ID },
            success: function(result) {
                grid.trigger("reloadGrid");
            }
        });
    },
    MoveItemDown: function(data) {
        debugger;
        var PreRowId;
        var NextRowId;
        //获取上下文
        var grid = $("#topgrid");
        if (data != undefined) {
            grid.setSelection(data);
        }
        var sumRow = grid.getGridParam("reccount");
        var CurRowId = grid.getGridParam("selrow");
        if (CurRowId != sumRow) {
            NextRowId = parseInt(CurRowId) + 1;

            //var PreRowData = grid.getRowData(PreRowId);
            var CurRowData = grid.getRowData(CurRowId);
            var NextRowData = grid.getRowData(NextRowId);
            //            ShowMsg(PreRowData.Menu_Order); ShowMsg(CurRowData.Menu_Order); ShowMsg(NextRowData.Menu_Order);

        }
        debugger;
        $.ajax({
            url: "/Menus/MoveItemDown",
            data: { curId: CurRowData.Menu_ID, nextId: NextRowData.Menu_ID },
            type: 'post',
            success: function(result) {
                grid.trigger("reloadGrid");
            }
        });
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        System_Menu_GridControl.setupSystem_MenuGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}

