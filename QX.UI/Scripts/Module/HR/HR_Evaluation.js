
var HR_Evaluation_GridControl = {
    setupHR_EvaluationGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['操作','考评编码', '员工编码', '员工姓名', '考评日期', '考评记录', '考评总结', '考评人', '考评等级', '备注'],
            colModel: [{ name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Eva_Code', index: 'Eva_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_StuffCode', index: 'Eva_StuffCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_StuffName', index: 'Eva_StuffName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_Date', index: 'Eva_Date', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_Records', index: 'Eva_Records', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_Conclusion', index: 'Eva_Conclusion', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_Manager', index: 'Eva_Manager', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_Level', index: 'Eva_Level', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eva_Bak', index: 'Eva_Bak', width: 100, align: 'center', sortable: false, hidden: true}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var objEvent = "onclick='javascript:HR_Evaluation_GridControl.InitEdit(\"" + ret.Eva_Code + "\");";
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
            url: "/HR/GetEvaluation",
            dataType: "json",
            data: { id: code },
            success: function(data, textStatus) {
                //动态赋值
                for (var p in data) {
                    $("#" + p).val(data[p]);
                }
            }
        });
        $("#evaOperation").dialog("open");
    },
    SaveEditData: function() {
        $("#stuff").submit();
    },
    AfterSaveEdit: function(data) {
        if (data == "success") {
            // $("#stuff").eq(0).reset();
            $("#evaOperation").dialog("close");
            $("#grid").trigger("reloadGrid"); 
        }
        else {

        }
    },
    CancelEdit: function() {
        $("#evaOperation").dialog("close");
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        HR_Evaluation_GridControl.setupHR_EvaluationGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
