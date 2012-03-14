/// <reference path="../../jquery-1.4.1-vsdoc.js" />
$(document).ready(function() {
    WH_Supplier_GridControl.Init("/Vendor/SupplierList", "");
});



var WH_Supplier_GridControl = {
    setupWH_SupplierGrid: function(grid, pager, search, dataurl) {
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
            caption: '供应商列表',
            footerrow: false,
            colNames: ['操作','供应商编码', '供应商名称', '供应商性质', '供应商资质', '法人代表', '联系人', '座机', '手机', '传真', '电子邮件', '供应商网址', '邮编', '介绍'],
            colModel: [
                { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_CustCode', index: 'MV_CustCode', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_CustName', index: 'MV_CustName', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_Property', index: 'MV_Property', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_Aptitude', index: 'MV_Aptitude', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_LegalPerson', index: 'MV_LegalPerson', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_ContactPerson', index: 'MV_ContactPerson', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_Telphone', index: 'MV_Telphone', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_MobilePhone', index: 'MV_MobilePhone', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_Fax', index: 'MV_Fax', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_Email', index: 'MV_Email', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_Site', index: 'MV_Site', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_ZipCode', index: 'MV_ZipCode', width: 100, align: 'center', sortable: false, hidden: false },
                { name: 'MV_Introduction', index: 'MV_Introduction', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var create = "<a href='Create'>添加</a>&nbsp;";
                    be = "<a href='Edit/" + ret.MV_CustCode + "'>编辑</a>";
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
        WH_Supplier_GridControl.setupWH_SupplierGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}

