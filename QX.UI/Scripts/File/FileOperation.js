/// <reference path="../../jquery-1.4.1-vsdoc.js" />
File_Operation =
{
    FormId: "FileInfo",
    Init: function(type) {
        var ooptions = {
            beforeSubmit: function(arr, $form, options) {
                // The array of form data takes the following form: 
                // [ { name: 'username', value: 'jresig' }, { name: 'password', value: 'secret' } ]
                var oEditor = FCKeditorAPI.GetInstance('content');
                // return false to cancel submit
                $("#CF_Bak").val(oEditor.GetHTML());
            },
            success: function(data) {

                if (data.result == "success") {
                    ShowMsg(data.Msg);
                    if (data.isBack == undefined || data.isBack == 1) {
                        ComOperation.CancelEdit();
                    }
                }
                else {
                    ShowMsg("网络连接异常!");
                }
            },  // post-submit callback
            dataType: 'json',
            timeout: 3000
        };

        //采购主表表单
        $("#" + File_Operation.FormId).ajaxForm(ooptions);
        if (type != undefined && type == "edit") {
            File_Operation.InitEdit();
        }
        else {
            File_Operation.InitCreate();
        }
    },
    SaveDraft: function() {

        if (!$("#" + File_Operation.FormId).validate().form()) {
            return false;
        }
        $("#" + File_Operation.FormId).submit();
    },
    CorrectData: function() {
        if (!$("#" + File_Operation.FormId).validate().form()) {
            return false;
        }
        $("#" + File_Operation.FormId).submit();
    },
    SaveData: function() {
        if (!$("#" + File_Operation.FormId).validate().form()) {
            return false;
        }
        $("#optype").val("submit");
        $("#" + File_Operation.FormId).submit();
    },
    CancelEdit: function() {

    },
    InitEdit: function() {


    },
    InitCreate: function() {

    }
}