
var HR_In_GridControl = {
    setupHR_InGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['操作', '员工编码', '财务信息编码', '原职位', '原工资', '现职位', '现工资', '说明', '备注'],
            colModel: [
             { name: 'Edit', index: 'Edit', width: 150, align: 'center', sortable: false, hidden: false },
            { name: 'HM_ECode', index: 'HM_ECode', width: 100, align: 'center', sortable: false, hidden: false },
          { name: 'HM_InCode', index: 'HM_InCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_OTitle', index: 'HM_OTitle', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_OSalary', index: 'HM_OSalary', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_CTitle', index: 'HM_CTitle', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_CSalary', index: 'HM_CSalary', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_Content', index: 'HM_Content', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_Bak', index: 'HM_Bak', width: 100, align: 'center', sortable: false, hidden: true}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var objEvent = "onclick='javascript:HR_In_GridControl.InitEdit(\"" + ret.HM_InCode + "\");";
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
            url: "/HR/GetHRFinace",
            data: { id: code },
            success: function(data, textStatus) {
                //动态赋值
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
            // $("#stuff").eq(0).reset();
            $("#finaceOperation").dialog("close");
            $("#grid").trigger("reloadGrid"); 
        }
        else {

        }
    },
    CancelEdit: function() {
        $("#finaceOperation").dialog("close");
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        HR_In_GridControl.setupHR_InGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
