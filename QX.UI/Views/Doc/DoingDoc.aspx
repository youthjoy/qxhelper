<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    待办
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">待核列表</a></li>
            <li><a href="#tabs-2">待办列表</a></li>
            <li><a href="#tabs-3">待审列表</a></li>
        </ul>
         <div id="tabs-1">
            <%=Html.GenToolbarNoPermissionHelper("CList_DoingDocInfo", "DoingCCDoc_Info", "addN:'处理',addFunJs:'Handle()',viewN:'查看'")%>
            <%=Html.SysComm_JqGrid("CList_DoingDocInfo", "DoingCCDoc_Info", "/Doc/GetCCDoingList", true)%>
        </div>
        
        <div id="tabs-2">
            <%=Html.GenToolbarHelper("CList_DoingDocInfo", "DoingDoc_Info", "addN:'处理',addFunJs:'Handle()',viewN:'查看'")%>
            <%=Html.SysComm_JqGrid("CList_DoingDocInfo","DoingDoc_Info","/Doc/GetDoingList",true) %>
        </div>
        <div id="tabs-3">
            <%=Html.GenToolbarNoPermissionHelper("CList_DocInfo", "AuditDoc_Info", "addN:'审核',addFunJs:'Audit()',editN:'查看修订'")%>
            <%=Html.SysComm_JqGrid("CList_DocInfo", "AuditDoc_Info", "/Doc/GetAuditList", true)%>
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
   

    //处理
    function DoingCCDoc_InfoHandle() {

        var grid = $('#DoingCCDoc_Infogrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据
        if (data.Doc_Code == undefined) {
            ShowMsg("请选中要操作的数据行！");
            return;
        }
        $.ajax({
            type: "post",
            url: "/Doc/GetAllotModel",
            dataType: "json",
            data: { code: data.Doc_Code, module: "CList_DocInfo" },
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


    function DoingCCDoc_InfoToolBarView() {
        var grid = $('#DoingCCDoc_Infogrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据            
        if (data.Doc_Code == undefined) {
            ShowMsg('请选中编辑行');
            return;
        }

        $.ajax({
            type: "post",
            url: "/Doc/Handle",
            dataType: "json",
            data: { code: data.Doc_Code },
            success: function(re, textStatus) {
                //                $("#Doc_Attachmentgrid").trigger("reloadGrid");

            }
        });

        window.location = "/Doc/Show/" + data.Doc_Code + "?backUrl=/Doc/DoingDoc";
    }

    function DoingDoc_InfoToolBarSearch() {

        DoingDoc_Info_CList_DoingDocInfo_GridControl.Search();
    }   
    </script>
    <script type="text/javascript">
        //待处理
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
        function DoingDoc_InfoHandle() {

            var grid = $('#DoingDoc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.Doc_Code == undefined) {
                ShowMsg("请选中要操作的数据行！");
                return;
            }
            $.ajax({
                type: "post",
                url: "/Doc/GetAllotModel",
                dataType: "json",
                data: { code: data.Doc_Code, module: "CList_DocInfo" },
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


        function DoingDoc_InfoToolBarView() {
            var grid = $('#DoingDoc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Doc_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            $.ajax({
                type: "post",
                url: "/Doc/Handle",
                dataType: "json",
                data: { code: data.Doc_Code },
                success: function(re, textStatus) {
                    //                $("#Doc_Attachmentgrid").trigger("reloadGrid");

                }
            });

            window.location = "/Doc/Show/" + data.Doc_Code + "?backUrl=/Doc/DoingDoc";
        }

        function DoingDoc_InfoToolBarSearch() {

            DoingDoc_Info_CList_DoingDocInfo_GridControl.Search();
        }   
    </script>

    <script type="text/javascript">
        //待审核
    
          function AuditDoc_InfoAudit() {
            var grid = $('#AuditDoc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据

            AuditInstance.Init("DocumentAudit", data.AuditCurAudit, data.Doc_Code, function(data1) {
                //如果已经通过审核则调用单据数据更新过程
                if (data1 == "LastAudit") {

                }
                grid.trigger('reloadGrid');
            });

        }

        function AuditDoc_InfoToolBarEdit() {
            var grid = $('#AuditDoc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Doc_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            window.location = "/Doc/Correct/" + data.Doc_Code + "?backUrl=/Doc/DoingDoc"
        }


        function AuditDoc_InfoToolBarSearch() {

            AuditDoc_Info_CList_DoingDocInfo_GridControl.Search();
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
