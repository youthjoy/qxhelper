<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	销售付款
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 
    <div id="tabs">
        <ul>
            <li><a href="#tabs_tabs-1">应收款</a></li>
            <li><a href="#tabs_tabs-2">收款历史</a></li>
        </ul>
        <div id="tabs_tabs-1">
            <%=Html.Common_ToolBarForListPage("Payable", " addN:'收款',addFunJs:'Pay()',viewN:'查看',viewFunjs:'View()' ")%>
            <%=Html.JqGrid("SD_ReceivableModule", "Payable", "", "")%>
        </div>
        <div id="tabs_tabs-2">
            <%=Html.JqGrid("SD_ReceiveModule", "PayHistroy", "", "")%>
            <%--<%=Html.JqGridListPage("WH_PayModule", "WH_Pay", "", "", "")%>--%>
        </div>
    </div>
    
    <div id="PayFormOper" style="display:none">
    <form id="PayForm" name="PayForm" action="">              
            <%=Html.AutoBindForm("SD_ReceiveModule", "SD_Receive", false, false, false)%>
            <div class="FormToolBar">
                <input class="hide" type="button" onclick="" value="确 定" name="button" id="Pay_FormOK" />
                <input type="button" onclick="" value="取 消" name="cancle" id="Pay_FormCancle" />
            </div>
    </form>
    </div>
        
    <%=Html.AutoBindValidate("SD_ReceiveModule", "PayForm")%>
        
    <%--参考--%>
    <%=Html.ReferControl("SD_ReceivableModule", "SD_Receivable", false)%>
    <%=Html.ReferControl("PU_MainModule","PU_Main",false)%>
    <%=Html.ReferControl("WH_SupplierModule", "WH_Supplier", false)%>
    <%=Html.ReferControl("SD_InvoiceModule", "SD_Invoice", false)%>
     
    <script type="text/javascript">
        var Form = $("#PayForm");
        var Layer = $("#PayFormOper");
        var type = '<%=ViewData["Type"].ToString()%>';
        var RefTypeObj = Form.find("#SDPR_RefType");
        var RefCodeObj = Form.find("#SDPR_RefCode");
        var RefSupperObj = Form.find("#SDPR_CCode");
        var PayableGrid = $("#Payablegrid");
        var PayHistroyGrid = $("#PayHistroygrid");

        $(function() {
            $('#tabs').tabs();
            $("#PayFormOper").dialog({ autoOpen: false, width: 800, title: '付款信息' });
            Ref_Payable();
            Ref_Supper();
            $("#Pay_FormCancle").click(function() { Layer.dialog('close'); });
            RefTypeObj.live("change", function() {
                if (RefTypeObj.val() == "PO") {
                    Ref_Order();
                    //$("#WHPP_Type").val("PAPAYABLE");
                } else if (RefTypeObj.val() == "PAYABLE") {
                    Ref_Payable();
                    //$("#WHPP_Type").val("PAPO");
                } else {
                    Ref_Invoice();
                }
            });
            //提交
            $("#Pay_FormOK").bind("click", PayableSave);
            //初始化参考类型
            $.ajax({
                url: '/Sales/RefType/<%=ViewData["Type"].ToString()%>',
                type: 'post',
                dataType: 'json',
                success: function(data) {
                    for (var i = 0; i < data.length; i++) {
                        var option = $("<option>").text(data[i].RefDepend_ObjectName).val(data[i].RefDepend_Object);
                        RefTypeObj.append(option);
                    }
                }
            });
        });        

        //订单参考
        function Ref_Order() {
            RefCodeObj.unbind();
            RefCodeObj.bind("click", function() {
                PU_MainModulePU_MainOpenReferWithFilter(" ", function(data) {
                    $("#SDPR_Sum").val(data.PUM_Payable);
                    $("#WHPP_SCode").val(data.PUM_SCode);
                    $("#WHPP_SName").val(data.PUM_SName);
                });
            });
        }
        //应付单参考
        function Ref_Payable() {
            RefCodeObj.unbind();
            RefCodeObj.bind("click", function() {
                var self = $(this);
                SD_ReceivableModuleSD_ReceivableOpenReferWithFilter(" SDR_IsDone='0' ", function(data) {
                    $("#SDPR_Sum").val(data.SDR_Current);
                    $("#SDPR_CCode").val(data.SDR_CCode);
                    $("#SDPR_CName").val(data.SDPR_CName);
                    self.val(data.SDR_Code);
                });
            });
        }
        
        //发票参考
        function Ref_Invoice() {
            RefCodeObj.unbind();
            RefCodeObj.bind("click", function() {
                var self = $(this);
                SD_InvoiceModuleSD_InvoiceOpenReferWithFilter(" isnull(SDCI_Status,'UNPAY')'='UNPAY'", function(data) {
                    $("#SDPR_Sum").val(data.SDCI_Num);
                    $("#SDPR_CCode").val(data.SDCI_CCode);
                    $("#SDPR_CName").val(data.SDCI_CName);
                    self.val(data.SDCI_Code);
                });
            });
        }

        //供应商参考
        function Ref_Supper() {
            RefSupperObj.unbind();
            RefSupperObj.bind("click", function() {
                var self = $(this);
                WH_SupplierModuleWH_SupplierOpenReferWithFilter(" WHS_iType='Cust' ", function(data) {
                    $("#SDPR_CCode").val(data.WHS_CustCode);
                    $("#SDPR_CName").val(data.WHS_CustName);
                    self.val(data.WHS_Code);
                });
            });
        }       
        

        //付款
        function Payable_Pay() {
            Form[0].reset();
            GLOBAL.PageEdit();
            Layer.dialog('open');
            $("#Pay_FormOK").show();
            var grid = PayableGrid;
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDR_Code != undefined) {

                Form.find("#SDPR_RefCode").val(data.SDR_Code);
                Form.find("#SDPR_CCode").val(data.SDR_CCode);
                Form.find("#SDPR_CName").val(data.SDR_CName);
                Form.find("#SDPR_Sum").val(data.SDR_Current);                
            }
        }
        
        //提交        
        function PayableSave() {
            if (!Form.validate().form()) {
                return false;
            }
            $.ajax({
                url: '/Sales/PayableSave',
                type: 'post',
                data: Form.serialize(),
                success: function(result) {
                    if (result == "success") {
                        PayableGrid.trigger("reloadGrid");
                        PayHistroyGrid.trigger("reloadGrid");
                        ShowMsg("付款成功");
                        Layer.dialog('close');
                    }
                }
            });
        }

        //搜索
        function PayHistroy_PayHistroy_SD_ReceiveModuleToolBarSearch() {
            PayHistroyGrid.jqGrid('searchGrid', { multipleSearch: true });
        }
        
        //历史数据查看
        function PayHistroy_PayHistroy_SD_ReceiveModuleToolBarView() {
            $("#Pay_FormOK").hide();
            var grid = PayHistroyGrid;
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDPR_Code == undefined) {
                ShowMsg("请选中需要查看的行");
                return false;
            }

            InitView(data.SDPR_Code);
        }
        
        //数据查看
        function Payable_View() {
           
            SysComm_Payable.SelectRow(function(data) {
                Form.find("#SDPR_RefCode").val(data.SDR_Code);
                Form.find("#SDPR_CCode").val(data.SDR_CCode);
                Form.find("#SDPR_CName").val(data.SDR_CName);
                Form.find("#SDPR_Sum").val(data.SDR_Current);
            });

            GLOBAL.PageReadOnly('');
            
            Layer.dialog('open');
         
        }

        //查看数据
        function InitView(WHPP_Code,callback) {

            $.ajax({ type: 'post',
                url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=SD_ReceiveModule&NameSpace=PayHistroy',
                data: { id: WHPP_Code, oper: 'view' },
                dataType: 'json',
                success: function(datas) {
                    data = datas[0];
                    Form[0].reset();
                    Form.find('input,select,textarea').each(function(key, element) {
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
                    });
                    callback;
                }
            });
            GLOBAL.PageReadOnly('');
            Layer.dialog('open');
        }
        
        

        
    </script>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
 <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/jquery-1.0.formtojson.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
