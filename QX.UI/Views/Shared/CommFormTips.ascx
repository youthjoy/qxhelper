<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div id="CommMessage" title="信息提问" style="width: 250px; height: 150px;">
    <p id="CommMessageBody" class="msgbody"">
    </p>
</div>

<script type="text/javascript">

    $(document).ready(function() {
   
        $('#CommMessage').dialog({
            autoOpen: false,
            width: 250,
            minWidth: 250,
            modal: false,
            show: "slide",
            position: [document.body.offsetWidth - 255, window.screen.Height - 155],
            close: function() {

            }
        });
    });

    var FormMesage = {
        Show: function(msg) {
            $("#CommMessageBody").html(msg);
            $('#CommMessage').dialog('open');
            setTimeout(FormMesage.Close,30000);
        },
        Close:function(){
           $('#CommMessage').dialog('close');
        }
    }

   

   

</script>

