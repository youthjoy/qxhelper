<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>

<%--����--%>
   <div id="Document_Lending4Manage_Oper" style="display:none">
    <%=Html.AutoBindForm("Document_Lending4ManageModule","Document_Lending4Manage",false,true,false)%>    
    <%=Html.AutoBindValidate("Document_Lending4ManageModule")%>
    <div class='FormToolBar'>       
        <input id='btnSaveData' type='button' name='button' value='ȷ��' />
        <input id='btnCancle' type='button' name='cancle' value='ȡ��' />
    </div> 
    </div>
    
   
<%=Html.ReferControl("HR_StuffModule", "HR_Stuff",false)%>
<script type="text/javascript">
    $(document).ready(function() {

        $('#Document_Lending4Manage_Oper').dialog({ autoOpen: false, width: 800, minWidth: 810 });
        //$('#Document_Lending4Manage_Oper').dialog('open');
        //<li class="toolbar_btn1" id="Document_Manage_Document_ManageModule_btn1"><a href="#" onclick="Document_Manage_Document_ManageModuleToolBarExtends.Btn1()" id="Document_Manage_Document_ManageModule_btn1a">����</a></li>
        //<li class='toolbar_btn2' id='Document_Manage_Document_ManageModule_btn2'><a href='#' onclick='Document_Manage_Document_ManageModuleToolBarExtends.Btn2()' id='Document_Manage_Document_ManageModule_btn2a'>�ƽ�</a></li>

        $("#Document_Manage_Document_ManageModule_toolbar_search").after("<li class='toolbar_btn1' id='Document_Manage_Document_ManageModule_btn1'><a href='#' id='Document_Manage_Document_ManageModule_btn1a'>����</a></li>")
        $("#Document_Manage_Document_ManageModule_btn1").after("<li class='toolbar_btn2' id='Document_Manage_Document_ManageModule_btn2'><a href='#' id='Document_Manage_Document_ManageModule_btn2a'>�ƽ�</a></li>");

        $("#Document_Manage_Document_ManageModule_btn1a").unbind();
        $("#Document_Manage_Document_ManageModule_btn1a").click(function() {

            var grid = $('#Document_Managegrid');
            var curid = grid.getGridParam('selrow'); //��ȡѡ���е�id
            var data = grid.getRowData(curid); //��ȡ�к�Ϊcurid������            
            if (data.DM_Code == undefined) {
                ShowMsg('��ѡ�н�����');
                return;
            }
            if (data.DM_InNum == "") {
                ShowMsg('�����ڲ�����Ѿ����꣡');
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

        //�ύ
        $("#btnSaveData").click(function() {
            if (!$('#Document_Lending4Manage_Form').validate().form()) {
                return false;
            } else {

                var grid = $('#Document_Managegrid');
                var curid = grid.getGridParam('selrow'); //��ȡѡ���е�id
                var datae = grid.getRowData(curid); //��ȡ�к�Ϊcurid������


                $.ajax({ url: '/ExtendRecord/SaveData',
                    type: "post",
                    data: { BorrowDate: $('#Document_Lending4Manage_Form').FormToJson(), mdate: datae.DM_ID
                    },
                    success: function(result) {
                        if (result == "borrowNumGreaterThan") {
                            ShowMsg("�����ڲ�������㣡");
                        }
                        else if (result != "false") {

                            $("#Document_Lending4Manage_Oper").dialog("close");

                            $("#Document_Managegrid").trigger("reloadGrid");

                            ShowMsg("�������ĳɹ���ӣ�");

                        }

                        else { ShowMsg("�����������ʧ��"); }

                    }
                })

            }
        });

        //ȡ��
        $("#btnCancle").click(function() {

            $('#Document_Lending4Manage_Oper').dialog('close');
        });
    });
 

</script>

<%--�ƽ�--%>
    <div id="Document_Movement_Oper" style="display:none">
        <%=Html.AutoBindForm("Document_Movement4ManageModule", "Document_Movement4Manage", false, true, false)%>
        <div class='FormToolBar'>       
            <input id='btnFSaveData' type='button' name='btnFSaveData' value='ȷ��' />
            <input id='btnFCancle' type='button' name='btnFCancle' value='ȡ��' />
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
            var curid = grid.getGridParam('selrow'); //��ȡѡ���е�id
            var data = grid.getRowData(curid); //��ȡ�к�Ϊcurid������

            if (data.DM_Code == undefined) {
                ShowMsg('��ѡ����Ҫ�ƽ��ĵ�����');
                return;
            }
            if (data.DM_Num != data.DM_InNum) {
                ShowMsg('�����ڲ�������������ݲ����ƽ���');
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

        //�ύ
        $("#btnFSaveData").click(function() {

            var grid = $('#Document_Managegrid');
            var curid = grid.getGridParam('selrow'); //��ȡѡ���е�id
            var datae = grid.getRowData(curid); //��ȡ�к�Ϊcurid������
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
                        ShowMsg("��ӵ����ƽ���Ϣʧ�ܣ�");
                    }
                }
            });
        });


        //ȡ��
        $("#btnFCancle").click(function() {

            $('#Document_Movement_Oper').dialog('close');
        });

    });

</script>


    <script type="text/javascript">
        $(document).ready(function() {


        //�ڲ�������ж�
        $("#DM_InNum,#DM_Num").focusout(function() {
            //ShowMsg(parseInt($("#DM_InNum").val()) > parseInt($("#DM_Num").val())?"�ڲ��������":"��ȷ");
            if (parseInt($("#DM_InNum").val()) > parseInt($("#DM_Num").val())) {
                ShowMsg("�ڲ�������ܴ��ڷ�������������д");
                $("#DM_InNum").val("");
            }
            else if (parseInt($("#DM_InNum").val()) < parseInt($("#DM_Num").val())) {
//                var r = confirm("ȷ���ڲ����С���˷���!");
//                if (r == true) {
//                   
//                }
            //                else {  $("#DM_InNum").val("");}
            ShowMsg("�ڲ��������С�ڷ�������������д");
            $("#DM_InNum").val("");
            }
            else {

            }
        });

            //����
            //�ύ��DM_HoldingPerson 
            //�ύ����DM_HoldingDept   DM_HoldingDept
        $("#DM_HoldingPerson").click(function() {
               //TODO:1.7 ֻҪ�ܾ������
        HR_StuffModuleHR_StuffOpenReferWithFilter(" Stuff_DepCode='gzj'",
            function(data) {
                $("#DM_HoldingDept").val(data.Stuff_DepName);
                $("#DM_HoldingPerson").val(data.Stuff_Name);
            });
        });

//������
        $("#DL_Person").click(function() {
            //TODO:1.7 �������ʱ�ύ���룬ֻ��˲��ŵ��� ok $("#tmpDeptCode").val()
        HR_StuffModuleHR_StuffOpenReferWithFilter("Stuff_DepCode in (select dept_code from HR_Department where Dept_PCode='" + $("#tmpDeptCode").val() + "' or Dept_Code='" + $("#tmpDeptCode").val() + "')",
            function(data) {
            $("#DL_LendorDept").val(data.Stuff_DepName);
                $("#DL_Person").val(data.Stuff_Name);
            });
        });
        });
    </script>








