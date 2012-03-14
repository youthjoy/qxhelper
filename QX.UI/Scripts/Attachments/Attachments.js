var Bse_Attachments_GridControl = {
    setupBse_AttachmentsGrid: function(grid, pager, search, dataurl) {
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
            caption: '模块信息列表',
            footerrow: false,
            colNames: ['附件序号', '内置对象', '模块编码', '单据编码', '附件名称', '附件创建时间', '附件更新时间', '附件创建人', '附件更新人', '状态', '附件地址', '内置显示与否'],
            colModel: [{ name: 'AT_ID', index: 'AT_ID', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Dict_Code', index: 'Dict_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Module_Code', index: 'Module_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Record_ID', index: 'Record_ID', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AT_Name', index: 'AT_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AT_CDate', index: 'AT_CDate', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AT_UDate', index: 'AT_UDate', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AT_Creator', index: 'AT_Creator', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AT_Updator', index: 'AT_Updator', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stat', index: 'Stat', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AT_URL', index: 'AT_URL', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Dict_Code_display', index: 'Dict_Code_display', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var create = "<a href='#' onclick='javascript:Bse_Attachments_GridControl.AddPlan()'><img src='../../Content/images/add1.png' border='0';alt='添加' /></a>&nbsp;";
                    var objEvent = "onclick='javascript:Bse_Attachments_GridControl.InitEdit(\"" + ret.AT_CDate + "\");'";
                    var be = "<a href='#' " + objEvent + "><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp;";
                    var del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>"; 
                    if (ret.AT_URL == "" || ret.AT_URL == null) {
                        url = "<a href='#'>未上传附件</a>";
                    } else {
                        url = "<a href=../.." + ret.AT_URL + ">附件下载</a>";
                    }
                    grid.jqGrid('setRowData', ids[i], { Edit: create + be + del, AT_URL: url });
                }
            },
            userDataOnFooter: true
        });
    },
    AddPlan: function() {
        $("#stuff")[0].reset();
        $("#finaceOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/Attachments/AttachmentsEdit",
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
        if (data != "false") {
            $("#finaceOperation").dialog("close");
            $("#grid").trigger("reloadGrid");
            ShowMsg('操作成功!');
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
        var searchobj = targetPreFix + 'search';
        Bse_Attachments_GridControl.setupBse_AttachmentsGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
