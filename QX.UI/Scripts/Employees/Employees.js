var HR_Stuff_GridControl = {
    setupHR_StuffGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['员工序号', '员工编码', '员工姓名', '英文名', '职位', '职称', '部门编码', '部门名称', '直接上级', '办公室电话', '手机', '电子邮件', '传真', '住宅电话', '住址', '入职日期', '离职日期', '员工状态', '性别', '出生日期', '婚姻状况', '子女数目', '身份证号', '护照', '国籍', '省份', '员工工资', '员工成本', '', '', '', '状态', '创建时间', '创建人', '紧急联系人', '附件', '内置对象', '内置对象显示与否'],
            colModel: [{ name: 'Stuff_ID', index: 'Stuff_ID', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Code', index: 'Stuff_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Name', index: 'Stuff_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_ENName', index: 'Stuff_ENName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Duty', index: 'Stuff_Duty', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Title', index: 'Stuff_Title', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_DepCode', index: 'Stuff_DepCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_DepName', index: 'Stuff_DepName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Director', index: 'Stuff_Director', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_OTel', index: 'Stuff_OTel', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Mobile', index: 'Stuff_Mobile', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Email', index: 'Stuff_Email', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Fax', index: 'Stuff_Fax', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_HTel', index: 'Stuff_HTel', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Addr', index: 'Stuff_Addr', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Start', index: 'Stuff_Start', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Left', index: 'Stuff_Left', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Stat', index: 'Stuff_Stat', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Gender', index: 'Stuff_Gender', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Birth', index: 'Stuff_Birth', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Married', index: 'Stuff_Married', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Child', index: 'Stuff_Child', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_IDCard', index: 'Stuff_IDCard', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_FCard', index: 'Stuff_FCard', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Nation', index: 'Stuff_Nation', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Province', index: 'Stuff_Province', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Salary', index: 'Stuff_Salary', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Cost', index: 'Stuff_Cost', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Type', index: 'Stuff_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_InsuraceStat', index: 'Stuff_InsuraceStat', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stuff_Cost1', index: 'Stuff_Cost1', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stat', index: 'Stat', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CreateTime', index: 'CreateTime', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Creator', index: 'Creator', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Eperson', index: 'Eperson', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Attachment', index: 'Attachment', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Dict_Code', index: 'Dict_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Dict_Code_display', index: 'Dict_Code_display', width: 100, align: 'center', sortable: false, hidden: false}],
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
    Select: function() {
        var grid = $("#grid");
        var curid = grid.getGridParam("selrow"); //获取选择行的id
        var list = grid.getRowData(curid);
        return list;
    },
    Open: function() {
        $("#finaceOperation").dialog("open");
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        HR_Stuff_GridControl.setupHR_StuffGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
