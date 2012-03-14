Equ_Shared_GridControl = {
    setupMRGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/FinanceList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '设备名称', '检修开始时间', '检修结束时间', '故障模式', '更换零件说明', '检修人', '备注'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MR_EName', index: 'MR_EName', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MR_Start', index: 'MR_Start', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MR_End', index: 'MR_End', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MR_FType', index: 'MR_FType', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'MR_Content', index: 'MR_Content', width: 100, sortable: true, hidden: false },
                        { name: 'MR_MStuff', index: 'MR_MStuff', width: 100, align: 'center', sortable: false, hidden: false },
                      { name: 'MR_Bak', index: 'MR_Bak', width: 100, align: 'center', sortable: false, hidden: false }
                      ],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortname: 'MR_EName',
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '设备检修记录',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='Edit/" + ret.Stuff_Code + "'>编辑</a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be });
                }
            },
            userDataOnFooter: true
        }); //grid
    },
    Init: function(dataurl, targetPreFix) {
        //        if (dataurl != undefined && dataurl != null) {
        //            Equ_Shared_GridControl.DataUrl = dataurl;
        //        }

        switch (targetPreFix) {
            case "mr":
                Equ_Shared_GridControl.setupMRGrid($("#mrgrid"), $("#mrpager"), $("#mrsearch"), dataurl);
                break;
        }


    }
}


//function ParseUTCDate(milliseconds) {
//    var temp = milliseconds.split(/\D/);
//    eval("var temp = new Date(" + temp.join(",") + ")");
//}