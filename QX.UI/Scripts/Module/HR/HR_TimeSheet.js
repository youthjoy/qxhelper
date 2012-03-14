
var HR_TimeSheet_GridControl = {
    setupHR_TimeSheetGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['操作', '考勤编码', '员工编码', '考勤类型', '开始时间', '结束时间', '工时', '理由'],
            colModel: [{ name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Code', index: 'TS_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_StuffCode', index: 'TS_StuffCode', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'TS_Type', index: 'TS_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Start', index: 'TS_Start', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_End', index: 'TS_End', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Total', index: 'TS_Total', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Matter', index: 'TS_Matter', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];

                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var objEvent = "onclick='javascript:HR_TimeSheet_GridControl.InitEdit(\"" + ret.TS_Code + "\");";
                    var be = "<a href='#' " + objEvent + ">编辑</a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be });

                }
            },
            userDataOnFooter: true
        }).navGrid('#pager', { refresh: true, edit: false, add: false, del: false, search: true });
    },
    InitEdit: function(code) {
        $.ajax({
            type: "post",
            url: "/HR/GetHRTimeSheet",
            dataType: "json",
            data: { id: code },
            success: function(data, textStatus) {
                //动态赋值
                for (var p in data) {
                    $("#" + p).val(data[p]);
                }
            }
        });
        $("#tsOperation").dialog("open");
    },
    SaveEditData: function() {
        $("#stuff").submit();
    },
    AfterSaveEdit: function(data) {
        if (data == "success") {
            // $("#stuff").eq(0).reset();
            $("#tsOperation").dialog("close");
            $("#grid").trigger("reloadGrid"); 
        }
        else {

        }
    },
    CancelEdit: function() {
        $("#tsOperation").dialog("close");
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        HR_TimeSheet_GridControl.setupHR_TimeSheetGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
