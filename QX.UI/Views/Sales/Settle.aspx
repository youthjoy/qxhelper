<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.SD_Banlance>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    销售结算
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">往来查询</a></li>
            <li><a href="#tabs-2">确认结算单</a></li>
            <li><a href="#tabs-3">单月结算查询</a></li>
            <li><a href="#tabs-4">生成结算单</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.Common_ToolBarForListPage("History", "searchN:'查看',searchFunJs:'View()',editN:'确定',editFunJs:'Search()'")%>
            <%=Html.JqGrid("SD_BanlanceModule", "History", ViewData["itype"].ToString(), "")%>
        </div>
        <div id="tabs-2">
            <%=Html.Common_ToolBarForListPage("CurMonth", "addN:'确认结算',addFunJs:'Confirm()'")%>
            <%=Html.JqGrid("SD_BanlanceModule", "CurMonth", ViewData["itype"].ToString(), "cur")%>
        </div>
        <div id="tabs-3">
            <%=Html.Common_ToolBarForListPage("GeneralOne", "searchN:'确定',searchFunJs:'Search()' ")%>
            <%=Html.JqGrid("SD_BanlanceModule", "GeneralB", ViewData["itype"].ToString(), "all")%>
        </div>
        <div id="tabs-4">
             <input type="button" onclick="General_Run()" value="生成结算单" name="button" id="Button1" />
        </div>
    </div>
    <ul id='exToolBar' style='display: none'>
        <li style="float: left"><span>客 户:</span>
            <input type="hidden" name="vendor" id="vendorCode" />
            <input type="text" readonly="true" class="form_textbox  TextBoxReadOnly  popup" name="vendor"
                id="vendor2" />
        </li>
        <li style="float: left"><span>开始时间:</span><input class="date_icon" type="text" name="startdate"
            id="startdate" value="<%=ViewData["startdate"].ToString()%>" />
        </li>
        <li style="float: left"><span>结束时间:</span><input class="date_icon" type="text" name="enddate"
            id="enddate" value="<%=ViewData["enddate"].ToString()%>" />
        </li>
    </ul>
    <ul id='exToolBar2' style='display: none'>
        <li style="float: left"><span>客 户:</span><input type="text" name="vendor" id="vendor" />
        </li>
        <li style="float: left"><span>开始时间:</span><input class="date_icon" type="text" name="start_date"
            id="start_date" value="" />
        </li>
        <li style="float: left"><span>结束时间:</span><input class="date_icon" type="text" name="end_date"
            id="end_date" value="" />
        </li>
    </ul>
    <div id="ConfirmOper" style="display: none">
        <form id="ConfirmForm" name="ConfirmForm" action="">
        <%=Html.AutoBindForm("SD_BanlanceModule", "SD_Banlance", false, false, false)%>
        <div id="tabs2">
            <ul>
                <li><a href="#tabs2-1">结算明细</a></li>
                <li><a href="#tabs2-2">备注</a></li>
            </ul>
            <div id="tabs2-1">
                <%=Html.JqGrid("SD_BItemModule", "BItem", ViewData["itype"].ToString(), "cur")%>
            </div>
            <div id="tabs2-2">
                <%Html.RenderPartial("BakControl", ""); %>
            </div>
        </div>
        </form>
        <div class="FormToolBar">
            <input type="button" onclick="" value="确 定" name="button" id="BItem_FormOK" />
            <input type="button" onclick="" value="取 消" name="cancle" id="BItem_FormCancle" />
        </div>
        <%=Html.AutoBindValidate("SD_BanlanceModule", "ConfirmForm")%>
    </div>
    <%=Html.ReferControl("Ref_Cusomter", "WH_Supplier",false)%>

    <script type="text/javascript">

        var genralGrid = $("#Generalgrid");
        var genralBGrid = $("#GeneralBgrid");
        var CurMonthGrid = $("#CurMonthgrid");
        var HistoryGrid = $("#Historygrid");
        var BItemGrid = $("#BItemgrid");
        var Form = $("#ConfirmForm");

        $(document).ready(function() {
            $("#tabs").tabs();
            $("#tabs2").tabs();
            $("#ConfirmOper").dialog({ autoOpen: false, width: 800, height: 440, title: '结算信息' });

            //客户选择初始化
            $("#vendor2").live("click", function() {
                var obj = $(this);
                Ref_CusomterWH_SupplierOpenReferWithFilter("", function(data) {
                    obj.val(data.WHS_CustName);
                    $("#vendorCode").val(data.WHS_CustCode);
                });
            });

            //扩展ToolBar
            $("#GeneralOne_toolbar").find("ul").prepend($("#exToolBar").html());
            $("#History_toolbar").find("ul").prepend($("#exToolBar2").html());
            $("#GeneralOne_toolbar").find("#startdate").click(function() { WdatePicker(); })
            $("#GeneralOne_toolbar").find("#enddate").click(function() { WdatePicker(); })
            $("#History_toolbar").find("#start_date").click(function() { WdatePicker(); })
            $("#History_toolbar").find("#end_date").click(function() { WdatePicker(); })

            $("#BItem_FormCancle").click(function() {
                $("#ConfirmOper").dialog('close');
            });
            $("#BItem_FormOK").click(function() {
                BanlanceSave();
            });

            $("#SDB_CurRecevie").change(function() {
                if ($(this).val() != "") {
                    var _WHB_LastMonth = $("#SDB_Last").val(); //上月结余
                    var _WHB_NextMonth = $("#SDB_Current").val(); //本月供货
                    var _WHB_CurPay = $("#SDB_CurRecevie").val(); //本月应收
                    var tmpSum = parseFloat(_WHB_LastMonth) + parseFloat(_WHB_NextMonth);
                    var tmp_CurPay = parseFloat(_WHB_CurPay);
                    var JieYU = tmpSum - tmp_CurPay;
                    $("#SDB_Left").val(JieYU.toFixed(2));
                }
            });

        })

        //单客户结算
        function GeneralOne_Search() {

            var supCode = $("#GeneralOne_toolbar").find("#vendorCode").val();
            if (supCode == null || supCode == "") {
                ShowMsg("请选择您要查询的客户!");
                return;
            }
            //附加POST值
            genralBGrid.jqGrid('setPostData', {
                vendor: supCode,
                bantype: "TEMP",
                startdate: $("#GeneralOne_toolbar").find("#startdate").val(),
                enddate: $("#GeneralOne_toolbar").find("#enddate").val()
            });
            genralBGrid.setGridParam({ url: '/Sales/General_Run/' }).trigger("reloadGrid");
        }

        function General_Run() {

            var otype = "all";
            if (otype == "all") {
                var conf = confirm("你确定要生成所有的客户结算单吗?");
                if (conf) {

                    $.ajax({
                        url: '/Sales/General_Run',
                        type: 'post',
                        data: { bantype: otype, vendor: "", startdate: "", enddate: "", page: 1, rows: 1, search: "", sord: "" },
                        success: function(result) {
                            ShowMsg("完成结算单生成!");
                            //genralGrid.trigger("reloadGrid");
                        }
                    });
                }
            } else {
                //附加POST值
                //                genralBGrid.jqGrid('setPostData', {
                //                    vendor: $("#General_toolbar").find("#vendor").val(),
                //                    bantype: $("#otype").val(),
                //                    startdate: $("#General_toolbar").find("#startdate").val(),
                //                    enddate: $("#General_toolbar").find("#enddate").val()
                //                });
                //                genralBGrid.setGridParam({ url: '/Sales/General_Run/' }).trigger("reloadGrid");
            }
        }


        function CurMonth_Confirm() {
            var grid = CurMonthGrid;
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDB_Code == undefined) {
                ShowMsg('请选中确认的数据行');
                return;
            }
            //ShowMsg(data.SDB_Code);
            $("#ConfirmOper").dialog('open');
            //初始化结算主表，结算明细，供应商信息
            InitOpenLayer(data);
            //获取明细数据列表
            InitDetailList(data);
            $("#BItem_FormOK").show();
        }



        //初始化弹出层数据
        function InitViewOpenLayer(data) {
            $.ajax({
                url: '/Sales/MModel/',
                type: 'post',
                dataType: 'json',
                data: { id: data.SDB_Code, scode: data.SDB_CCode, period: data.SDB_Period },
                success: function(data) {
                    $('#ConfirmForm')[0].reset();
                    $('#ConfirmForm').find('input,select,textarea').each(function(key, element) {
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
                    //备注
                    System_Bak.Init(Form.find("#SDB_Code"), "WH_Banlance");
                }
            });

        }


        //初始化弹出层数据
        function InitOpenLayer(data) {
            $.ajax({
                url: '/Sales/MModel/',
                type: 'post',
                dataType: 'json',
                data: { id: data.SDB_Code, scode: data.SDB_CCode, period: data.SDB_Period },
                success: function(data) {
                    $('#ConfirmForm')[0].reset();
                    $('#ConfirmForm').find('input,select,textarea').each(function(key, element) {
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
                    //备注
                    System_Bak.Init(Form.find("#SDB_Code"), "WH_Banlance");
                }
            });

        }

        //初始化
        function InitDetailList(data) {
            BItemGrid.setGridParam({ url: '/Sales/DetailList/?scode=' + data.SDB_CCode + '&period=' + data.SDB_Period }).trigger("reloadGrid");
        }

        function BanlanceSave() {
            if (!Form.validate().form()) {
                return false;
            }
            var FormData = Form.serialize();
            $.ajax({
                url: '/Sales/BanlanceSave',
                type: 'post',
                data: FormData,
                success: function(result) {
                    if (result == "success") {
                        CurMonthGrid.trigger("reloadGrid");
                        ShowMsg("操作成功");
                        $("#ConfirmOper").dialog('close');
                    } else {
                        ShowMsg("操作失败");
                    }
                }
            });
        }

        function History_View() {
            var grid = HistoryGrid;
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDB_Code == undefined) {
                ShowMsg('请选中需要查看的数据行');
                return;
            }
            InitOpenLayer(data);
            InitDetailList(data);
            $("#ConfirmOper").dialog('open');
            $("#BItem_FormOK").hide();
        }

        function History_Search() {
            //附加POST值
            HistoryGrid.jqGrid('setPostData', {
                vendor: $("#History_toolbar").find("#vendor").val(),
                startdate: $("#History_toolbar").find("#start_date").val(),
                enddate: $("#History_toolbar").find("#end_date").val()
            });
            HistoryGrid.setGridParam({ url: '/Sales/General_Run/' }).trigger("reloadGrid");
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
