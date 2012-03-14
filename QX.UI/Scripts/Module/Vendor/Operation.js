/// <reference path="../../jquery-1.4.1-vsdoc.js" />
VendorOperation =
{
    Init: function(type) {
        
        $("#tabs").tabs({ select: function(event, ui) {

            switch (ui.index) {
                case 0:
                    //供应商评审
                    WH_CEItem_GridControl.Init("/Vendor/CEItemList?id=" + $("#MV_CustCode").val(), "ps");
                    //WH_CEItem_GridControl.Init("/Vendor/CEItemList?id=" + $("#EquInfo_Code").val(), "mr");                    
                    break;
                case 1:
                    WH_Invoice_GridControl.Init("/Vendor/InvoiceList?id=" + $("#MV_CustCode").val(), "fp");
                    break;
                case 2:
                    break;
                case 3:
                    WH_Contract_GridControl.Init("/Vendor/ContractList?id=" + $("#MV_CustCode").val(), "ht");
                    break;
            }

        }
        });
        //        if (type != undefined && type == "edit") {
        //            Equ_Operation.InitEdit();
        //        }
        //        else {
        //            Equ_Operation.InitCreate();
        //        }
    },
    InitEdit: function() {


    },
    InitCreate: function() {

    },
    InitGender: function() {

    }
}