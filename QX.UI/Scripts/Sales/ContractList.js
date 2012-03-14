var Sales_ContractList =
{
    setupSD_ContractGrid: function(grid, pager, search, dataurl) {
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
            caption: '客户合同管理',
            footerrow: false,
            colNames: ['合同基本信息序号', '合同编码', '客户名称', '客户编码', '签约时间', '签约地点', '签约人', '合同开始时间', '合同结束时间', '合同方量', '结算方式', '信控方式', '是否甲供'],
            colModel: [{ name: 'SDC_ID', index: 'SDC_ID', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'SDC_Code', index: 'SDC_Code', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_CName', index: 'SDC_CName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_CCode', index: 'SDC_CCode', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'SDC_Date', index: 'SDC_Date', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_Place', index: 'SDC_Place', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'SDC_Owner', index: 'SDC_Owner', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_Start', index: 'SDC_Start', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_End', index: 'SDC_End', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_Num', index: 'SDC_Num', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_PayContent', index: 'SDC_PayContent', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'SDC_Control', index: 'SDC_Control', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'SDC_IsAFor', index: 'SDC_IsAFor', width: 100, align: 'center', sortable: false, hidden: true}],
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
    SaveEditData: function() { },
    CancelEdit: function() { },
    InitGrid: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        Sales_ContractList.setupSD_ContractGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    },
//    Receive: function() {
//        var grid = $('#contrgrid');
//        var curid = grid.getGridParam('selrow'); //获取选择行的id
//        var data = grid.getRowData(curid); //获取行号为curid的数据
//        if (data.PUM_RCode == undefined) {
//            ShowMsg('请选中编辑行');
//            return;
//        }
//        location = "/PU/PUReceive/" + data.PUM_RCode + "-PRR";
//    },
    Audit: function() {
        var grid = $('#onAuditgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据
        if (data.SDC_Code == undefined) {
            ShowMsg('请选中需要审核的合同');
            return;
        }

        AuditInstance.Init("SD_Contract", "SDC_Code", data.SDC_Code);

        $('#AuditLayer').dialog('open');
    },
    ToolBarInit: function() {
        //待收货列表
//        var $toolbar = $("#contrtoolbar").find("ul");
//        $toolbar.append("<li id='contr_toolbar_rec' class='toolbar_add'><a onclick='PU_POList.Receive()' href='#'>收货</a></li>");

        //待审核列表
       var $toolbar1 = $("#onAudittoolbar").find("ul");
        $toolbar1.empty();
        $toolbar1.append("<li id='onAudit_toolbar_rec' class='toolbar_add'><a onclick='Sales_ContractList.Audit();' href='#'>审核</a></li>");

    },
    InitData: function() {
        //合同列表
        Sales_ContractList.InitGrid("/Sales/GetContractList/LastAudit-Cust", "contr");
        //审核中合同列表
        Sales_ContractList.InitGrid("/Sales/GetContractList/OnAudit-Cust", "onAudit");
        //全部
        Sales_ContractList.InitGrid("/Sales/GetContractList/All-Cust", "allContr");
        Sales_ContractList.InitGrid("/Sales/GetContractList/My-Cust", "draft");
        //工具栏
        Sales_ContractList.ToolBarInit();
    }
}