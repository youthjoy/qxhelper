
var HR_TimeSheet_GridControl = {
    setupGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['员工编码', '员工名称', '英文名', '职务', '职称', '直接上级', '部门名称', '手机', '电子邮件'],
            colModel: [
                        { name: 'Stuff_Code', index: 'Stuff_Code', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Name', index: 'StuffName', width: 30, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_ENName', index: 'StuffENName', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Duty', index: 'StuffDuty', width: 20, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Title', index: 'Stuff_Title', width: 30, sortable: true, hidden: false },
                        { name: 'Stuff_Director', index: 'Stuf_Director', width: 40, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_DepName', index: 'Stuff_DepName', width: 50, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Mobile', index: 'Stuff_Mobile', width: 50, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Email', index: 'Stuff_Email', width: 50, align: 'center', sortable: false, hidden: false }
                      ],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortname: 'StuffName',
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '员工信息列表',
            footerrow: false,
            onSelectRow: function(row) {
                //读取数据的方法
                var ret = grid.jqGrid('getRowData', row);
                var $grid = $('#grid');
                $grid.setGridParam({ url: '/HR/AttList/' + ret.Stuff_Code });
                $grid.trigger("reloadGrid");
            },
            userDataOnFooter: true
        }).navGrid("#indexpager", { refresh: true, edit: false, add: false, del: false, search: true });

    },
    InitIndexGrid: function(dataurl, targetPreFix) {

        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        HR_TimeSheet_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);

    },
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
            caption: '考勤信息列表',
            footerrow: false,
            colNames: ['考勤序号', '考勤编码', '员工姓名', '员工编码', '考勤类型', '考勤类型', '开始时间', '结束时间', '工时', '理由', '创建人', '创建时间', '审核状态', '审核时间', '审核人', '下一审核状态', ''],
            colModel: [
           
            { name: 'TS_ID', index: 'TS_ID', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'TS_Code', index: 'TS_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_StuffName', index: 'TS_StuffName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_StuffCode', index: 'TS_StuffCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_TypeName', index: 'TS_TypeName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Type', index: 'TS_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Start', index: 'TS_Start', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_End', index: 'TS_End', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Total', index: 'TS_Total', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'TS_Matter', index: 'TS_Matter', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Creator', index: 'Creator', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CreateTime', index: 'CreateTime', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'VerifyStat', index: 'VerifyStat', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'VerifyDate', index: 'VerifyDate', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'VerifyStuff', index: 'VerifyStuff', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'VerifyNext', index: 'VerifyNext', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Stat', index: 'Stat', width: 100, align: 'center', sortable: false, hidden: true}],
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
        $("#TS_ID").val("0");
        $("#finaceOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/HR/TS_ContactEdit",
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
        var searchobj = targetPreFix + 'search';
        HR_TimeSheet_GridControl.setupHR_TimeSheetGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
