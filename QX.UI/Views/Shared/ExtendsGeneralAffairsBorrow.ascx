<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>   
<%@ Import Namespace="QX.HtmlHelperLib" %>


   <div id="Document_Lending4Manage_Oper" style="display:none">
    <%=Html.AutoBindForm("Document_Lending4ManageModule","Document_Lending4Manage",false,true,false)%>    
    <%=Html.AutoBindValidate("Document_Lending4ManageModule")%>
    <div class='FormToolBar'>       
        <input id='btnSaveData' type='button' name='button' value='提交' />
        <input id='btnCancle' type='button' name='cancle' value='取消' />
    </div> 
    </div>
    <%=Html.ReferControl("HR_StuffModule", "HR_Stuff",false)%>
<script type="text/javascript">
    $(document).ready(function() {


    $("#Document_Manages_Document_ManageModules_toolbar_search").after("<li class='toolbar_btn1' id='Document_Manages_Document_ManageModules_btn1a'><a href='#' id='Document_Manages_Document_ManageModules_btn1a'>借阅</a></li>")

        $('#Document_Lending4Manage_Oper').dialog({ autoOpen: false, width: 800, minWidth: 810 });

        $("#Document_Manages_Document_ManageModules_btn1a").unbind();
        $("#Document_Manages_Document_ManageModules_btn1a").click(function() {

            var grid = $('#Document_Managesgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.DM_Code == undefined) {
                ShowMsg('请选中借阅行');
                return;
            }
            if (data.DM_InNum == "") {
                ShowMsg('档案在册份数已经借完！');
                return;
            }
            else {
                $('#Document_Lending4Manage_Form')[0].reset();
                $('#Document_Lending4Manage_Oper').dialog('open');
                $.ajax(
                        {
                            type: 'post',
                            url: '/Sys_Config_ListPage/GetTableKeyCode',
                            data: { oper: 'add', n: 'Document_Lending' },
                            success: function(result) {
                            $('#Document_Lending4Manage_Form').find('#DL_LendingNum').val(1);
                            $('#Document_Lending4Manage_Form').find('#DL_DocumentName').val(data.DM_Name);
                            $('#Document_Lending4Manage_Form').find('#DL_InNum').val(data.DM_InNum);
                                $('#Document_Lending4Manage_Form').find('#DL_DocumentCode').val(data.DM_Code);
                                $('#Document_Lending4Manage_Form').find('#DL_FileCode').val(data.DM_FileNumber);
                                $('#Document_Lending4Manage_Form').find('#DL_Code').val(result);

                                Comm_Session.GetValue('Company', function(data) { $('#DL_LendorCompany').val(data); });
                            }
                        });
            }
        }),

        //提交
$("#btnSaveData").click(function() {
    if (!$('#Document_Lending4Manage_Form').validate().form()) {
        return false;
    }
    else {

        var grid = $('#Document_Managesgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var datae = grid.getRowData(curid); //获取行号为curid的数据


        $.ajax({ url: '/ExtendRecord/SaveData',
            type: "post",
            data: { BorrowDate: $('#Document_Lending4Manage_Form').FormToJson(), mdate: datae.DM_ID
            },
            success: function(result) {
                if (result == "borrowNumGreaterThan") {
                    ShowMsg("档案在册份数不足！");
                }
                else if (result != "false") {

                    $("#Document_Lending4Manage_Oper").dialog("close");

                    $("#Document_Managesgrid").trigger("reloadGrid");

                    ShowMsg("档案借阅成功添加！");

                }

                else { ShowMsg("档案借阅添加失败"); }

            }
        })

    }
})
    }
),
    //取消
$("#btnCancle").click(function() {

    $('#Document_Lending4Manage_Oper').dialog('close');
})


</script>



<script type="text/javascript">

    $(document).ready(function() {
    //在册份数的判断
    $("#DM_InNum,#DM_Num").focusout(function() {
        //ShowMsg(parseInt($("#DM_InNum").val()) > parseInt($("#DM_Num").val())?"在册份数大了":"正确");
        if (parseInt($("#DM_InNum").val()) > parseInt($("#DM_Num").val())) {
            ShowMsg("在册份数不能大于份数！请重新填写");
            $("#DM_InNum").val("");
        }
        else if (parseInt($("#DM_InNum").val()) < parseInt($("#DM_Num").val())) {
//            var r = confirm("确定在册份数小于了份数!");
//            if (r == true) {
//                
//            }
        //            else { $("#DM_InNum").val("");}
        ShowMsg("在册份数不能小于份数！请重新填写");
        $("#DM_InNum").val("");
        }
        else {

        }
    });


    //档案
    //提交人DM_HoldingPerson 
    //提交部门DM_HoldingDept   DM_HoldingDept
    $("#DM_HoldingPerson").click(function() {
        //TODO:1.7 只要总务部的人
    HR_StuffModuleHR_StuffOpenReferWithFilter(" Stuff_DepCode='gzw'",
            function(data) {
        $("#DM_HoldingDept").val(data.Stuff_DepName);
                $("#DM_HoldingPerson").val(data.Stuff_Name);
            });
    });
    
    
    
    
    //借阅人 $("#tmpDeptCode").val()
    $("#DL_Person").click(function() {

    HR_StuffModuleHR_StuffOpenReferWithFilter(" Stuff_DepCode in (select dept_code from HR_Department where Dept_PCode='" + $("#tmpDeptCode").val() + "' or Dept_Code='" + $("#tmpDeptCode").val() + "')",
            function(data) {
                $("#DL_LendorDept").val(data.Stuff_DepName);
                $("#DL_Person").val(data.Stuff_Name);
            });
        });
    
    
    
    });
</script>
   
