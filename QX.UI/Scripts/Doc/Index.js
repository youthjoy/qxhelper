
var Doc_Info_GridControl = {
    setupDoc_InfoGrid: function(grid, pager, search, dataurl) {
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
            caption: '文档信息列表',
            footerrow: false,
            colNames: ['操作', '文档序号', '文档类型', '文档编号', '文档名称', '文档描述', '文档地址', '文档开始生效时间', '文档失效时间', '文档提醒提前期', '文档当前状态', '文档下一审核节点', ''],
            colModel: [
            { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_ID', index: 'Doc_ID', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Doc_Type', index: 'Doc_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_Code', index: 'Doc_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_Title', index: 'Doc_Title', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_Desp', index: 'Doc_Desp', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_Path', index: 'Doc_Path', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_StartTime', index: 'Doc_StartTime', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_FailureTime', index: 'Doc_FailureTime', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_Remind', index: 'Doc_Remind', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Doc_Stat', index: 'Doc_Stat', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Doc_NextAudit', index: 'Doc_NextAudit', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Stat', index: 'Stat', width: 100, align: 'center', sortable: false, hidden: true}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                  var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var create = "<a href='#' onclick='javascript:Doc_Info_GridControl.AddPlan()'><img src='../../Content/images/add1.png' border='0';alt='添加' /></a>&nbsp;";
                    var objEvent = "onclick='javascript:Doc_Info_GridControl.InitEdit(\"" + ret.Doc_Code + "\");'";
                    var be = "<a href='#' " + objEvent + "><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp;";
                    var del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: create + be +del});
                
                }
            },
            userDataOnFooter: true
        });
    },


    AddPlan: function(newCode) {
    $("#stuff")[0].reset();
    $("#Doc_ID").val("0");
        $("#finaceOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/Doc/Stuff_ContactEdit",
            data: { id: code },
            dataType: "json",
            success: function(data, textStatus) {
                for (var p in data) {
                    $("#" + p).val(data[p]);
                }
            }
        });
        $("#finaceOperation").dialog("open");
    },
    SaveEditData: function() {
        $("#stuff").submit();
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
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        Doc_Info_GridControl.setupDoc_InfoGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
