/// <reference path="../../jquery-1.4.1-vsdoc.js" />
Doc_Operation =
{
    FormId: "DocInfo",
    Init: function(type) {

        var ooptions = {
            beforeSubmit: function(arr, $form, options) {
                // The array of form data takes the following form: 
                // [ { name: 'username', value: 'jresig' }, { name: 'password', value: 'secret' } ]
                var oEditor = FCKeditorAPI.GetInstance('content');
                // return false to cancel submit
                $("#Doc_Content").val(oEditor.GetHTML());
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
            width: 800,
            dataType: 'json',
            timeout: 3000
        };

        //采购主表表单
        $("#" + Doc_Operation.FormId).ajaxForm(ooptions);
        if (type != undefined && type == "edit") {
            Doc_Operation.InitEdit();
        }
        else {
            Doc_Operation.InitCreate();
        }
    },
    SaveDraft: function() {

        if (!$("#" + Doc_Operation.FormId).validate().form()) {
            return false;
        }
        $("#" + Doc_Operation.FormId).submit();
    },
    CorrectData: function() {
        if (!$("#" + Doc_Operation.FormId).validate().form()) {
            return false;
        }
        $("#" + Doc_Operation.FormId).submit();
    },
    SaveData: function() {
        if (!$("#" + Doc_Operation.FormId).validate().form()) {
            return false;
        }
        $("#optype").val("submit");
        $("#" + Doc_Operation.FormId).submit();
    },
    CancelEdit: function() {

    },
    InitEdit: function() {


    },
    InitCreate: function() {

    }
}