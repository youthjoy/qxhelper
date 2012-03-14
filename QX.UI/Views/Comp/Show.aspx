<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Bse_Components>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    show
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="CompInfo" method='post' action="/Comp/CompOperation">
    <fieldset class="DocmentsWidth">
        <legend>零件图纸维护</legend>
        <input type="hidden" id="formOper" value="edit" name="formOper" />
        <input type="hidden" id="optype" value="nor" name="optype" />
        <%=Html.AutoBindForm<QX.Model.Bse_Components>("Bse_ComponentsModule", "Bse_Components", Model, false, false, false)%>
    </form>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">正文</a></li>
            <li><a href="#tabs-2">附件</a></li>
            <li><a href="#tabs-3">授权</a></li>
         
        </ul>
        <div id="tabs-1">
            <%Html.RenderPartial("FCKEditor", string.IsNullOrEmpty(Model.Comp_Content)?"":Model.Comp_Content); %>
        </div>
        <div id="tabs-2">
            <%=Html.SysComm_JqGrid("Doc_AttachmentModule", "Doc_Attachment", "/Doc/GetAttachmentList/"+Model.Comp_Code+"-Bse_ComponentsModule", true)%>
        </div>
        <div id="tabs-3">
            <%=Html.GenToolbarHelper("CompDoc_AllotModule", "Doc_Allot", "addN:''")%>
            <%=Html.SysComm_JqGrid("CompDoc_AllotModule", "Doc_Allot", "/Doc/GetAllot/"+Model.Comp_Code, true)%>
        </div>
     <%--   <div id="tabs-4">
            <%=Html.GenToolbarHelper("Bse_CompHistoryModule", "Bse_CompHistory", "addN:'打印',addFunJs:'Print()'")%>
            <%=Html.SysComm_JqGrid("Bse_CompHistoryModule", "Bse_CompHistory", "/Comp/GetCompHisList/" + Model.Comp_Code, true)%>
        </div>--%>
    </div>
    <div class="FormToolBar">
        <input type='button' name='cancle' value='返回' onclick='ComOperation.CancelEdit()' />
    </div>
    <%=Html.AutoBindValidate("Bse_ComponentsModule", "CompInfo")%>
    </fieldset>

    <script type="text/javascript">
        function GetbackUrl() {
            var backUrl = '<%=ViewData["backUrl"]%>';
            return backUrl;
        }

        function Doc_AllotAllot() {

        }

        function Bse_CompHistoryPrint() {
            var grid = $('#Bse_CompHistorygrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            if (curid == undefined || curid == null) {
                return;
            }
            var data = grid.getRowData(curid);
            var pri = window.open(data.CH_FilePath);
            //var pri = window.open("test.html");
            pri.print();
            pri.close();
        }

        $(document).ready(function() {
            Comp_Operation.Init();
            $("#tabs").tabs();


        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    <link href="/Content/css/jquery.multiselect.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/Shared/jquery.multiselect.min.js" type="text/javascript"></script>
<script src="/Scripts/Shared/Dict_ERP.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
