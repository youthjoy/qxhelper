
var HR_In_GridControl = {
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
                $grid.setGridParam({ url: '/HR/FinanceList/' + ret.Stuff_Code });
                $grid.trigger("reloadGrid");
            },
            userDataOnFooter: true
        }).navGrid("#indexpager", { refresh: true, edit: false, add: false, del: false, search: true });

    },
    InitIndexGrid: function(dataurl, targetPreFix) {

        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        HR_In_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);

    },
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
            caption: '职位变动信息列表',
            footerrow: false,
            colNames: [ '员工姓名', 'id', '员工编码', '财务信息编码', '原职位', '原工资', '现职位', '现工资', '说明', '备注'],
            colModel: [
            
             { name: 'HM_EName', index: 'HM_EName', width: 100, align: 'center', sortable: false, hidden: false },
             { name: 'HM_ID', index: 'HM_ID', width: 100, align: 'center', sortable: false, hidden: true },
            { name: 'HM_ECode', index: 'HM_ECode', width: 100, align: 'center', sortable: false, hidden: false },
          { name: 'HM_InCode', index: 'HM_InCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_OTitle', index: 'HM_OTitle', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_OSalary', index: 'HM_OSalary', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_CTitle', index: 'HM_CTitle', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_CSalary', index: 'HM_CSalary', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_Content', index: 'HM_Content', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'HM_Bak', index: 'HM_Bak', width: 100, align: 'center', sortable: false, hidden: false}],
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
        $("#HM_ID").val("0");
        $("#finaceOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/HR/HM_ContactEdit",
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

        HR_In_GridControl.setupHR_InGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
