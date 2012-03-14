<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>

<%--借阅--%>
   <div id="Document_Lending4Manage_Oper" style="display:none">
    <%=Html.AutoBindForm("Document_Lending4ManageModule","Document_Lending4Manage",false,true,false)%>    
    <%=Html.AutoBindValidate("Document_Lending4ManageModule")%>
    <div class='FormToolBar'>       
        <input id='btnSaveData' type='button' name='button' value='确定' />
        <input id='btnCancle' type='button' name='cancle' value='取消' />
    </div> 
    </div>
    
   
<%=Html.ReferControl("HR_StuffModule", "HR_Stuff",false)%>
<script type="text/javascript">
    $(document).ready(function() {

        $('#Document_Lending4Manage_Oper').dialog({ autoOpen: false, width: 800, minWidth: 810 });
        //$('#Document_Lending4Manage_Oper').dialog('open');
        //<li class="toolbar_btn1" id="Document_Manage_Document_ManageModule_btn1"><a href="#" onclick="Document_Manage_Document_ManageModuleToolBarExtends.Btn1()" id="Document_Manage_Document_ManageModule_btn1a">借阅</a></li>
        //<li class='toolbar_btn2' id='Document_Manage_Document_ManageModule_btn2'><a href='#' onclick='Document_Manage_Document_ManageModuleToolBarExtends.Btn2()' id='Document_Manage_Document_ManageModule_btn2a'>移交</a></li>

        $("#Document_Manage_Document_ManageModule_toolbar_search").after("<li class='toolbar_btn1' id='Document_Manage_Document_ManageModule_btn1'><a href='#' id='Document_Manage_Document_ManageModule_btn1a'>借阅</a></li>")
        $("#Document_Manage_Document_ManageModule_btn1").after("<li class='toolbar_btn2' id='Document_Manage_Document_ManageModule_btn2'><a href='#' id='Document_Manage_Document_ManageModule_btn2a'>移交</a></li>");

        $("#Document_Manage_Document_ManageModule_btn1a").unbind();
        $("#Document_Manage_Document_ManageModule_btn1a").click(function() {

            var grid = $('#Document_Managegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.DM_Code == undefined) {
                ShowMsg('请选中借阅行');
                return;
            }
            if (data.DM_InNum == "") {
                ShowMsg('档案在册份数已经借完！');
                return;
            } else {
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
        });

        //提交
        $("#btnSaveData").click(function() {
            if (!$('#Document_Lending4Manage_Form').validate().form()) {
                return false;
            } else {

                var grid = $('#Document_Managegrid');
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

                            $("#Document_Managegrid").trigger("reloadGrid");

                            ShowMsg("档案借阅成功添加！");

                        }

                        else { ShowMsg("档案借阅添加失败"); }

                    }
                })

            }
        });

        //取消
        $("#btnCancle").click(function() {

            $('#Document_Lending4Manage_Oper').dialog('close');
        });
    });
 

</script>

<%--移交--%>
    <div id="Document_Movement_Oper" style="display:none">
        <%=Html.AutoBindForm("Document_Movement4ManageModule", "Document_Movement4Manage", false, true, false)%>
        <div class='FormToolBar'>       
            <input id='btnFSaveData' type='button' name='btnFSaveData' value='确定' />
            <input id='btnFCancle' type='button' name='btnFCancle' value='取消' />
        </div> 
    </div>
    <%=Html.AutoBindValidate("Document_Movement4ManageModule")%>

<script src="/Scripts/Shared/jquery-1.0.formtojson.js" type="text/javascript"></script>
<script type="text/javascript">
    $(document).ready(function() {
        $('#Document_Movement_Oper').dialog({ autoOpen: false, width: 800, minWidth: 810 });
        
        $("#Document_Manage_Document_ManageModule_btn2a").unbind();
        $("#Document_Manage_Document_ManageModule_btn2a").click(function() {

            var grid = $('#Document_Managegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据

            if (data.DM_Code == undefined) {
                ShowMsg('请选中所要移交的档案行');
                return;
            }
            if (data.DM_Num != data.DM_InNum) {
                ShowMsg('档案在册份数不完整，暂不能移交！');
                return;
            } else {
                $('#Document_Movement4Manage_Form')[0].reset();
                $('#Document_Movement_Oper').dialog('open');
                $.ajax(
                        {
                            type: 'post',
                            url: '/Sys_Config_ListPage/GetTableKeyCode',
                            data: { oper: 'add', n: 'Document_Movement' },
                            success: function(result) {
                                $('#Document_Movement4Manage_Form').find('#Mov_FileName').val(data.DM_Name);
                                $('#Document_Movement4Manage_Form').find('#Mov_DocumentCode').val(data.DM_Code);
                                $('#Document_Movement4Manage_Form').find('#Mov_FileCode').val(data.DM_FileNumber);
                                $('#Document_Movement4Manage_Form').find('#Mov_GMOperator').val(data.DM_Issuer);
                                $('#Document_Movement4Manage_Form').find('#Mov_Num').val(data.DM_InNum);
                                $('#Document_Movement4Manage_Form').find('#Mov_Code').val(result);

                                Comm_Session.GetValue('Company', function(data) { $('#DL_LendorCompany').val(data); });

                            }
                        });
            }
        });

        //提交
        $("#btnFSaveData").click(function() {

            var grid = $('#Document_Managegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var datae = grid.getRowData(curid); //获取行号为curid的数据
            $.ajax({
                url: '/FileMove/FileMoveInfo',
                type: 'post',
                data: { movedate: $('#Document_Movement4Manage_Form').FormToJson(),
                    mdate: datae.DM_ID
                },
                success: function(data) {

                    if (data == "ok") {
                        $("#Document_Movement_Oper").dialog("close");
                        $("#Document_Managegrid").trigger("reloadGrid");
                       

                    } else {
                        ShowMsg("添加档案移交信息失败！");
                    }
                }
            });
        });


        //取消
        $("#btnFCancle").click(function() {

            $('#Document_Movement_Oper').dialog('close');
        });

    });

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
//                var r = confirm("确定在册份数小于了份数!");
//                if (r == true) {
//                   
//                }
            //                else {  $("#DM_InNum").val("");}
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
               //TODO:1.7 只要总经办的人
        HR_StuffModuleHR_StuffOpenReferWithFilter(" Stuff_DepCode='gzj'",
            function(data) {
                $("#DM_HoldingDept").val(data.Stuff_DepName);
                $("#DM_HoldingPerson").val(data.Stuff_Name);
            });
        });

//借阅人
        $("#DL_Person").click(function() {
            //TODO:1.7 点击部门时提交编码，只需此部门的人 ok $("#tmpDeptCode").val()
        HR_StuffModuleHR_StuffOpenReferWithFilter("Stuff_DepCode in (select dept_code from HR_Department where Dept_PCode='" + $("#tmpDeptCode").val() + "' or Dept_Code='" + $("#tmpDeptCode").val() + "')",
            function(data) {
            $("#DL_LendorDept").val(data.Stuff_DepName);
                $("#DL_Person").val(data.Stuff_Name);
            });
        });
        });
    </script>








