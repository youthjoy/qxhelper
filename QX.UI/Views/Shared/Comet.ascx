<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<script type="text/javascript">
    $(document).ready(function() {
        setTimeout(Comet, 10000);
    });

    function Comet() {
        //        $("#btn").bind("click", { btn: $("#btn") }, function(evdata) {
        $.ajax({
            type: "POST",
            dataType: "json",
            url: "/Home/GetMsg",
            timeout: 80000,     //ajax请求超时时间80秒      
            data: { time: "80" }, //40秒后无论结果服务器都返回数据
            success: function(data, textStatus) {
                try {
                    //从服务器得到数据，显示数据并继续查询      
                    if (data.success == "1") {
                        FormMesage.Show(data.result);
                        setTimeout(Comet, 60000);
                    }
                    //未从服务器得到数据，继续查询      
                    if (data.success == "0") {
                        alert(111);
                        setTimeout(Comet, 100000);
                    }
                } catch (e) { alert(e); }


            },
            //Ajax请求超时，继续查询      
            error: function(XMLHttpRequest, textStatus, errorThrown) {
                if (textStatus == "timeout") {
                    alert("超时");
                    setTimeout(Comet, 100000);
                }
            }

        });
        //        });      
    }
</script>

