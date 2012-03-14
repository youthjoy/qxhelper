<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    View
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <input type="button" value="打印" onclick="preview(1)" />
    <br />
    <!--startprint1-->
    <img src='/Comp/GetPic/<%=ViewData["File"] %>' alt="图纸文件"/>
    <!--endprint1-->

    <script type="text/javascript">
        $(document).ready(function() {
            $(document).bind("contextmenu", function(e) {
                return false;
            });
        });

        function preview(oper) {
            if (oper < 10) {
                bdhtml = window.document.body.innerHTML; //获取当前页的html代码
                sprnstr = "<!--startprint" + oper + "-->"; //设置打印开始区域
                eprnstr = "<!--endprint" + oper + "-->"; //设置打印结束区域
                prnhtml = bdhtml.substring(bdhtml.indexOf(sprnstr) + 18); //从开始代码向后取html

                prnhtml = prnhtml.substring(0, prnhtml.indexOf(eprnstr)); //从结束代码向前取html
                window.document.body.innerHTML = prnhtml;
                window.print();
                window.document.body.innerHTML = bdhtml;

            } else {
                window.print();
            }

        } 

    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
