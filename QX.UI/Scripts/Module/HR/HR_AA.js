
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
            caption: '信息列表',
            footerrow: false,
            colNames: ['操作','奖惩编码', '员工编码', '员工名称', '奖惩类型', '奖惩时间', '说明', ''],
            colModel: [{ name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
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
                    var ret = grid.jqGrid('getRowData', cl);
                    var objEvent = "onclick='javascript:HR_AA_GridControl.InitEdit(\"" + ret.AA_ICode + "\");";
                    var be = "<a href='#' " + objEvent + ">编辑</a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be });
                }
            },
            userDataOnFooter: true
        }).navGrid('#pager',  {refresh: true, edit: false, add: false, del: false, search: true });
    },
    InitEdit: function(code) {
        $.ajax({
            type: "post",
            url: "/HR/GetHR_AA",
            dataType: "json",
            data: { id: code },
            success: function(data, textStatus) {
                //动态赋值
                for (var p in data) {
                    $("#" + p).val(data[p]);
                }
            }
        });
        $("#aaOperation").dialog("open");
    },
    SaveEditData: function() {
        $("#stuff").submit();
    },
    AfterSaveEdit: function(data) {
        if (data == "success") {
            // $("#stuff").eq(0).reset();
            $("#aaOperation").dialog("close");
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
        HR_AA_GridControl.setupHR_AAGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
