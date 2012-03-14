<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    QProjectView
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ProjectLayer">
        <form name="ProjectAdd" action="" id="ProjectAdd">
        <div>
            <%=Html.AutoBindForm("SD_ProjectModule","SD_Project_TOP",false,false,false)%>
        </div>
        <div id="tabs2">
            <ul>
                <li><a href="#tabs2-1">基本信息</a></li>
                <li><a href="#tabs2-2">施工单位信息</a></li>
                <li><a href="#tabs2-3">工程路线</a></li>
                <%--<li><a href="#tabs2-4">工程部位</a></li>--%>
            </ul>
            <div id="tabs2-1">
                <%=Html.AutoBindForm("SD_ProjectModule","SD_Project",false,false,false)%>
            </div>
            <div id="tabs2-2">
                <%=Html.AutoBindForm("SD_ProjectModule", "SD_Project_Unit", false, false, false)%>
            </div>
        </form>
        <div id="tabs2-3">
            <%--工程路线--%>
            <%=Html.JqGridListPage("SD_CTransModule", "SD_CTrans", "", "", "")%>
        </div>
        <%--<div id="tabs2-4">--%>
            <%--工程部位--%>
           <%-- <%=Html.JqGridListPageNoTool("SD_ProjectPartsModule", "SD_ProjectParts", "", "", "")%>
        </div>--%>
    </div>
    <div class="FormToolBar">
        <input type="hidden" value="add" id="SD_ProjectModule_Formoper" name="SD_ProjectModule_Formoper" />
        <input type="button" onclick="ProjectClose()" value="返回" name="cancle" id="SD_ProjectModule_FormCancle" />
    </div>
    </div>

    <script type="text/javascript">
    
    //合同编码
    var CCode = "<%=ViewData["SDI_MCode"].ToString()%>";

    $(function() {
    //cl:页面元素只读
           GLOBAL.PageReadOnly();
    
        $("#tabs2").tabs();
        Project_edit();
//        $("#ProjectLayer").dialog({ autoOpen:false,title:'工程编辑',width:800 });
        
        //合同参考
//        $("#SDI_MCode").live("click",function () {
//            WH_ContractModuleWH_ContractOpenReferWithFilter("",function (data) {
//             $("#SDI_MCode").val(data.Contract_Name);
//        });
//        });   
        
        $("#SD_CTrans_Form").find("#SDT_DCode").live("click",function () {
            var obj=$(this);
            PC_BLinesModulePC_BLinesOpenReferWithFilter("",function (data) {
             obj.val(data.PCBL_Name);
        });
        });        
        //把工程编码附加到工程路线，工程部位
        $("input[name=SDT_PCode]").each(function () {
            $(this).val($("#ProjectAdd").find("#CCode").val());            
        });
        $("input[name=SDPP_PCode]").each(function () {
            $(this).val($("#ProjectAdd").find("#CCode").val());            
        });
        
    });    
    
    function Project_edit() {
         
        $("#ProjectAdd")[0].reset();
        $.ajax(
        {
            type: 'post',
            url: '/Sales/ProjectGetModel/'+CCode,
            dataType: 'json',
            success: function(data) {
            
                GridListReInit(data);
            
                $("#ProjectAdd")[0].reset();
                $("#ProjectAdd").find('input,select,textarea').each(function(key, element) {
                 if(element.type=='checkbox' || element.type=='text' || element.type=='select-one'){
                        for (var p in data) {
                            if (p == element.id) {
                                if (element.type == 'checkbox') {//页面上的复选框
                                    element.checked = data[p];
                                } else if (element.type == 'text') {
                                    element.value = data[p];

                                } else if (element.type == 'select-one') { //页面上的下拉菜单
                                    var e = $(element);
                                    e.val(data[p]);
                                } else{
                                    $(element).val(data[p]);
                                }
                            }
                        }
                 }                                 
                });
            }
        });

    }

  
    function ProjectClose() {
       window.close();
    }
   
    
    function GridListReInit(data) {
        if(data!=undefined)
        {
            //将工程编码作为工程路线和工程部位的筛选条件           
            $("#SD_CTransgrid").setGridParam({ url:'/Sales/GetSDCTransList/'+data.SDI_Code}).trigger("reloadGrid");                
            $("#SD_ProjectPartsgrid").setGridParam({ url:'/Sales/GetSDProjectPartsList/'+data.SDI_Code}).trigger("reloadGrid");
        }
        else
        {
             //将工程编码作为工程路线和工程部位的筛选条件           
            $("#SD_CTransgrid").setGridParam({ url:'/Sales/GetSDCTransList/'}).trigger("reloadGrid");                
            $("#SD_ProjectPartsgrid").setGridParam({ url:'/Sales/GetSDProjectPartsList/'}).trigger("reloadGrid");
        }
        //把工程编码附加到工程路线，工程部位
//        $("input[name=SDT_PCode]").each(function () {
//            $(this).val($("#ProjectAdd").find("#SDI_Code").val());            
//        });
//        $("input[name=SDPP_PCode]").each(function () {
//            $(this).val($("#ProjectAdd").find("#SDI_Code").val());            
//        });
//        $("input[name=SDI_MCode]").each(function () {
//            $(this).val(SDI_Code);
//        });
    }
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Global.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
