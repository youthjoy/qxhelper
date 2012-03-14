/// <reference path="../../jquery-1.4.1-vsdoc.js" />
Supply_Operation =
{
    Init: function(type) {
        $("#tabs").tabs({ select: function(event, ui) {


            switch (ui.index) {
                case 1:
                    //设备
                    Supply_Shared_GridControl.Init("/Supply/EquList?id=" + $("#MV_CustCode").val(), "equ");
                    break;

            }

        }
        });
        if (type != undefined && type == "edit") {
            Supply_Operation.InitEdit();
        }
        else {
            Supply_Operation.InitCreate();
        }
    },
    InitEdit: function() {


    },
    InitCreate: function() {

    },
    InitGender: function() {

    }
}