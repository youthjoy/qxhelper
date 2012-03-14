
var HR_AA_GridControl = {
    setupHR_AAGrid: function(grid, pager, search, dataurl) {
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
            caption: '奖惩信息列表',
            footerrow: false,
            colNames: ['奖惩序号', '奖惩编码', '员工编码', '员工名称', '奖惩类型', '奖惩时间', '说明', ''],
            colModel: [
             { name: 'AA_ID', index: 'AA_ID', width: 100, align: 'center', sortable: false, hidden: true },
             { name: 'AA_ICode', index: 'AA_ICode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AA_ECde', index: 'AA_ECde', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AA_EName', index: 'AA_EName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AA_Type', index: 'AA_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AA_Date', index: 'AA_Date', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AA_Content', index: 'AA_Content', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'AA_Sum', index: 'AA_Sum', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    // var ret = grid.jqGrid('getRowData', cl);
                    //grid.jqGrid('setRowData', ids[i], { Edit: be });
                }
            },
            userDataOnFooter: true
        }).navGrid('#pager', { refresh: true, edit: false, add: false, del: false, search: true });
    },
    AddPlan: function(newCode) {
        $("#stuff")[0].reset();
        $("#AA_ID").val("0");
        $("#finaceOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/HR/AA_ContactEdit",
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
        if (!$('#stuff').validate().form()) {
            return false;
        }

        else {
            $("#stuff").submit();
        }
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
        HR_AA_GridControl.setupHR_AAGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}



