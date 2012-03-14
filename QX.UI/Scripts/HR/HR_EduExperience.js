var HR_EduSExperience_GridControl = {
setupHR_EduSExperienceGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['操作', '经历序号', '个人经历编码', '员工编码', '员工姓名', '学历类型', '学历', '专业', '简介', '备注', '', '', ''],
            colModel: [{ name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false }, { name: 'EX_ID', index: 'EX_ID', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Code', index: 'EX_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_StuffCode', index: 'EX_StuffCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_StuffName', index: 'EX_StuffName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Type', index: 'EX_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Corrp', index: 'EX_Corrp', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Title', index: 'EX_Title', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Intro', index: 'EX_Intro', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Bak', index: 'EX_Bak', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'EX_Start', index: 'EX_Start', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'EX_End', index: 'EX_End', width: 100, align: 'center', sortable: false, hidden: true },
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
        });
    },
    AddPlan: function(newCode) {
    $("#stuff")[0].reset();
    $("#EXa_ID").val("0");
        $("#exOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/HR/GetExperience",
            data: { id: code },
            dataType: "json",
            success: function(data, textStatus) {
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
        var searchobj = targetPreFix + 'search';
        HR_EduSExperience_GridControl.setupHR_EduSExperienceGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}





var HR_EduSSExperience_GridControl = {
    setupHR_EduSSExperienceGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['操作', '经历序号', '个人经历编码', '员工编码', '员工姓名', '学历类型', '学历', '专业', '简介', '备注', '', '', ''],
            colModel: [{ name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false }, { name: 'EX_ID', index: 'EX_ID', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Code', index: 'EX_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_StuffCode', index: 'EX_StuffCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_StuffName', index: 'EX_StuffName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Type', index: 'EX_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Corrp', index: 'EX_Corrp', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Title', index: 'EX_Title', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Intro', index: 'EX_Intro', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'EX_Bak', index: 'EX_Bak', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'EX_Start', index: 'EX_Start', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'EX_End', index: 'EX_End', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Stat', index: 'Stat', width: 100, align: 'center', sortable: false, hidden: true}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    be = "<a href='/HR/HR_EduExperience/" + ret.EXa_StuffCode + "'>编辑</a>";
                    grid.jqGrid('setRowData', ids[i], { Edit:  be });
                }
            },
            userDataOnFooter: true
        });
    },
    AddPlan: function(newCode) {
        $("#stuff")[0].reset();
        $("#EXa_ID").val("0");
        $("#exOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/HR/GetExperience",
            data: { id: code },
            dataType: "json",
            success: function(data, textStatus) {
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
        var searchobj = targetPreFix + 'search';
        HR_EduSSExperience_GridControl.setupHR_EduSSExperienceGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}