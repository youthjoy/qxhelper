/// <reference path="../../jquery-1.4.1-vsdoc.js" />
$(document).ready(function() {
    //数据控件事件绑定
    $("#Menu").bind('click.jstree', function(event) {
        var eventNodeName = event.target.nodeName;
    })
});
MenusOperation =
{
    Init: function(type) {
        $("#tabs").tabs();
        if (type != undefined && type == "edit") {
            MenusOperation.InitEdit();
        }
        else {
            MenusOperation.InitCreate();
        }
    },
    InitEdit: function() {
    },
    InitCreate: function() {
    },
    InitGender: function() {
    }
}