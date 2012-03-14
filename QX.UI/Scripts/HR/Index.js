/// <reference path="../../jquery-1.4.1-vsdoc.js" />


HR_List = {
    setupGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '员工编码', '员工名称', '英文名', '职务', '职称', '直接上级', '部门名称', '手机', '电子邮件'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 40, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Code', index: 'Stuff_Code', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Name', index: 'StuffName', width: 30, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_ENName', index: 'StuffENName', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Duty', index: 'StuffDuty', width: 20, align: 'center', sortable: false, hidden: false },
                        { name: 'Stuff_Title', index: 'Stuff_Title', width: 30, sortable: true, hidden: false },
                        { name: 'Stuff_DepName', index: 'Stuff_DepName', width: 50, align: 'center', sortable: false, hidden: false },
                         { name: 'Stuff_Director', index: 'Stuf_Director', width: 40, align: 'center', sortable: false, hidden: false },
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
            caption: '员工信息列表',
            footerrow: false,
            emptyrecords: "暂无相关信息",
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
        //        search.filterGrid("#" + grid.attr("id"), {
        //            gridModel: false,
        //            filterModel: [{
        //                label: 'Search',
        //                name: 'search',
        //                stype: 'text'
        //}]
        //            });//search

    },
    InitGrid: function(dataurl) {
        if (dataurl == undefined) {
            dataurl = "/HR/List/";
        }
        else {
            HR_List.setupGrid($("#grid"), $("#pager"), $("#search"), dataurl);
        }
    }
};
