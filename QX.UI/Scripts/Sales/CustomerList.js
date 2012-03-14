var Sales_CustomerList =
{
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
            caption: '客户列表',
            footerrow: false,
            colNames: ['客户编码', '客户名称', '客户性质', '客户资质', '法人代表', '联系人', '座机', '手机', '传真', '电子邮件', '客户网址', '邮编', '介绍'],
            colModel: [{ name: 'WHS_CustCode', index: 'WHS_CustCode', width: 150, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_CustName', index: 'WHS_CustName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_Property', index: 'WHS_Property', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_Aptitude', index: 'WHS_Aptitude', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_LegalPerson', index: 'WHS_LegalPerson', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_ContactPerson', index: 'WHS_ContactPerson', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_Telphone', index: 'WHS_Telphone', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_MobilePhone', index: 'WHS_MobilePhone', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_Fax', index: 'WHS_Fax', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'WHS_Email', index: 'WHS_Email', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'WHS_Site', index: 'WHS_Site', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'WHS_ZipCode', index: 'WHS_ZipCode', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'WHS_Introduction', index: 'WHS_Introduction', width: 100, align: 'center', sortable: false, hidden: true}],
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
    InitSupplyGrid: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        Sales_CustomerList.setupWH_SupplierGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    },
    InitData: function() {
    Sales_CustomerList.InitSupplyGrid("/Sales/GetCustomerList", "cust");
    }
}