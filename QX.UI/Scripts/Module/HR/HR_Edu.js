
var HR_EduExperience_GridControl = {
    setupHR_ExperienceGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['操作', '个人经历编码', '员工编码', '员工姓名', '学历类型', '学校', '专业', '简介', '备注', '开始时间', '结束时间'],
            colModel: [{ name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'EX_Code', index: 'EX_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_StuffCode', index: 'EX_StuffCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_StuffName', index: 'EX_StuffName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Type', index: 'EX_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Corrp', index: 'EX_Corrp', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Title', index: 'EX_Title', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Intro', index: 'EX_Intro', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Bak', index: 'EX_Bak', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Start', index: 'EX_Start', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_End', index: 'EX_End', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var objEvent = "onclick='javascript:HR_EduExperience_GridControl.InitEdit(\"" + ret.EX_Code + "\");";
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
            url: "/HR/GetEduExperience",
            dataType: "json",
            data: { id: code },
            success: function(data, textStatus) {
                //动态赋值
                for (var p in data) {
                    $("#" + p).val(data[p]);
                }
            }
        });
        $("#exOperation").dialog("open");
    },
    SaveEditData: function() {
        $("#stuff").submit();
    },
    AfterSaveEdit: function(data) {
        if (data == "success") {
            // $("#stuff").eq(0).reset();
            $("#exOperation").dialog("close");
            $("#grid").trigger("reloadGrid"); 
        }
        else {

        }
    },
    CancelEdit: function() {
        $("#exOperation").dialog("close");
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        HR_EduExperience_GridControl.setupHR_ExperienceGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
