Supply_Shared_GridControl = {
    setupequGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '设备编码', '设备名称', '厂内编码', '条形码', '型号', '生产厂家', '使用部门名称', '随主机附件', '随机技术资料', '主要技术参数', '放置地点', '购买成本', '折旧状态'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 40, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_Code', index: 'EquInfo_Code', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_Name', index: 'EquInfo_Name', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_ICode', index: 'EquInfo_ICode', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_TCode', index: 'EquInfo_TCode', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_Spec', index: 'EquInfo_Spec', width: 100, sortable: true, hidden: false },
                        { name: 'EquInfo_Manu', index: 'EquInfo_Manu', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_DeptName', index: 'EquInfo_DeptName', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_PartInfo', index: 'EquInfo_PartInfo', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EquInfo_TechInfo', index: 'EquInfo_TechInfo', width: 100, align: 'center', sortable: false, hidden: false },
                  { name: 'EquInfo_TechVar', index: 'EquInfo_TechVar', width: 100, align: 'center', sortable: false, hidden: false },
                          { name: 'EquInfo_Addr', index: 'EquInfo_Addr', width: 100, align: 'center', sortable: false, hidden: false },
                  { name: 'EquInfo_Cost', index: 'EquInfo_Cost', width: 100, align: 'center', sortable: false, hidden: false },
                    { name: 'EquInfo_IsFix', index: 'EquInfo_IsFix', width: 100, align: 'center', sortable: false, hidden: false }
                      ],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortname: 'EquInfo_Code',
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '设备信息列表',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
//                    var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/Equ/Edit/" + ret.EquInfo_Code + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>";
                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit:  be+del });
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
            case "equ":
                Supply_Shared_GridControl.setupequGrid($("#equgrid"), $("#equpager"), $("#equsearch"), dataurl);
                break;
        }


    }
}


//function ParseUTCDate(milliseconds) {
//    var temp = milliseconds.split(/\D/);
//    eval("var temp = new Date(" + temp.join(",") + ")");
//}