<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.SD_CPrice>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    合同添加
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .AColorRed a:link
        {
            color: Red;
        }
    </style>
    <div id="ContractInfo">
        <form id="ContractInfoForm" method='post' action="/Sales/ContractOperation">
        <input type='hidden' name='ContractFormoper' id='ContractFormoper' value='add' />
        <input type='hidden' name='ContractType' id='ContractType' value='Audit' />
        <input type='hidden' name='ContractEditType' id='ContractEditType' value='draft' />
        <%=Html.AutoBindForm("SD_ContractModule","SD_Contract_TOP",false,false,false)%>
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">基本信息</a></li>
                <li><a href="#tabs-2">工程信息</a></li>
                <li><a href="#tabs-3">价格信息</a></li>
                <li><a href="#tabs-4">甲供信息</a></li>
                <li><a href="#tabs-5">联系人</a></li>
                <li><a href="#tabs-6">联系地址</a></li>
            </ul>
            <div id="tabs-1">
                <%=Html.AutoBindForm("SD_ContractModule","SD_Contract",false,false,false)%>
            </div>
        </form>
        <div id="tabs-2">
            <%=Html.Common_ToolBarForListPage("All", "addN:'查看工程',addFunJs:'View()',editN:'工程维护',editFunJs:'Add()'")%>
            <%=Html.JqGrid("SD_CProjectModule", "All", "Cust", "All")%>
        </div>
        <div id="tabs-3">
            <table border="0" cellspacing="0" cellpadding="0" width="100%" style="margin-left: 10px">
                <tr>
                    <td valign="top" align="left" width="100px">
                        <div>
                            <input id="PPCode" type="hidden" name="PPCode" value="" />
                            <input id="PPName" type="hidden" name="PPName" value="" />
                            <input id="PDict_Code" type="hidden" name="PDict_Code" value="" />
                            <% 
                                List<QX.Model.Bse_Dict> list = (List<QX.Model.Bse_Dict>)ViewData["Product"];
                                foreach (QX.Model.Bse_Dict item in list)
                                {
                                    Response.Write(string.Format("<li><a href='#' id='{0}' name='{1}' title='{2}' class='Lproduct'>{1}</a></li>",
                                        item.Dict_UDef5, item.Dict_Name, item.Dict_Code)
                                        );
                                }
                            %>
                        </div>
                    </td>
                    <td valign="top">
                        <%--    <%=Html.JqGridListPage("SD_CPriceModule","SD_CPrice","","","")%>--%>
                        <%=Html.Common_ToolBarForListPage("SD_CPriceTool", "addFunJs:'Add()',editFunJs:'Edit()',delFunJs:'Delete()',searchFunJs:'Search()'")%>

                        <script type="text/javascript">
                            $(function() {
                            //cl:查看
                            $("#SD_CPriceTool__toolbar_search").after(" <li style='display:block' id='LastAudit__toolbar_view' class='toolbar_view'><a id='LastAudit__view' onclick='SD_CPriceTool_toolbar_view()' href='#'>查看</a></li>");
                            });
 
                            function SD_CPriceTool_Add() {
                                
                                $('#SD_CPrice_Form')[0].reset();
                                var _oper = $('#SD_CPrice_Formoper').val('add');
                                $('#SD_CPrice_Oper').dialog('open');
                                $.ajax({
                                    type: 'post',
                                    url: '/Sys_Config_ListPage/GetTableKeyCode',
                                    data: { oper: 'add', n: 'SD_CPrice' },
                                    success: function(result) {
                                        //$('#SDP_Code').val(result);
                                        $('#SD_CPrice_Form').find('#SDP_Code').val(result);
                                    }
                                });
                                if (typeof (SD_CPrice_FormLoadAddEx) != 'undefined') {
                                    SD_CPrice_FormLoadAddEx();
                                }
                                if (typeof (SD_CPrice_FormLoadAllEx) != 'undefined') {
                                    SD_CPrice_FormLoadAllEx();
                                }
                                if (typeof (SD_CPrice_FormLoadAfter) != 'undefined') {
                                    SD_CPrice_FormLoadAfter('add');
                                }
                            }
                            function SD_CPriceTool_Edit() {
                                var grid = $('#SD_CPricegrid');
                                var curid = grid.getGridParam('selrow'); //获取选择行的id
                                var data = grid.getRowData(curid); //获取行号为curid的数据            
                                if (data.SDP_Code == undefined) {
                                    ShowMsg('请选中编辑行');
                                    return;
                                }
                                SD_CPrice_SD_CPriceModule_GridControl.InitEdit(data.SDP_Code);
                            }
                            function SD_CPriceTool_Delete() {
                                var grid = $('#SD_CPricegrid');
                                var curid = grid.getGridParam('selrow'); //获取选择行的id
                                var data = grid.getRowData(curid); //获取行号为curid的数据            
                                if (data.SDP_Code == undefined) {
                                    ShowMsg('请选中编辑行');
                                    return;
                                }
                                ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                                    if (yes) {
                                        SD_CPrice_SD_CPriceModule_GridControl.Delete(data.SDP_Code);
                                    }
                                });
                            }
                            function SD_CPriceTool_Search() {

                                SD_CPrice_SD_CPriceModule_GridControl.Search();
                            }

                            //cl:查看
                            function SD_CPriceTool_toolbar_view() {
                                var grid = $('#SD_CPricegrid');
                                var curid = grid.getGridParam('selrow'); //获取选择行的id
                                var data = grid.getRowData(curid); //获取行号为curid的数据            
                                if (data.SDP_Code == undefined) {
                                    ShowMsg('请选中编辑行');
                                    return;
                                }
                                SD_CPrice_SD_CPriceModule_GridControl.InitEdit(data.SDP_Code);
                                GLOBAL.PageReadOnly("", "SD_CPrice_Form", "");
                            }
      
          
                        </script>

                        <div id='ListContainer' style='width: 100%'>
                            <div id='SD_CPricesearch'>
                            </div>
                            <table id='SD_CPricegrid' class='scroll' cellpadding='0' cellspacing='0' style='width: 100%'>
                            </table>
                            <div id='SD_CPricepager' class='scroll' style='text-align: center;'>
                            </div>
                        </div>

                        <script type='text/javascript'>
                            var SD_CPrice_SD_CPriceModule_GridControl = {
                                setupGrid: function(grid, pager, search, dataurl) {
                                    grid.jqGrid({
                                        url: dataurl,
                                        mtype: 'post',
                                        rowNum: 10,
                                        rowList: [10, 20, 50],
                                        pager: pager,
                                        sortorder: 'asc',
                                        viewrecords: true,
                                        multiselect: false, //多选时出现checkbox
                                        width: '800',

                                        autowidth: true,
                                        rownumbers: true,
                                        gridview: true,
                                        hiddengrid: false,
                                        caption: '价格信息列表',
                                        footerrow: false,
                                        editurl: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice',
                                        edit: { Caption: '编辑' },
                                        onSelectRow: function(id) {

                                        },
                                        colNames: ['合同关联价格序号', '价格编码', '合同编码', '客户编码', '产品类别', '产品名称', '产品编码', '执行开始时间', '执行结束时间', '价格', '备注', '单位', '强度等级', '起始方量', '结束方量', '计算方式'],
                                        colModel: [{ name: 'SDP_ID', index: 'SDP_ID', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_Code', index: 'SDP_Code', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_SCode', index: 'SDP_SCode', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_CCode', index: 'SDP_CCode', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_Category', index: 'SDP_Category', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_ProName', index: 'SDP_ProName', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_ProCode', index: 'SDP_ProCode', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_Start', index: 'SDP_Start', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_End', index: 'SDP_End', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_Price', index: 'SDP_Price', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_Remark', index: 'SDP_Remark', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_Unit', index: 'SDP_Unit', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_Level', index: 'SDP_Level', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
{ name: 'SDP_UDEF1', index: 'SDP_UDEF1', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: {} },
{ name: 'SDP_UDEF2', index: 'SDP_UDEF2', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: {} },
{ name: 'SDP_UDEF3', index: 'SDP_UDEF3', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: {} }
],
                                        gridComplete: function() {

                                        },
                                        loadComplete: function() {
                                            //var parent=$('#ListContainer');
                                            //                            var parentWidth=800;
                                            //                            if(parent==undefined || parent.width==0){ parentWidth=800; }
                                            //grid.setGridWidth(parent.width());//宽度自适当

                                        },
                                        userDataOnFooter: true
                                    })
                                },
                                Init: function(dataurl, targetPreFix) {
                                    var gridobj = targetPreFix + 'grid';
                                    var pagerobj = targetPreFix + 'pager';
                                    var searchobj = targetPreFix + 'search';
                                    SD_CPrice_SD_CPriceModule_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
                                    $('#' + gridobj).navGrid('#' + pagerobj, { refresh: true, edit: false, add: false, del: false, search: false });
                                    //                    var parent=$('#ListContainer');
                                    //                    var parentWidth=800;
                                    //                    if(parent==undefined || parent.width==0){ parentWidth=800; }
                                    //                    $('#'+gridobj).setGridWidth(parent.width());//宽度自适当
                                },
                                InitEdit: function(SDP_Code) {
                                    var _oper = $('#SD_CPrice_Formoper').val('edit');
                                    $.ajax(
                    {
                        type: 'post',
                        url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice',
                        data: { id: SDP_Code, oper: 'view' },
                        dataType: 'json',
                        success: function(datas) {
                            data = datas[0];
                            $('#SD_CPrice_Form')[0].reset();
                            $('#SD_CPrice_Form').find('input,select,textarea').each(function(key, element) {
                                for (var p in data) {
                                    if (p == element.id) {
                                        if (element.type == 'checkbox') {//页面上的复选框
                                            element.checked = data[p];
                                        } else if (element.type == 'text') {
                                            element.value = data[p];

                                        } else if (element.type == 'select-one') { //页面上的下拉菜单
                                            var e = $(element);
                                            e.val(data[p]);
                                        } else {
                                            $(element).val(data[p]);
                                        }
                                    }
                                }
                                if (typeof (SD_CPrice_FormLoadAfter) != 'undefined') {
                                    SD_CPrice_FormLoadAfter('edit');
                                }
                            });

                        }
                    });
                                    if (typeof (SD_CPrice_FormLoadAllEx) != 'undefined') {
                                        SD_CPrice_FormLoadAllEx();
                                    }
                                    $('#SD_CPrice_Oper').dialog('open');
                                },
                                //扩展编辑层,判断是否存在ListPage ToolBar扩展
                                InitEditExtends: function(SDP_Code, btn) {
                                    var _oper = $('#' + btn + 'Formoper').val('edit');
                                    $.ajax(
                    {
                        type: 'post',
                        url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice',
                        data: { id: SDP_Code, oper: 'view' },
                        dataType: 'json',
                        success: function(datas) {
                            data = datas[0];
                            $('#' + btn + 'Form')[0].reset();
                            $('#' + btn + 'Form').find('input,select,textarea').each(function(key, element) {
                                if (element.type == 'checkbox' || element.type == 'text' || element.type == 'select-one') {
                                    for (var p in data) {
                                        if (p == element.id) {
                                            if (element.type == 'checkbox') {//页面上的复选框
                                                element.checked = data[p];
                                            } else if (element.type == 'text') {
                                                element.value = data[p];

                                            } else if (element.type == 'select-one') { //页面上的下拉菜单
                                                var e = $(element);
                                                e.val(data[p]);
                                            } else {
                                                $(element).val(data[p]);
                                            }
                                        }
                                    }
                                }
                            });

                        }
                    });
                                    $('#' + btn + 'Layer').dialog('open');
                                },

                                SaveData: function() {
                                    //$('#SD_CPrice_Form').submit();
                                    //表单提交前验证
                                    //debugger;
                                    if (!$('#SD_CPrice_Form').validate().form()) {
                                        return false;
                                    }
                                    var FormData = $('#SD_CPrice_Form').serialize();
                                    FormData = decodeURIComponent(FormData, true);
                                    var _oper = $('#SD_CPrice_Formoper').val();
                                    $.ajax({
                                        type: 'post',
                                        url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice',
                                        data: { 'form': FormData, 'oper': _oper },
                                        success: SD_CPrice_SD_CPriceModule_GridControl.AfterSave
                                    });
                                },
                                SaveDataApply: function() {
                                    //$('#SD_CPrice_Form').submit();
                                    //表单提交前验证
                                    //debugger;
                                    if (!$('#SD_CPrice_Form').validate().form()) {
                                        return false;
                                    }
                                    var FormData = $('#SD_CPrice_Form').serialize();
                                    FormData = decodeURIComponent(FormData, true);
                                    var _oper = $('#SD_CPrice_Formoper').val();
                                    $.ajax({
                                        type: 'post',
                                        url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice',
                                        data: { form: FormData, oper: _oper },
                                        success: SD_CPrice_SD_CPriceModule_GridControl.AfterSaveApply
                                    });
                                },
                                SaveDataExtends: function(layer, form) {
                                    //$('#SD_CPrice_Form').submit();
                                    //表单提交前验证
                                    //debugger;
                                    if (!$('#' + form + '').validate().form()) {
                                        return false;
                                    }
                                    var FormData = $('#' + form + '').serialize();
                                    FormData = decodeURIComponent(FormData, true);
                                    var _oper = $('#' + form + 'oper').val();
                                    $.ajax({
                                        type: 'post',
                                        url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice',
                                        data: { form: FormData, oper: _oper, btn: form },
                                        success: function(data) { SD_CPrice_SD_CPriceModule_GridControl.AfterSaveExtends(layer, data); }
                                    });
                                },
                                AfterSave: function(data) {
                                    if (data == 'success') {
                                        $('#SD_CPrice_Oper').dialog('close');
                                        $('#SD_CPricegrid').trigger('reloadGrid');
                                        if (typeof (SD_CPrice_OperAfterSave) != 'undefined') { SD_CPrice_OperAfterSave(); }
                                    }
                                    else {
                                        ShowMsg('提交失败!');
                                    }
                                },
                                AfterSaveApply: function(data) {
                                    if (data == 'success') {
                                        $('#SD_CPricegrid').trigger('reloadGrid');
                                    }
                                    else {
                                        ShowMsg('提交失败!');
                                    }
                                },
                                AfterSaveExtends: function(layer, data) {
                                    if (data == 'success') {
                                        $('#' + layer + '').dialog('close');
                                        $('#SD_CPricegrid').trigger('reloadGrid');
                                    }
                                    else {
                                        ShowMsg('提交失败!');
                                    }
                                },

                                CancelEdit: function() {
                                    $('#SD_CPrice_Form')[0].reset();
                                    $('#SD_CPrice_Oper').dialog('close');
                                },
                                CancelEditExtends: function(layer, form) {
                                    $('#' + form + '')[0].reset();
                                    $('#' + layer + '').dialog('close');
                                },
                                Search: function() {
                                    $('#SD_CPricegrid').jqGrid('searchGrid', { multipleSearch: true });
                                },
                                Delete: function(SDP_Code) {
                                    //var _oper=$('#SD_CPrice_Formoper').val('del');
                                    $.ajax({
                                        type: 'post',
                                        url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice',
                                        data: { id: SDP_Code, oper: 'del' },
                                        success: function(result) {
                                            if (result == 'success') {
                                                $('#SD_CPricegrid').trigger('reloadGrid');
                                            } else {
                                                ShowMsg('删除失败');
                                            }
                                        }
                                    });
                                }
                            }

                            var SysComm_SD_CPrice = {
                                SelectRowData: null,
                                Init: function() { SD_CPrice_SD_CPriceModule_GridControl.Init(); },
                                SelectRow: function(callback) {
                                    var grid = $('#SD_CPricegrid');
                                    var curid = grid.getGridParam('selrow'); //获取选择行的id
                                    var data = grid.getRowData(curid); //获取行号为curid的数据
                                    SysComm_SD_CPrice.SelectRowData = data;
                                    callback(data);
                                },
                                Add: function() { SD_CPrice_SD_CPriceModule_GridControl.Add(); },
                                InitEdit: function(code) { SD_CPrice_SD_CPriceModule_GridControl.InitEdit(code); },
                                SaveData: function() { SD_CPrice_SD_CPriceModule_GridControl.SaveData(); },
                                AfterSave: function() { SD_CPrice_SD_CPriceModule_GridControl.AfterSave(); },
                                CancelEdit: function() { SD_CPrice_SD_CPriceModule_GridControl.CancelEdit(); },
                                Delete: function(code) { SD_CPrice_SD_CPriceModule_GridControl.Delete(code); },
                                Search: function() { SD_CPrice_SD_CPriceModule_GridControl.Search(); },
                                Init: function(url) {
                                    var strUrl = url == '' ? '/Sys_Config_ListPage/InitGrid/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice&itype=&type=&record=' : url;
                                    SD_CPrice_SD_CPriceModule_GridControl.Init(strUrl, 'SD_CPrice');
                                }
                            }
                        </script>

                        <script type='text/javascript'>
                            $(document).ready(function() {
                                SD_CPrice_SD_CPriceModule_GridControl.Init('/Sys_Config_ListPage/InitGrid/?ModuleCode=SD_CPriceModule&NameSpace=SD_CPrice&itype=&type=&record=', 'SD_CPrice');
                            });
                        </script>

                    </td>
                </tr>
            </table>
        </div>
        <div id="tabs-4">
            <%=Html.AttachComponent("WHR_PartyARecordModule", "WHR_PartyARecord", "SD_Contract", "$('#SDC_Code')")%>
        </div>
        <div id="tabs-5">
            <%=Html.AttachComponent("Bse_ContactsModule", "Bse_Contacts", "SD_Contract", "$('#SDC_Code')")%>
        </div>
        <div id="tabs-6">
            <%=Html.AttachComponent("Bse_AddressModule", "Bse_Address", "SD_Contract", "$('#SDC_Code')")%>
        </div>
    </div>
    <div style="float: left">
        <input type='button' name='button' value='草稿' onclick='Contract_Operation.SaveDraft()' />
        <input type='button' name='cancle' value='返回' onclick='Contract_Operation.CancelEdit()' />
    </div>
    <%--参考--%>
    <%=Html.ReferControl("WH_SpeMaterialModule", "WH_MaterialSpe", false)%>
    <%=Html.ReferControl("WH_SpcMaterialModule", "WH_MaterialSpc", false)%>
    <%=Html.ReferControl("Bse_DictModule", "Bse_Dict",false)%>
    <%=Html.ReferControl("WH_MaterialAModule","WH_Material",false)%>
    <%=Html.ReferControl("Company", "HR_Department",false)%>
    <%=Html.ReferControl("Ref_Cusomter", "WH_Supplier",false)%>
    <%=Html.AutoBindValidate("SD_ContractModule", "ContractInfoForm")%>
    <div class='list_openlayer' id='SD_CPrice_Oper' style='display: none'>
        <form class='FormClass' action='' id='SD_CPrice_Form' method='post' name='SD_CPrice_Form'>
        <%=Html.AutoBindForm("SD_CPriceModule", "SD_CPrice", false, false, false)%>
        <div class='FormToolBar'>
            <input type='hidden' name='SD_CPrice_Formoper' id='SD_CPrice_Formoper' value=''>
            <input id='SD_CPrice_FormOK' type='button' name='button' value='确 定' onclick='SD_CPrice_SD_CPriceModule_GridControl.SaveData()' />
            <input id='SD_CPrice_FormCancle' type='button' name='cancle' value='取 消' onclick='SD_CPrice_SD_CPriceModule_GridControl.CancelEdit()' />
            <input style='display: none' id='SD_CPrice_FormApply' type='button' name='button'
                value='应 用' onclick='SD_CPrice_SD_CPriceModule_GridControl.SaveDataApply()' />
        </div>
        </form>
    </div>

    <script type="text/javascript">
        var tab = '';
        $(function() {
            Contract_Operation.InitData();


            $('#SD_CPrice_Oper').dialog({ autoOpen: false, width: 800, title: '价格管理' });

            //绑定客户选择
            //$("input[name=SDC_CCode]").val(a);
            $("#SDC_CCode").live("click", function() {
                Ref_CusomterWH_SupplierOpenReferWithFilter("", function(data) {
                    $("#SDC_CCode").val(data.WHS_CustCode);
                    $("#SDC_CName").val(data.WHS_CustName);
                    $("#SDC_CContact").val(data.WHS_Telphone);
                    $("#SDC_COwner").val(data.WHS_LegalPerson);
                    $("#SDC_Dept").val(data.WHS_CustName); //合同单位
                });
            });
            Comm_Session.GetLoginUser(function(data) //签约人
            { $('#SDC_OwnerCode').val(data.UserId); $('#SDC_Owner').val(data.UserName); });
            Comm_Session.GetLoginUser(function(data) //执行人
            { $('#SDC_EOwnerCode').val(data.UserId); $('#SDC_EOwner').val(data.UserName); }); //合同执行人
            Comm_Session.GetCurrentDate(function(data) { $('#SDC_Date').val(data); }); //签约日期
            Comm_Session.GetCurrentDate(function(data) { $('#SDC_Start').val(data); }); //合同生效时间

            $('#SDC_Place').val("中国重庆涪陵");
            //绑定人员选择
            Common_EmpTree_Dept.Init("SDC_Owner", function(code, name) { $("#SDC_Owner").val(name); $("#SC_OwnerCode").val(code) });
            Common_EmpTree_Dept.Init("SDC_EOwner", function(code, name) { $("#SDC_EOwner").val(name); $("#SDC_EOwnerCode").val(code) });

            //获取合同相关的工程信息
            var ContractCode = $("#ContractInfoForm").find("#SDC_Code").val();
            $("#Allgrid").setGridParam({ url: '/Sales/ProjectWithContract/' + ContractCode }).trigger("reloadGrid");

            //价格初始化,并筛选数据--点击不同的价格细目
            $(".Lproduct").bind("click", function() {
                var self = $(this);
                var pcode = self.attr("id");
                var pname = self.attr("name");
                var pdictcode = self.attr("title");
                $("#PPCode").val(pcode);
                $("#PPName").val(pname);
                $("#PDict_Code").val(pdictcode);
                $(".Lproduct").each(function() {
                    var obj = $(this);
                    obj.removeClass("PriceSelected");
                });
                self.addClass("PriceSelected");

                //筛选数据
                var priceGrid = $("#SD_CPricegrid");
                priceGrid.jqGrid('setPostData', { Category: $("#PDict_Code").val() });
                priceGrid.setGridParam({ url: '/Sales/PriceFilter/' + $("#SDC_Code").val() }).trigger("reloadGrid");

                var PPCODE = $("#PPCode");
                var PROCODE = $("#SDP_ProCode");
                var PLEVEL = $("#SDP_Level");
//                $("#SDP_Category").val(PPCODE);
                //泵送方式
                if (PPCODE.val() != "DELI") {
                    $("#SD_CPricegrid").hideCol("SDP_UDEF1").trigger("reloadGrid");
                    $("#SD_CPricegrid").hideCol("SDP_UDEF2").trigger("reloadGrid");
                    $("#SDP_UDEF3").parent().parent().hide();
                } else {
                    $("#SD_CPricegrid").showCol("SDP_UDEF1").trigger("reloadGrid");
                    $("#SD_CPricegrid").showCol("SDP_UDEF2").trigger("reloadGrid");
                    $("#SD_CPricegrid").hideCol("SDP_Level").trigger("reloadGrid");
                    $("#SDP_UDEF3").parent().parent().show();
                }

                if (PPCODE.val() == "CONCRETESPEC" || PPCODE.val() == "MORTAR") {
                    $("#SD_CPricegrid").showCol("SDP_Level").trigger("reloadGrid");
                } else {
                    $("#SD_CPricegrid").hideCol("SDP_Level").trigger("reloadGrid");
                }

            });


            //选择价格Tab后，重置URL TOTO:Tab选中事件

        });


        function OnPageLoad() {
            //获取合同相关的工程信息
            var ContractCode = $("#ContractInfoForm").find("#SDC_Code").val();
            $("#Allgrid").setGridParam({ url: '/Sales/ProjectWithContract/' + ContractCode }).trigger("reloadGrid");
        }

        window.onload = function() {
            var priceGrid = $("#SD_CPricegrid");
            priceGrid.setGridParam({ url: '/Sales/PriceFilter/' + $("#SDC_Code").val() }).trigger("reloadGrid");
        }


        ////工程查看功能
        function All_View() {
            var grid = $('#Allgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDI_Code == undefined) {
                ShowMsg('请选中需要查看的数据行');
                return;
            }
            var url = "/Sales/QProjectView/" + data.SDI_Code;
            Win.Open(url, "", "");
        }

        function All_Add() {
            //合同编码
            var SDC_Code = $("#SDC_Code").val();
            //ysw 0204
            var SDC_CCode = $("#SDC_CCode").val();
            var url = "/Sales/QProjectAdd/" + SDC_Code + "-" + SDC_CCode;
            Win.Open(url, "", "");
        }

        //价格动态绑定参考
        function PriceCodeBind() {
            var PPCODE = $("#PPCode");
            var PROCODE = $("#SDP_ProCode");
            var PLEVEL = $("#SDP_Level");

            //起始方量
            var StartF = $("#SDP_UDEF1");
            var EndF = $("#SDP_UDEF2");

            $("#SDP_Category").val($("#PDict_Code").val());
            PLEVEL.parent().parent().show();
            PROCODE.die("click");


            if (PPCODE.val() != "CONCRETESPEC" && PPCODE.val() != "MORTAR") {
                PLEVEL.parent().parent().hide();
            }

            if (PPCODE.val() != "DELI") {
                StartF.parent().parent().hide();
                EndF.parent().parent().hide();
            } else {
                StartF.parent().parent().show();
                EndF.parent().parent().show();
            }
            //默认起始时间
            $("#SDP_Start").val($("#SDC_Start").val());
            $("#SDP_End").val($("#SDC_End").val());

            if (PPCODE.val() != "") {

                if (PPCODE.val() == "HRCost" || PPCODE.val() == "Tank" || PPCODE.val() == "OTHCost" || PPCODE.val() == "MORTAR") {

                    $("#SDP_ProName").val($("#PPName").val());
                    $("#SDP_ProCode").val($("#PPCode").val());
                    $("#SDP_ProCode").parent().parent().hide();
                }
                else {
                    $("#SDP_ProCode").parent().parent().show();
                    PROCODE.live("click", function() {
                        if (PPCODE.val() == "DELI" || PPCODE.val() == "CONCRETECLASS ") {


                            Bse_DictModuleBse_DictOpenReferWithFilter(" dict_key!=dict_code and dict_key='" + PPCODE.val() + "'", function(data) {
                                $("#SDP_ProName").val(data.Dict_Name);
                                $("#SDP_ProCode").val(data.Dict_Code);
                                $("#SDP_Price").val(data.Dict_UDef1);
                                $("#SDP_Unit").val(data.MD_Unit);
                            });
                        }
                        else if (PPCODE.val() == "CONCRETESPEC") {
                            WH_SpcMaterialModuleWH_MaterialSpcOpenReferWithFilter("", function(data) {
                                $("#SDP_ProName").val(data.MD_Name);
                                $("#SDP_ProCode").val(data.MD_MCode);
                                $("#SDP_Price").val(data.MD_PriceList);
                                $("#SDP_Unit").val(data.MD_Unit);
                            });
                        }
                        else if (PPCODE.val() == "SPEC") {


                            WH_SpeMaterialModuleWH_MaterialSpeOpenReferWithFilter("", function(data) {
                                $("#SDP_ProName").val(data.MD_Name);
                                $("#SDP_ProCode").val(data.MD_MCode);
                                $("#SDP_Price").val(data.MD_PriceList);
                                $("#SDP_Unit").val(data.MD_Unit);
                            });
                        }
                    });
                } //产品编码弹出框
            } //
            else {
                PROCODE.unbind();
                //$("#SDP_ProCode").hide();
                $("#SDP_ProName").val($("#PPName").val());
                $("#SDP_ProCode").val($("#PPCode").val());
            }


        } 
        
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script type="text/javascript" src="/Scripts/Shared/WinOpen.js"></script>

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Session.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
