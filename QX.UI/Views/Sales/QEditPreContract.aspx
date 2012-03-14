<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    合同编辑
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ContractInfo">
        <form id="ContractInfoForm" method='post' action="/Sales/ContractPreOperation">
        <input type='hidden' name='ContractFormoper' id='ContractFormoper' value='edit' />
        <input type='hidden' name='ContractType' id='ContractType' value='Audit' />
            <input type='hidden' name='ContractEditType' id='ContractEditType' value='draft' />
        <%=Html.AutoBindForm<QX.Model.SD_Contract>("SD_ContractPreModule","SD_Contract_TOP",(QX.Model.SD_Contract)Model,false,false,false)%>
        <%=Html.ReferControl("Ref_Cusomter", "WH_Supplier",false)%>
        <%=Html.AutoBindValidate("SD_ContractPreModule", "ContractInfoForm")%>
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">基本信息</a></li>
                <li><a href="#tabs-2">工程信息</a></li>
             <%--   <li><a href="#tabs-3">价格信息</a></li>
                <li><a href="#tabs-4">甲供信息</a></li>
                <li><a href="#tabs-5">联系人</a></li>
                <li><a href="#tabs-6">联系地址</a></li>--%>
            </ul>
            <div id="tabs-1">
                <%=Html.AutoBindForm<QX.Model.SD_Contract>("SD_ContractPreModule", "SD_Contract", (QX.Model.SD_Contract)Model, false, false, false)%>
            </div>
        </form>
        <div id="tabs-2">
            <%=Html.Common_ToolBarForListPage("All", "addN:'查看工程',addFunJs:'View()',editN:'工程维护',editFunJs:'Add()'")%>
            <%=Html.JqGrid("SD_ProjectModule", "All", "Cust", "All")%>
        </div>
     <%--   <div id="tabs-3">
            <table border="0" cellspacing="0" cellpadding="0" width="100%" style="margin-left: 10px">
                <tr>
                    <td valign="top" align="left" width="100px">
                        <div>
                            <input id="PPCode" type="hidden" name="PPCode" value="" />
                            <input id="PPName" type="hidden" name="PPName" value="" />
                            <input id="PDict_Code" type="hidden" name="PDict_Code" value="" />
                            <% 
                                List<QX.Model.Bse_Dict> list = (List<QX.Model.Bse_Dict>)ViewData["Product"];
                                list = list.OrderBy(o => o.Dict_Order).ToList();
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
                        <%=Html.JqGridListPage("SD_CPriceModule","SD_CPrice","","","")%>
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
        </div>--%>
    </div>
    <div style="float: left">
        <input type='button' name='withfun' class ='hide' value='草稿' onclick='PreContract_Operation.SaveDraft()' />
        <input type='button' name='withfun' value='提交' class ='hide' onclick='PreContract_Operation.SaveData()' />
        <input type='button' name='button' value='返回' onclick='PreContract_Operation.CancelEdit()' />
    </div>
    <%--参考--%>
    <%=Html.ReferControl("WH_SpeMaterialModule", "WH_MaterialSpe", false)%>
    <%=Html.ReferControl("Bse_DictModule", "Bse_Dict",false)%>
    <%=Html.ReferControl("WH_MaterialAModule","WH_Material",false)%>

    <script type="text/javascript">
    
        var tab='<%=ViewData["tab"]%>';
        
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
            /*
            Comm_Session.GetLoginUser(function(data) //签约人
            { $('#SDC_OwnerCode').val(data.UserId); $('#SDC_Owner').val(data.UserName); });
            Comm_Session.GetLoginUser(function(data) //执行人
            { $('#SDC_EOwnerCode').val(data.UserId); $('#SDC_EOwner').val(data.UserName); }); //合同执行人*/
            Comm_Session.GetCurrentDate(function(data) { $('#SDC_Date').val(data); }); //签约日期
            Comm_Session.GetCurrentDate(function(data) { $('#SDC_Start').val(data); }); //合同生效时间

            $('#SDC_Place').val("中国重庆涪陵");
            //绑定人员选择
            Common_EmpTree_Dept.Init("SDC_Owner", function(code, name) { $("#SDC_Owner").val(name); $("#SC_OwnerCode").val(code) });
            Common_EmpTree_Dept.Init("SDC_EOwner", function(code, name) { $("#SDC_EOwner").val(name); $("#SDC_EOwnerCode").val(code) });

            var view = "<%=ViewData["view"].ToString()%>";    
            if (view=="view") {
                $("input[name=withfun]").each(function () {
                    $(this).hide();
                })                                
            }
            
                        //价格初始化,并筛选数据
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
            var priceGrid = $("#SD_CPricegrid");
            priceGrid.setGridParam({ url: '/Sales/PriceFilter/' + $("#SDC_Code").val() }).trigger("reloadGrid");
            
            
            $("#Allgrid").setGridParam({url:"/Sales/ProjectWithContract/"+$("#SDC_Code").val()}).trigger("reloadGrid");
        });

        window.onload = function() {
            OnPageLoad();
            var priceGrid = $("#SD_CPricegrid");
            priceGrid.setGridParam({ url: '/Sales/PriceFilter/' + $("#SDC_Code").val() }).trigger("reloadGrid");
        }

        function OnPageLoad() {
            //获取合同相关的工程信息
            var ContractCode = $("#ContractInfoForm").find("#SDC_Code").val();
            $("#Allgrid").setGridParam({ url: '/Sales/ProjectWithContract/' + ContractCode }).trigger("reloadGrid");
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
//            var SDI_Code = $("#SDC_Code").val();
            var url = "/Sales/QProjectView/" + data.SDI_Code;
            //window.location = url;
            //showDialog(url);
            Win.Open(url,"","");
        }

        function All_Add() {
            var SDI_Code = $("#SDC_Code").val();
            var SDI_CCode=$("#SDC_CCode").val();
            var url = "/Sales/QProjectAdd/" + SDI_Code+"-"+SDI_CCode;
            //window.location = url;
            //showDialog(url);
            Win.Open(url,"","");
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
    
          
       <script type="text/javascript">
           //cl:查看。只读  
           var isView = '<%=ViewData["view"]%>';

           $(function() {
               if (isView != "") {
                   GLOBAL.PageReadOnly();
               }
           });    
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
