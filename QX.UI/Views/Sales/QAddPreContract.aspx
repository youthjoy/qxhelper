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
    <%=Html.AutoBindValidate("SD_ContractPreModule", "ContractInfoForm")%>
    <div id="ContractInfo">
        <form id="ContractInfoForm" method='post' action="/Sales/ContractPreOperation">
                
        <input type='hidden' name='ContractFormoper' id='ContractFormoper' value='add' />
        <%=Html.AutoBindForm("SD_ContractPreModule","SD_Contract_TOP",false,false,false)%>
        <%=Html.ReferControl("Ref_Cusomter", "WH_Supplier",false)%>
        
        <div id="tabs">
            <ul>
            
                <li><a href="#tabs-1">基本信息</a></li>
                <li><a href="#tabs-2">工程信息</a></li>              
            </ul>
            <div id="tabs-1">
                <%=Html.AutoBindForm("SD_ContractPreModule","SD_Contract",false,false,false)%>
            </div>
        </form>
        <div id="tabs-2">
            <%=Html.Common_ToolBarForListPage("All", "addN:'查看工程',addFunJs:'View()',editN:'工程维护',editFunJs:'Add()'")%>
            <%=Html.JqGrid("SD_CProjectModule", "All", "PreCust", "All")%>
        </div>
       
    </div>
    <div style="float: left">
        <input type='button' name='button' value='草稿' onclick='PreContract_Operation.SaveDraft()' />
        <input type='button' name='cancle' value='返回' onclick='PreContract_Operation.CancelEdit()' />
    </div>
    <%--参考--%>
    <%=Html.ReferControl("WH_SpeMaterialModule", "WH_MaterialSpe", false)%>
    <%=Html.ReferControl("Bse_DictModule", "Bse_Dict",false)%>
    <%=Html.ReferControl("WH_MaterialAModule","WH_Material",false)%>

    <script type="text/javascript">
        var tab = '';
        $(function() {
            PreContract_Operation.InitData();
           
            //绑定客户选择
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
            var SDC_CCode=$("#SDC_CCode").val();
            var url = "/Sales/QProjectAdd/" + SDC_Code + "-" + SDC_CCode;
            Win.Open(url, "", "");
        }

        //价格动态绑定参考
        function PriceCodeBind() {
            var PPCODE = $("#PPCode");
            var PROCODE = $("#SDP_ProCode");
            $("#SDP_Category").val($("#PDict_Code").val());
            PROCODE.unbind();
            PROCODE.die("click");
            if (PPCODE.val() != "") {

                if (PPCODE.val() == "HRCost" || PPCODE.val() == "Tank" || PPCODE.val() == "OTHCost") {
                    $("#SDP_ProName").val($("#PPName").val());
                    $("#SDP_ProCode").val($("#PPCode").val());
                    $("#SDP_ProCode").parent().parent().hide();
                }
                else {
                    $("#SDP_ProCode").parent().parent().show();
                    PROCODE.live("click", function() {
                        if (PPCODE.val() == "DELI" || PPCODE.val() == "CONCRETESPEC" || PPCODE.val() == "CONCRETECLASS ") {


                            Bse_DictModuleBse_DictOpenReferWithFilter(" dict_key!=dict_code and dict_key='" + PPCODE.val() + "'", function(data) {
                                $("#SDP_ProName").val(data.Dict_Name);
                                $("#SDP_ProCode").val(data.Dict_Code);
                                $("#SDP_Price").val(data.Dict_UDef1);
                                $("#SDP_Unit").val(data.MD_Unit);
                            });
                        } else if (PPCODE.val() == "SPEC") {


                            WH_SpeMaterialModuleWH_MaterialSpeOpenReferWithFilter("", function(data) {
                                $("#SDP_ProName").val(data.MD_Name);
                                $("#SDP_ProCode").val(data.MD_MCode);
                                $("#SDP_Price").val(data.MD_PriceList);
                                $("#SDP_Unit").val(data.MD_Unit);
                            });
                        }
                    });
                }//产品编码弹出框
            }
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

    <script src="/Scripts/Sales/PreContractOperation.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
