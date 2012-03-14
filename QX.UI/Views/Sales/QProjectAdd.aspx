<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    QProjectAdd
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!--工程信息-->
    <%=Html.Common_ToolBarForListPage("Project","addFunJs:'add()',editFunJs:'edit()',delFunJs:'del()',viewFunJs:'view()'")%>
    <%--<%=Html.JqGrid("SD_CProjectModule", "Valid", "Cust", "Valid")%>--%>
    <%=Html.SysComm_JqGrid("SD_CProjectModule", "Valid", "/Sales/ProjectWithContract/" + ViewData["SDI_Code"].ToString(),"","","Cust","Valid",true)%>
    <%--工程路线--%>
    <%=Html.JqGrid("SD_CTransModule","ReadList","","")%>
    
    
    <div id="ProjectLayer" style="display: none">
        <form name="ProjectAdd" action="" id="ProjectAdd">
        <div>
            <%=Html.AutoBindForm("SD_CProjectModule", "SD_Project_TOP", false, false, false)%>
        </div>
        <div id="tabs2">
            <ul>
                <li><a href="#tabs2-1">基本信息</a></li>
                <li><a href="#tabs2-2">施工单位信息</a></li>
                <li><a href="#tabs2-3">工程路线</a></li>
            </ul>
            <div id="tabs2-1">
                <%=Html.AutoBindForm("SD_CProjectModule", "SD_Project", false, false, false)%>
            </div>
            <div id="tabs2-2">
                <%=Html.AutoBindForm("SD_CProjectModule", "SD_Project_Unit", false, false, false)%>
            </div>
        </form>
        <div id="tabs2-3">
            <%--工程路线--%>
            <div style="width:100%">
            <%=Html.Common_ToolBarForListPage("SD_CTransModule", "SD_CTrans", " export:'false',import:'false',search:'false' ")%>
            <%=Html.JqGridListPage("SD_CTransModule", "SD_CTrans", "", "", "")%>
            </div>
            <%--<%=Html.SysComm_JqGrid("SD_CTransModule","SD_CTrans","","","","","",false)%>--%>
        </div>
    </div>
    
    
    <div class="FormToolBar">
        <input type="hidden" value="add" id="SD_ProjectModule_Formoper" name="SD_ProjectModule_Formoper" />
        <input type="button" onclick="ProjectSave()" value="确 定" name="button" id="SD_ProjectModule_FormOK" />
        <input type="button" onclick="ProjectClose()" value="取 消" name="cancle" id="SD_ProjectModule_FormCancle" />
    </div>
    </div>
    <%--合同表单验证--%>
    <%=Html.AutoBindValidate("SD_CProjectModule", "ProjectAdd")%>
    <%--合同参考--%>
    <%=Html.ReferControl("WH_ContractModule","WH_Contract",false)%>
    <%--搅拌站参考--%>
    <%=Html.ReferControl("PC_BLinesModule", "PC_BLines", false)%>
    <%--车辆参考    --%>
    <%=Html.ReferControl("PCT_InfoModule", "PCT_Info", false)%>

    <script type="text/javascript">
    //合同编码
    var SDI_Code = "<%=ViewData["SDI_Code"].ToString()%>";
    //合同编码
    var SDI_CCode="<%=ViewData["SDI_CCode"].ToString()%>";
    $(function() {
        $("#tabs2").tabs();
    
              
        $("#ProjectLayer").dialog({ autoOpen:false,title:'工程编辑',width:800 });
        
        //合同参考
        $("#SDI_MCode").live("click",function () {
            WH_ContractModuleWH_ContractOpenReferWithFilter("",function (data) {
             $("#SDI_MCode").val(data.Contract_Name);
        });
        });   
        
        //搅拌站参考
        $("#SD_CTrans_Form").find("#SDT_DName").live("click",function () {
            var obj=$(this);
            PC_BLinesModulePC_BLinesOpenReferWithFilter("",function (data) {
             obj.val(data.PCBL_Name);
             $("#SDT_DCode").val(data.PCBL_SCode);
        });
        });        
        //把工程编码附加到工程路线，工程部位
        $("input[name=SDT_PCode]").each(function () {
            $(this).val($("#ProjectAdd").find("#SDI_Code").val());            
        });
        $("input[name=SDPP_PCode]").each(function () {
            $(this).val($("#ProjectAdd").find("#SDI_Code").val());            
        });
        
        $("#SDT_CarNo").bind("click",function () {
            var obj=$(this);
            PCT_InfoModulePCT_InfoOpenReferWithFilter(" PCTI_iType='Vehicle' ",function (data) {
                obj.val(data.PCTI_NO);
           });
        })        
        
        $(".ui-icon-refresh").remove();
        
    });    
    
    window.onload=function(){ $("#Allgrid").setGridParam({ url: '/Sales/ProjectWithContract/<%=ViewData["SDI_Code"].ToString()%>' }).trigger("reloadGrid"); }
    
 
    
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
        $("input[name=SDT_PCode]").each(function () {
            $(this).val($("#ProjectAdd").find("#SDI_Code").val());            
        });
        $("input[name=SDPP_PCode]").each(function () {
            $(this).val($("#ProjectAdd").find("#SDI_Code").val());            
        });
        $("input[name=SDI_MCode]").each(function () {
            $(this).val(SDI_Code);
        });
    }
    
    //工程 添加：编辑，删除
    function Project_add(){
        $("#ProjectLayer").dialog("open"); 
         $("#ProjectAdd")[0].reset();
         
          $.ajax(
        {
            type: 'post',
            url: '/Sales/GetProjectCode/',
            dataType: 'json',
            success: function(data) {
               $("#SDI_Code").val(data.SDI_Code); 
               GridListReInit(data);    
            }
        });
         
        $("input[name=SDI_MCode]").each(function () {
            $(this).val(SDI_Code);
        });
        $("input[name=SDI_CCode]").each(function () {
            $(this).val(SDI_CCode);
        });           
                
    }
    
    
    function Project_edit() {
            
        var grid = $('#Validgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据            
        if (data.SDI_Code == undefined) {
            ShowMsg('请选中编辑行');
            return;
        }       
        $("#ProjectLayer").dialog("open");    
        $("#ProjectAdd")[0].reset();
        $.ajax(
        {
            type: 'post',
            url: '/Sales/ProjectGetModel/'+data.SDI_Code,
            dataType: 'json',
            success: function(data) {
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
               
                GridListReInit(data);
                $("#SDI_Bak").val(data.SDI_Bak);     
            }
        });

    }
    
       //cl:查看
     function Project_view() {      
        var grid = $('#Validgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据            
        if (data.SDI_Code == undefined) {
            ShowMsg('请选中编辑行');
            return;
        }       
        $("#ProjectLayer").dialog("open"); 
            
        $("#ProjectAdd")[0].reset();
        $.ajax(
        {
            type: 'post',
            url: '/Sales/ProjectGetModel/'+data.SDI_Code,
            dataType: 'json',
            success: function(data) {
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
               
                GridListReInit(data);
                $("#SDI_Bak").val(data.SDI_Bak);     
            }
        });        //cl:
         GLOBAL.PageReadOnly("","#ProjectAdd");
    }

    function Project_del() {
        
        var grid = $('#Validgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id        var data = grid.getRowData(curid); //获取行号为curid的数据                    if (data.SDI_Code == undefined) {
            ShowMsg('请选中编辑行');
            return;
        }
        ShowMsg("你确定要删除工程信息吗?",function(yes){
            if (yes) {
                $.post("/Sales/QProjectDel/"+data.SDI_Code,null,function(Re){
                if(Re.result="success")
                {
                $("#Validgrid").trigger("reloadGrid");                
                $("#ReadListgrid").trigger("reloadGrid");
                ShowMsg("删除成功");
                }else{
                ShowMsg(Re.msg);
                }
                }); 
            }
        });
               
    }
    
    function ProjectSave() {
        if (!$("#ProjectAdd").validate().form()) {
            return false;
        }        
        
        $.ajax({url:'/Sales/ProjectSave',type:'post',data:$("#ProjectAdd").serialize(),success:function (result) {
                if (result=="success") {
                    ProjectClose();
                }
        } });
        
    }
    //关闭弹出层
    function ProjectClose() {
        $("#ProjectLayer").dialog("close");
        $("#Validgrid").trigger("reloadGrid");
        $("#ReadList").trigger("reloadGrid");
    }
    
    //工程路线
    function SD_CTrans_Add() {
        
    }
    function SD_CTrans_Edit() {
    
    }
    function SD_CTrans_Del() {
    
    }   
      
    
    //窗口关闭前事件
    window.onbeforeunload=function(event){
          window.opener.OnPageLoad();
    }    
    
    </script>

    <script language="javascript">
        $(function() {
            $("#SDI_CCode").live("click", function() {
//                Ref_CusomterWH_SupplierOpenReferWithFilter("", function(data) {
//                    $("#SDI_CCode").val(data.WHS_CustCode);
//                });
            });
        });
    </script>

    <%=Html.ReferControl("Ref_Cusomter", "WH_Supplier",false)%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Global.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
