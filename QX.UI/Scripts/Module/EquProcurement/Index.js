/// <reference path="../../jquery-1.4.1-vsdoc.js" />
$(document).ready(function() {
    WH_Movement_GridControl.Init("/EquProcurement/List", "");
});

var WH_Movement_GridControl = {
    setupWH_MovementGrid: function(grid, pager, search, dataurl) {
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
            caption: '采购列表',
            footerrow: false,
            colNames: ["操作",'单据编码', '库存移动类型', '参考单据类型', '参考单据编码', '创建人', '创建时间', '更新人', '删除时间', '供应商编码', '供应商名称', '交货日期', '审核状态'],
            colModel: [ { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_RecordCode', index: 'MV_RecordCode', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_MType', index: 'MV_MType', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_RefKey', index: 'MV_RefKey', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_RefRecord', index: 'MV_RefRecord', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'Creator', index: 'Creator', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'CreateTime', index: 'CreateTime', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'UPTStuff', index: 'UPTStuff', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'DELDate', index: 'DELDate', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_CustCode', index: 'MV_CustCode', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_CustName', index: 'MV_CustName', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_CustDate', index: 'MV_CustDate', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_VerifyStat', index: 'MV_VerifyStat', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var create = "<a href='Create'>添加</a>&nbsp;";
                    be = "<a href='Edit/" + ret.MV_RecordCode + "'>编辑</a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: create + be });
                }
            },
            userDataOnFooter: true
        });
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        WH_Movement_GridControl.setupWH_MovementGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}

