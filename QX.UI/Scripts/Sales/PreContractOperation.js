/// <reference path="../../jquery-1.4.1-vsdoc.js" />
/// <reference path="../Shared/Session.js" />

var PreContract_Operation =
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
        PreContract_Operation.setupWH_PayGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
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
        PreContract_Operation.setupWH_BanlanceGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
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
        var scode = $("#SDC_Code").val();
        location = "/PU/CreateWithSup/" + scode + "-PO";

    },
    ToolBarInit: function() {
        //待收货列表
        var $toolbar = $("#PUtoolbar").find("ul");
        $toolbar.empty();
        $toolbar.append("<li id='PU_toolbar_rec' class='toolbar_add'><a onclick='PreContract_Operation.CreateOrder()' href='#'>订单</a></li>");

    },
    ContractOperationFormID: 'ContractInfoForm',
    SaveData: function() {
        //$("#ContractEditType").val("valid");
        if (!$('#' + PreContract_Operation.ContractOperationFormID).validate().form()) {
            return false;
        }

        $("#" + PreContract_Operation.ContractOperationFormID).submit();

    },
    AfterSaveDraft: function(result) {
        if (result == "success") {

            if ($("#ContractEditType").val() == "draft") {

            }
            else {
                window.location = "/Sales/QPreContractList/PreCust?tab=#tabs-4";
            }

        } else {
            ShowMsg("操作失败!请重试");
        }

    },
    SaveDraft: function() {
        $("#ContractEditType").val("draft");
        if (!$('#' + PreContract_Operation.ContractOperationFormID).validate().form()) {
            return false;
        }
        //$("#ContractFormoper").val("draft");
        $("#" + PreContract_Operation.ContractOperationFormID).submit();
    },
    CancelEdit: function() {
    location = "/Sales/QPreContractList/PreCust" + "?tab=" + tab;
        
    },
    InitPUGrid: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        PreContract_Operation.setupPU_MainGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    },
    OtherInit: function() {
        //变量初始化
        Comm_Session.GetLoginUser(function(data) //签约人
        { $('#SDC_OwnerCode').val(data.UserId); $('#SDC_Owner').val(data.UserName); });
        Comm_Session.GetLoginUser(function(data) //执行人
        { $('#SDC_EOwnerCode').val(data.UserId); $('#SDC_EOwner').val(data.UserName); }); //合同执行人
        Comm_Session.GetCurrentDate(function(data) { $('#SDC_Date').val(data); }); //签约日期
        Comm_Session.GetCurrentDate(function(data) { $('#SDC_Start').val(data); }); //合同生效时间
        //参考初始化
        Common_Select_Dict.Init($('#SDC_TechDecision'), 'TechSup'); //技术提供方  字段名 ---关键字
        Common_Select_Dict.Init($('#SDC_PayContent'), 'CustBan'); //结算方式
        Common_Select_Dict.Init($('#SDC_Control'), 'CControl'); //信控方式
        Common_Select_Dict.Init($('#SDC_IsAFor'), 'CSupply'); //是否甲供
        //绑定客户选择
        $("#SDC_CCode").live("click", function() {
            Ref_CusomterWH_SupplierOpenReferWithFilter("", function(data) {
                $("#SDC_CCode").val(data.WHS_CustCode);
                $("#SDC_CName").val(data.WHS_CustName);
                $("#SDC_CContact").val(data.WHS_Telphone);
                $("#SDC_COwner").val(data.WHS_LegalPerson);
                $("#SDC_Dept").val(data.WHS_CustName); //合同单位
                //                for (var i = 0; i < data.length; i++) {
                //                    $("#SDC_CCode").val(data[i].WHS_CustCode);
                //                    $("#SDC_CName").val(data[i].WHS_CustName);
                //                }
            });
        });
        $('#SDC_Place').val("中国重庆涪陵");
        //绑定人员选择
        Common_EmpTree_Dept.Init("SDC_Owner", function(code, name) { $("#SDC_Owner").val(name); $("#SC_OwnerCode").val(code) });
        Common_EmpTree_Dept.Init("SDC_EOwner", function(code, name) { $("#SDC_EOwner").val(name); $("#SDC_EOwnerCode").val(code) });
    },
    InitData: function() {
        $("#tabs").tabs();
        //PreContract_Operation.OtherInit();
        //PreContract_Operation.ToolBarInit();

        var moptions = {
            success: function(data) { if (data.result == "success") { ShowMsg("操作成功"); PreContract_Operation.AfterSaveDraft(data.result); } },  // post-submit callback
            width: 800,
            timeout: 3000
        };

        //供应商基本信息
        $("#" + PreContract_Operation.ContractOperationFormID).ajaxForm(moptions);

        var formOper = $("#ContractFormoper").val();
        var rCode = $("#SDC_Code").val();



        if (formOper == "edit" && rCode != undefined) {


            //采购往来
            PreContract_Operation.InitPUGrid("/Sales/PUList/" + rCode, "pu");
            //结算情况
            PreContract_Operation.InitBanlance("/Sales/SupBanlanceList/" + rCode, "ban");
            //结算情况
            PreContract_Operation.InitPay("/Sales/SupPayList/" + rCode, "pay");

        }
        else {
            //            $.ajax({
            //                type: 'post',
            //                url: '/Sales/GenerateContractCode',
            //                success: function(result) {
            //                    $('#SDC_Code').val(result);
            //                    //设备通用联系人单据编码
            //                    comm_Bse_ContactsModule.SetId(result);
            //                    comm_Bse_AddressModule.SetId(result);
            //                }
            //            });
        }
    }
}