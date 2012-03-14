/// <reference path="../../jquery-1.4.1-vsdoc.js" />
var Customer_Operation =
{
    setupWH_PayGrid: function(grid, pager, search, dataurl) {
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
            caption: '付款情况',
            footerrow: false,
            colNames: ['付款日期', '付款单位名称', '付款方式', '付款金额', '', '', '财务经手人', '采购经手人', '备注'],
            colModel: [{ name: 'WHPP_Date', index: 'WHPP_Date', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHPP_PName', index: 'WHPP_PName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHPP_PayMethod', index: 'WHPP_PayMethod', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHPP_Sum', index: 'WHPP_Sum', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHPP_RefType', index: 'WHPP_RefType', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'WHPP_RefCode', index: 'WHPP_RefCode', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'WHPP_FOwner', index: 'WHPP_FOwner', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHPP_POwner', index: 'WHPP_POwner', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHPP_Bak', index: 'WHPP_Bak', width: 100, align: 'center', sortable: false, hidden: false}],
            userDataOnFooter: true
        });
    },
    InitPay: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        Customer_Operation.setupWH_PayGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    },
    setupWH_BanlanceGrid: function(grid, pager, search, dataurl) {
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
            colNames: ['结算周期', '上月结余', '本月供货', '本月结余', '结算日期'],
            colModel: [{ name: 'WHB_Period', index: 'WHB_Period', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHB_LastMonth', index: 'WHB_LastMonth', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHB_NextMoth', index: 'WHB_NextMoth', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHB_CurMonth', index: 'WHB_CurMonth', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHB_Date', index: 'WHB_Date', width: 100, align: 'center', sortable: false, hidden: false}],
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
    InitBanlance: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        Customer_Operation.setupWH_BanlanceGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    },
    setupPU_MainGrid: function(grid, pager, search, dataurl) {
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
            footerrow: false,
            colNames: ['单据编码', '单据类型', '', '', '供应商名称', '供应商联系人', '供应商联系人电话', '过账日期', '交货日期', '单据日期', '单据负责人', '运费', '折扣', '折扣金额', '税额', '应付账款', '备注', '业务负责人'],
            colModel: [{ name: 'PUM_Code', index: 'PUM_Code', width: 100, align: 'center', sortable: false, hidden: false },
      { name: 'PUM_TypeDescription', index: 'PUM_TypeDescription', width: 140, align: 'center', sortable: false, hidden: false },
      { name: 'PUM_Type', index: 'PUM_Type', width: 100, align: 'center', sortable: false, hidden: true },
      { name: 'PUM_TechType', index: 'PUM_TechType', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_SName', index: 'PUM_SName', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_SContact', index: 'PUM_SContact', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_STel', index: 'PUM_STel', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_PDate', index: 'PUM_PDate', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'PUM_IDate', index: 'PUM_IDate', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_RDate', index: 'PUM_RDate', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_Owner', index: 'PUM_Owner', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_Tranfee', index: 'PUM_Tranfee', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'PUM_Discount', index: 'PUM_Discount', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'PUM_DisSum', index: 'PUM_DisSum', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'PUM_Tax', index: 'PUM_Tax', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'PUM_Payable', index: 'PUM_Payable', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'PUM_Bak', index: 'PUM_Bak', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'PUM_BOwner', index: 'PUM_BOwner', width: 100, align: 'center', sortable: false, hidden: false}],
            userDataOnFooter: true
        });
    },
    CreateOrder: function() {
        var scode = $("#WHS_CustCode").val();
        location = "/PU/CreateWithSup/" + scode + "-PO";

    },
    ToolBarInit: function() {
        //待收货列表
//        var $toolbar = $("#PUtoolbar").find("ul");
//        $toolbar.empty();
//        $toolbar.append("<li id='PU_toolbar_rec' class='toolbar_add'><a onclick='Customer_Operation.CreateOrder()' href='#'>订单</a></li>");

    },
    CustomerOperationFormID: 'WH_Supplier_Top_Form',
    SaveData: function() {
        if (!$('#' + Customer_Operation.CustomerOperationFormID).validate().form()) {
            return false;
        }

        $("#" + Customer_Operation.CustomerOperationFormID).submit();

    },
    CancelEdit: function() {
        //history.back();
        location = "/Sales/CustomerList";
    },
    InitPUGrid: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        Customer_Operation.setupPU_MainGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    },
    OtherInit: function() {
        //变量初始化
//        $("#WHS_Site").val("http://www.");
//        $("#WHS_Email").val("email@email.com");
//        $("#WHS_ZipCode").val("400000");

        //参考初始化
//        Common_Select_Dict.Init($('#WHS_Group'), 'CLIENT'); //供应商组参考    字段名 ---关键字
//        Common_Select_Dict.Init($('#WHS_Property'), 'CUSTPROP'); //客户性质
//        Common_Select_Dict.Init($('#WHS_Aptitude'), 'CUSTCAT'); //客户资质


    },
    InitData: function() {
        $("#tabs").tabs();
        Customer_Operation.OtherInit();
        Customer_Operation.ToolBarInit();

        var moptions = {
        success: function(data) { if (data.result == "success") { ShowMsg("成功");location = "/Sales/CustomerList"; }  },  // post-submit callback
            width: 800,
            timeout: 3000
        };

        //供应商基本信息
        $("#" + Customer_Operation.CustomerOperationFormID).ajaxForm(moptions);

        var formOper = $("#CustomerFormoper").val();
        var rCode = $("#WHS_CustCode").val();



        if (formOper == "edit" && rCode != undefined) {


            //采购往来
            Customer_Operation.InitPUGrid("/Sales/PUList/" + rCode, "pu");
            //结算情况
            Customer_Operation.InitBanlance("/Sales/SupBanlanceList/" + rCode, "ban");
            //结算情况
            Customer_Operation.InitPay("/Sales/SupPayList/" + rCode, "pay");

        }
        else {
//            $.ajax({
//                type: 'post',
//                url: '/Sales/GenerateCustomerCode',
//                success: function(result) {
//                    $('#WHS_CustCode').val(result);
//                    //设备通用联系人单据编码
//                }
//            });
        }
    }
}