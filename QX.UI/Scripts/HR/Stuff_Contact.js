/// <reference path="../../jquery-1.4.1-vsdoc.js" />


HR_Stuff_Contact = {
    setupGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: [ '员工编码', '员工名称', '英文名', '职务', '部门名称', '手机', '电子邮件'],
            colModel: [
              
                        { name: 'Stuff_Code', index: 'Stuff_Code', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Name', index: 'StuffName', width: 30, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_ENName', index: 'StuffENName', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Duty', index: 'StuffDuty', width: 20, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_DepName', index: 'Stuff_DepName', width: 50, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Mobile', index: 'Stuff_Mobile', width: 50, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Email', index: 'Stuff_Email', width: 50, align: 'center', sortable: false, hidden: false }

                      ],



            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortname: 'StuffName',
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '员工通信录列表',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    // var ret = grid.jqGrid('getRowData', cl);
                    //grid.jqGrid('setRowData', ids[i], { Edit: be });
                }
            },
            userDataOnFooter: true
        }); //grid

        $("#grid").navGrid('#pager', { refresh: true, edit: false, add: false, del: false, search: true });
    },
    AddPlan: function(newCode) {
        $("#stuff")[0].reset();
        //$("#TS_ID").val("0");
        //    $.ajax(
        //        {
        //            type: "post",
        //            url: "/HR/Stuff_ContactAdd",
        //            data: { id: newCode },
        //            dataType: "json",
        //            success: function(data, textStatus) {
        //                for (var p in data) {
        //                    $("#" + p).val(data[p]);
        //                }
        //            }
        //        });
        $("#finaceOperation").dialog("open");
    },
    InitEdit: function(code) {
        $.ajax(
        {
            type: "post",
            url: "/HR/Stuff_ContactEdit",
            data: { id: code },
            dataType: "json",
            success: function(data, textStatus) {
                for (var p in data) {
                    $("#" + p).val(data[p]);
                }
            }
        });
        $("#finaceOperation").dialog("open");
    },
    SaveEditData: function() {
    if (!$('#stuff').validate().form()) {
  
            return false;
        }

        else {
            $("#stuff").submit();
        }
    },
    AfterSaveEdit: function(data) {
        if (data == "success") {
            $("#finaceOperation").dialog("close");
            $("#grid").trigger("reloadGrid");
        }
        else {
            ShowMsg('提交失败!');
        }
    },
    CancelEdit: function() {
        $("#finaceOperation").dialog("close");
    },
    InitGrid: function(dataurl) {
        if (dataurl == undefined) {
            dataurl = "/HR/StuffContactList/";
        }
        else {
            HR_Stuff_Contact.setupGrid($("#grid"), $("#pager"), $("#search"), dataurl);
        }
    }
};
