
var Supplier_GridControl = {
    setupSupplierGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['供应商序号', '供应商编码', '供应商名称', '供应商性质', '供应商资质', '法人代表', '联系人', '座机', '手机', '传真', '电子邮件', '供应商网址', '邮编', '介绍', '状态', '内置对象', '内置对象显示与否'],
            colModel: [{ name: 'MV_IDS', index: 'MV_IDS', width: 100, align: 'center', sortable: false, hidden: false },
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
{ name: 'MV_Introduction', index: 'MV_Introduction', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Stat', index: 'Stat', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Dict_Code', index: 'Dict_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Dict_Code_display', index: 'Dict_Code_display', width: 100, align: 'center', sortable: false, hidden: false}],
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
        var searchobj = targetPreFix + 'search'
        Supplier_GridControl.setupSupplierGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}

