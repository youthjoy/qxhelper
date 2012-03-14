<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    待办零件图纸
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">待办列表</a></li>
            <li><a href="#tabs-2">待审列表</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("DoingBse_ComponentsModule", "DoingBse_Components", "addN:'处理',addFunJs:'Handle()',viewN:'查看'")%>
            <%=Html.SysComm_JqGrid("DoingBse_ComponentsModule", "DoingBse_Components", "/Comp/GetDoingList", true)%>
        </div>
        <div id="tabs-2">
            <%=Html.GenToolbarNoPermissionHelper("Bse_ComponentsModule", "AuditComp", "addN:'审核',addFunJs:'Audit()',editN:'查看修订',viewN:'查看'")%>
            <%=Html.SysComm_JqGrid("Bse_ComponentsModule", "AuditComp", "/Comp/GetAuditList", true)%>
        </div>
    </div>
    <% Html.RenderPartial("AuditControl");%>
    <div class='list_openlayer' id='Doc_Allot_Oper' style='display: none'>
        <form class='FormClass' action='/Doc/AllotOperation' id='Doc_Allot_Form' method='post'
        name='Doc_Allot_Form'>
        <%=Html.AutoBindForm("Doc_AllotModule", "Doc_Allot",false, false, false)%>
        </form>
    </div>

    <script type="text/javascript">

        $(document).ready(function() {
            $("#Doc_Allot_Oper").dialog({ minWidth: 680,
                minHeight: 200,
                autoOpen: false,

                modal: true,

                buttons: {

                    "确定": function() {

                        $(this).dialog('close');
                        $("#Doc_Allot_Form").ajaxSubmit();
                    },

                    "取消": function() {

                        $(this).dialog('close');



                    }

                }

            });


        })

        


        //处理
        function DoingBse_ComponentsHandle() {

            var grid = $('#DoingBse_Componentsgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据

            $.ajax({
                type: "post",
                url: "/Doc/GetAllotModel",
                dataType: "json",
                data: { code: data.Comp_Code, module: "Bse_ComponentsModule" },
                success: function(data, textStatus) {
                    for (var p in data) {
                        var tmp = $("#" + p);
                        if (tmp.length == 1) {
                            var element = tmp[0];
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
                }
            });
            $("#Doc_Allot_Oper").dialog('open');
        }
        function DoingBse_ComponentsToolBarView() {
            var grid = $('#DoingBse_Componentsgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据

            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            $.ajax({
                type: "post",
                url: "/Doc/Handle",
                dataType: "json",
                data: { code: data.Comp_Code },
                success: function(re, textStatus) {
                    //                $("#Doc_Attachmentgrid").trigger("reloadGrid");

                }
            });

            window.location = "/Comp/Show/" + data.Comp_Code + "?backUrl=/Comp/DoingComp";
        }

        function DoingBse_ComponentsToolBarSearch() {

            DoingBse_Components_DoingBse_ComponentsModule_GridControl.Search();
        }   
        
    </script>

    <script type="text/javascript">

        function AuditCompToolBarEdit() {
            var grid = $('#AuditCompgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            window.location = "/Comp/Correct/" + data.Comp_Code + "?backUrl=/Comp/DoingComp"
        }
    
        function AuditCompAudit() {
            var grid = $('#AuditCompgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据

            AuditInstance.Init("CompAudit", data.AuditCurAudit, data.Comp_Code, function(data1) {
                //如果已经通过审核则调用单据数据更新过程
                if (data1 == "LastAudit") {

                }

                $.ajax({
                    type: "post",
                    url: "/Comp/AuditCallback",
                    dataType: "json",
                    data: { code: data.Comp_Code },
                    success: function(re, textStatus) {
                        ShowMsg(re.Msg);
                    }
                });

                grid.trigger('reloadGrid');
            });
        }

       
   
        function AuditCompToolBarView() {
            var grid = $('#AuditCompgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            window.location = "/Comp/Show/" + data.Comp_Code + "?backUrl=/Comp/DoingComp";
        }

        function AuditCompToolBarSearch() {

            AuditComp_Bse_ComponentsModule_GridControl.Search();
        }   
    </script>


    <script type="text/javascript">
        $(document).ready(function() {

            $("#tabs").tabs();
        });
    </script>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
