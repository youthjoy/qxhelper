/// <reference path="../../jquery-1.4.1-vsdoc.js" />
Comp_Operation =
{
    FormId: "CompInfo",
    Init: function(type) {

        var ooptions = {
            beforeSubmit: function(arr, $form, options) {
                // The array of form data takes the following form: 
                // [ { name: 'username', value: 'jresig' }, { name: 'password', value: 'secret' } ]
                var oEditor = FCKeditorAPI.GetInstance('content');
                // return false to cancel submit
                $("#Comp_Content").val(oEditor.GetHTML());
            },
            success: function(data) {

                if (data.result == "success") {
                    ShowMsg(data.Msg);
                    if (data.isBack == undefined || data.isBack == 1) {
  
                        ComOperation.CancelEdit();
                    }

                }
                else {
                    ShowMsg(data.Msg);
                }
            },  // post-submit callback
            dataType: 'json'
        };

        //采购主表表单
        $("#" + Comp_Operation.FormId).ajaxForm(ooptions);
        if (type != undefined && type == "edit") {
            Comp_Operation.InitEdit();
        }
        else {
            Comp_Operation.InitCreate();
        }
    },
    SaveDraft: function() {

        if (!$("#" + Comp_Operation.FormId).validate().form()) {
            return false;
        }
        $("#" + Comp_Operation.FormId).submit();
    },
    CorrectData: function() {
        if (!$("#" + Comp_Operation.FormId).validate().form()) {
            return false;
        }
        $("#" + Comp_Operation.FormId).submit();
    },
    SaveData: function() {
        if (!$("#" + Comp_Operation.FormId).validate().form()) {
            return false;
        }
        $("#optype").val("submit");
        $("#" + Comp_Operation.FormId).submit();
    },
    InitEdit: function() {


    },
    CancelEdit: function() {

    },
    InitCreate: function() {

    }
}