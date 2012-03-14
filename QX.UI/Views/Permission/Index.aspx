<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Bse_Employee>" %>

<%@ OutputCache Duration="6000" VaryByParam="*" Location="Client" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <div class="left_tree" width="200px">
                    <%= Html.TreeView<QX.Model.Bse_Department>(
                        "dept",
                        ViewData["DeptList"] as IEnumerable<QX.Model.Bse_Department>,
                        d => d.ChildrenDept,
                        d => "<a id='"+d.Dept_Code+"'>" + d.Dept_Name + "</a>",
                        true,"",false,@"onselect : function(node,tree_obj){//节点单击事件   
                                                 
                  
                                }
         ")%>
                </div>
            </td>
            <td valign="top" style="width: 80%">
                <%=Html.GenToolbarHelper("Bse_EmployeeModule","Bse_Employee","addN:'权限分配',addFunJs:'Allot()'")%>
                <%=Html.SysComm_JqGrid("Bse_EmployeeModule","Bse_Employee","/Permission/GetEmpList",true )%>
            </td>
        </tr>
    </table>

    <script type="text/javascript">
        $(document).ready(function() {

            //数据控件事件绑定
            $("#dept").bind('click.jstree', function(event) {
                var eventNodeName = event.target.nodeName;

                if (eventNodeName == 'INS') {
                    return;
                } else if (eventNodeName == 'A') {
                    var $subject = $(event.target);
                    var deptcode = $subject.attr("id");
                    //读取数据的方法
                    $("#Bse_Employeegrid").setGridParam({ url: '/Permission/GetEmpList/' + deptcode }).trigger("reloadGrid");

                }
            });
        });

        function Bse_EmployeeAllot() {
            var grid = $('#Bse_Employeegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.Emp_Code == undefined) {
                ShowMsg("请选中要分配权限的人员!");
                return;
            }
            window.location = '/Permission/PerAllot/'+data.Emp_Code;
        }

        function Bse_EmployeeToolBarSearch() {

            Bse_Employee_Bse_EmployeeModule_GridControl.Search();
        }   

        
    </script>

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
