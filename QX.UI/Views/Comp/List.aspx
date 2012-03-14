<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    所有图纸
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

  
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">图纸列表</a></li>
        </ul>
        <div id="tabs-1">
            <table style="width: 100%">
                <tr>
                    <td>
                        <div style=' background: none repeat scroll 0 0 white;
    border: 1px solid #B2CDD2;
    margin-bottom: 30px;
    margin-left: 1px;
    margin-right: 5px;
    overflow: auto;
    padding-left: 5px;
    padding-top: 5px;
    width: 350px;'>
                            <%= Html.TreeView<QX.Model.TheTreeNode>(
                        "dept",
                        ViewData["DeptList"] as IEnumerable<QX.Model.TheTreeNode>,
                                                d => d.childrenenum,
                        d => "<a id='"+d.state+"' parent='"+d.parent+"' >" + d.data + "</a>")%>
                        </div>
                    </td>
                    
                    <td valign="top" style="width: 80%">
                        <%=Html.GenToolbarHelper("AllBse_ComponentsModule", "DoneBse_Components", "viewN:'查看'")%>
                        <%=Html.SysComm_JqGrid("AllBse_ComponentsModule", "DoneBse_Components", "/Comp/GetCompListByCust", true)%>
                    </td>
                </tr>
            </table>
        </div>
    </div>

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
                    var p = $subject.attr("parent");

                    //读取数据的方法
                    $("#DoneBse_Componentsgrid").setGridParam({ postData: { parent: p} }).setGridParam({ url: '/Comp/GetCompListByCust/' + deptcode }).trigger("reloadGrid");
                }
            });
        });

  
   
        
    </script>

    <script type="text/javascript">

        function DoneBse_ComponentsToolBarView() {
            var grid = $('#DoneBse_Componentsgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            window.location = "/Comp/Show/" + data.Comp_Code + "?backUrl=/Comp/List";
        }

        function DoneBse_ComponentsToolBarSearch() {

            DoneBse_Components_Bse_ComponentsModule_GridControl.Search();
        }   
    </script>
  <script type="text/javascript">
      $(document).ready(function() {
          $("#tabs").tabs();
      });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/jquery.tips.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/ComOperation.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
