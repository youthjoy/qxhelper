/// <reference path="../../jquery-1.4.1-vsdoc.js" />
Message_Operation =
{
    FormId: "FileInfo",
    Init: function(type) {
        var ooptions = {
            beforeSubmit: function(arr, $form, options) {
                // The array of form data takes the following form: 
                // [ { name: 'username', value: 'jresig' }, { name: 'password', value: 'secret' } ]
                var oEditor = FCKeditorAPI.GetInstance('content');

                // return false to cancel submit
                $("#Msg_Content").val(oEditor.GetHTML());
            },
            success: function(data) { if (data.result == "success") { alert(data.Msg); } else { alert("更新完成"); } },  // post-submit callback
            width: 800,
            timeout: 3000
        };

        //采购主表表单
        $("#" + Message_Operation.FormId).ajaxForm(ooptions);
        if (type != undefined && type == "edit") {
            Message_Operation.InitEdit();
        }
        else {
            Message_Operation.InitCreate();
        }
    },
    SaveDraft: function() {

        if (!$("#" + Message_Operation.FormId).validate().form()) {
            return false;
        }
        $("#" + Message_Operation.FormId).submit();
    },
    SaveData: function() {
        if (!$("#" + Message_Operation.FormId).validate().form()) {
            return false;
        }
        
        $("#optype").val("submit");
        var oEditor = FCKeditorAPI.GetInstance('content');
        $("#" + Message_Operation.FormId).submit();
    },
    CancelEdit: function() {

    },
    InitEdit: function() {


    },
    InitCreate: function() {

    }
}