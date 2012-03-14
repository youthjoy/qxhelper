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
    
<script type="text/javascript">
    $(document).ready(function() {
    $("#Document_ManageF_Document_ManageModuleFILE_toolbar_search").after("<li class='toolbar_btn1' id='Document_Manage_Document_ManageModule_btn1'><a href='#' id='Document_ManageF_Document_ManageModuleFILE_btn1a'>借阅</a></li>")
    $("#Document_Manage_Document_ManageModule_btn1").after("<li class='toolbar_btn2' id='Document_Manage_Document_ManageModule_btn2'><a href='#' id='Document_ManageF_Document_ManageModuleFILE_btn2a'>下发</a></li>");

    $('#Document_Lending4Manage_Oper').dialog({ autoOpen: false, width: 800, minWidth: 810 });       


        $("#Document_ManageF_Document_ManageModuleFILE_btn1a").unbind();
        $("#Document_ManageF_Document_ManageModuleFILE_btn1a").click(function() {

            var grid = $('#Document_ManageFgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.DM_Code == undefined) {
                ShowMsg('请选中借阅行');
                return;
            }
            if (data.DM_InNum == "") {
                ShowMsg('文件在册份数已经借完！');
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

        var grid = $('#Document_ManageFgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var datae = grid.getRowData(curid); //获取行号为curid的数据


        $.ajax({ url: '/ExtendRecord/SaveData',
            type: "post",
            data: { BorrowDate: $('#Document_Lending4Manage_Form').FormToJson(), mdate: datae.DM_ID
            },
            success: function(result) {
                if (result == "borrowNumGreaterThan") {
                    ShowMsg("文件在册份数不足！");
                }
                else if (result != "false") {

                    $("#Document_Lending4Manage_Oper").dialog("close");

                    $("#Document_ManageFgrid").trigger("reloadGrid");

                    ShowMsg("文件借阅成功添加！");

                }

                else { ShowMsg("文件借阅添加失败"); }

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





 <%--下发--%>
    <div id="Document_IssueBRecordModule_Oper" style="display:none">
        <%=Html.AutoBindForm("Document_IssueBRecordModule", "Document_IssueBRecord", false, true, false)%>
        <div class='FormToolBar'>       
            <input id='btnFilIssuedBye' type='button' name='btnFSaveData' value='提交' />
            <input id='btnFIssuedByeCancel' type='button' name='btnFCancle' value='取消' />
        </div> 
    </div>
    <%=Html.AutoBindValidate("Document_IssueBRecordModule")%>

<script src="/Scripts/Shared/jquery-1.0.formtojson.js" type="text/javascript"></script>


     <script type="text/javascript">
         $(function() {
             $("#Document_IssueBRecordModule_Oper").dialog({ autoOpen: false, width: 800, minWidth: 810 });
             $("#DIR_IssueObjectType").change(function() {
                 var value = $(this).val();
                 if (value == "DEPT") {
                     Common_Tree_Dept.Init("DIR_IssueObject", function(code, name, rootName) {
                        $("#DIR_IssueObject").val(name);
                     });
                     $("#DIR_IssueObject").addClass("TextBoxReadOnly popup");
                 } else {
                     $("#DIR_IssueObject").unbind();
                     $("#DIR_IssueObject").removeClass("TextBoxReadOnly popup");
                 }

             })
             $("#Document_ManageF_Document_ManageModuleFILE_btn2a").unbind();
             $("#Document_ManageF_Document_ManageModuleFILE_btn2a").click(function() {

                 var grid = $('#Document_ManageFgrid');
                 var curid = grid.getGridParam('selrow'); //获取选择行的id
                 var data = grid.getRowData(curid); //获取行号为curid的数据

                 if (data.DM_Code == undefined) {
                     ShowMsg('请选中所要移交的文件行');
                     return;
                 }
                 //TODO:文件下发时要判断文件份数？
                 else {
                     $('#Document_IssueBRecord_Form')[0].reset();
                     $.ajax(
                        {
                            type: 'post',
                            url: '/Sys_Config_ListPage/GetTableKeyCode',
                            data: { oper: 'add', n: 'Document_Movement' },
                            success: function(result) {
                                $('#Document_IssueBRecord_Form').find('#DIR_DocumentName').val(data.DM_Name);
                                $('#Document_IssueBRecord_Form').find('#DIR_Code').val(data.DM_Code);
                                $('#Document_IssueBRecord_Form').find('#DIR_DocmentContent').val(data.DM_Content);
                                $('#Document_IssueBRecord_Form').find('#DIR_FileCode').val(data.DM_FileNumber);




                                $('#Document_IssueBRecord_Form').find('#DIR_DocumentCode').val(result);

                                Comm_Session.GetValue('Company', function(data) { $('#DL_LendorCompany').val(data); });
                                $('#Document_IssueBRecordModule_Oper').dialog('open');
                            }
                        });
                 }
             }),

             //提交
$("#btnFilIssuedBye").click(function() {
    if (!$('#Document_IssueBRecord_Form').validate().form()) {
        return false;
    } else {

        var grid = $('#Document_ManageFgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var datae = grid.getRowData(curid); //获取行号为curid的数据
        $.ajax({
            url: '/FileMove/FileIssuedInfo',
            type: 'post',
            data: { movedate: $('#Document_IssueBRecord_Form').FormToJson(),
                mdate: datae.DM_ID
            },
            success: function(data) {

                if (data == "ok") {
                    $("#Document_IssueBRecordModule_Oper").dialog("close");
                    $("#Document_ManageFgrid").trigger("reloadGrid"); //刷新div
                    debugger;
                } else {
                    ShowMsg("添加文件下发信息失败！");
                }
            }
        });
    }
}

),


             //取消
$("#btnFIssuedByeCancel").click(function() {

    $('#Document_IssueBRecordModule_Oper').dialog('close');
})
         }
            )
     </script>
     
     <script type="text/javascript">

         $(function() {

         //在册份数的判断
         $("#DM_InNum,#DM_Num").focusout(function() {
             if (parseInt($("#DM_InNum").val()) > parseInt($("#DM_Num").val())) {
                 ShowMsg("在册份数不能大于份数！请重新填写");
                 $("#DM_InNum").val("");
             }
             else if (parseInt($("#DM_InNum").val()) < parseInt($("#DM_Num").val())) {
//                 var r = confirm("确定在册份数小于了份数!");
//                 if (r == true) {
//                     
//                 }
             //                 else { $("#DM_InNum").val(""); }
             ShowMsg("在册份数不能效小于份数！请重新填写");
             $("#DM_InNum").val("");
             }
             else {

             }
         });
         
         
         //文件提交人
         $("#DM_HoldingPerson").bind("click", function() {
         HR_StuffModuleHR_StuffOpenReferWithFilter("", function(data) {
                 $("#DM_HoldingPerson").val(data.Stuff_Name);
                 $("#DM_HoldingDept").val(data.Stuff_DepName);
             });
         });


         //借阅人$("#tmpDeptCode").val()
         $("#DL_Person").bind("click", function() {
         HR_StuffModuleHR_StuffOpenReferWithFilter(" Stuff_DepCode in (select dept_code from HR_Department where Dept_PCode='" + $("#tmpDeptCode").val() + "' or Dept_Code='" + $("#tmpDeptCode").val() + "')", function(data) {
             $("#DL_Person").val(data.Stuff_Name);
             $("#DL_LendorDept").val(data.Stuff_DepName);
             });
         });
     });
     </script>
       <%=Html.ReferControl("HR_StuffModule", "HR_Stuff",false)%>