
var HR_Benefit_GridControl = {
    setupHR_BenefitGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['操作', '员工福利编码', '员工编码', '福利关键字', '福利名称', '金额', '是否办理', '办理时间', '下一次办理时间', '备注1', '备注2'],
            colModel: [{ name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'HRB_Code', index: 'HRB_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_ECode', index: 'HRB_ECode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_Key', index: 'HRB_Key', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_Name', index: 'HRB_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_Sum', index: 'HRB_Sum', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_IsDone', index: 'HRB_IsDone', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_Date', index: 'HRB_Date', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_NextDate', index: 'HRB_NextDate', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_Bak1', index: 'HRB_Bak1', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HRB_Bak2', index: 'HRB_Bak2', width: 100, align: 'center', sortable: false, hidden: false}],
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
    //$("#AA_ID").val("0");
        $("#beOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax({
            type: "post",
            url: "/HR/GetHR_Benefit",
            dataType: "json",
            data: { id: code },
            success: function(data, textStatus) {
                //动态赋值
                for (var p in data) {
                    $("#" + p).val(data[p]);
                }
            }
        });
        $("#beOperation").dialog("open");
    },
    SaveEditData: function() {
        $("#stuff").submit();
    },
    AfterSaveEdit: function(data) {
        $("#beOperation").dialog("close");
        $("#grid").trigger("reloadGrid");
    },
    CancelEdit: function() {
        $("#beOperation").dialog("close");
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        HR_Benefit_GridControl.setupHR_BenefitGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
