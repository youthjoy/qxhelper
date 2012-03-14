
var Audit_Templdate_GridControl = {
    setupAudit_TempldateGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['模板ID', '操作', '模板编码', '模板关键字', '模板名称', '模板描述', '状态'],
            colModel: [
 { name: 'Template_ID', index: 'Template_ID', width: 100, align: 'center', sortable: false, hidden: true },
 { name: 'Eidt', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Template_Code', index: 'Template_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Template_Key', index: 'Template_Key', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Template_Name', index: 'Template_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Template_Remark', index: 'Template_Remark', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stat', index: 'Stat', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    grid.jqGrid('setRowData', ids[i], { Edit: be });
                }
            },
            userDataOnFooter: true
        });
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        Audit_Templdate_GridControl.setupAudit_TempldateGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}