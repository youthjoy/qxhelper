
//评审
var WH_CEItem_GridControl = {
    setupWH_CEItemGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['评分编码', '供应商编码', '评分模块', '评分模块名称', '评分数值', '评分描述', '评分人', '评分部门', '评分日期', '排序'],
            colModel: [{ name: 'CEI_Code', index: 'CEI_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_CustCode', index: 'CEI_CustCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Key', index: 'CEI_Key', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Name', index: 'CEI_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Value', index: 'CEI_Value', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Content', index: 'CEI_Content', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Stuff', index: 'CEI_Stuff', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Dept', index: 'CEI_Dept', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Date', index: 'CEI_Date', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'CEI_Order', index: 'CEI_Order', width: 100, align: 'center', sortable: false, hidden: false}],
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
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        WH_CEItem_GridControl.setupWH_CEItemGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}

//供应商发票

var WH_Invoice_GridControl = {
    setupWH_InvoiceGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['发票编码', '供应商编码', '供应商名称', '发票金额', '关联结算单据'],
            colModel: [{ name: 'WHI_Code', index: 'WHI_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHI_SCode', index: 'WHI_SCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHI_SName', index: 'WHI_SName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHI_Sum', index: 'WHI_Sum', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHI_CCode', index: 'WHI_CCode', width: 100, align: 'center', sortable: false, hidden: false}],
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
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        WH_Invoice_GridControl.setupWH_InvoiceGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}

//供应商财务


//供应商合同


var WH_Contract_GridControl = {
    setupWH_ContractGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['合同编码', '合同名称', '合同类型', '客户编码', '客户名称', '签约形式', '合同摘要', '合同评审阶段', '审核人', '审核状态', '审核时间'],
            colModel: [{ name: 'Contract_Code', index: 'Contract_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Contract_Name', index: 'Contract_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Contract_Func', index: 'Contract_Func', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Contract_CustCode', index: 'Contract_CustCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Contract_CustName', index: 'Contract_CustName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Contract_Type', index: 'Contract_Type', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Contract_Abs', index: 'Contract_Abs', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'VerifyStep', index: 'VerifyStep', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'VerifyStuff', index: 'VerifyStuff', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'VerifyStat', index: 'VerifyStat', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'VerifyDate', index: 'VerifyDate', width: 100, align: 'center', sortable: false, hidden: false}],
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
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        WH_Contract_GridControl.setupWH_ContractGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
