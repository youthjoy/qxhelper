/// <reference path="../../jquery-1.4.1-vsdoc.js" />
$(document).ready(function() {
    Equ_Index.setupGrid($("#grid"), $("#pager"), $("#search"));
});

Equ_Index = {
    setupGrid: function(grid, pager, search) {
        grid.jqGrid({
            url: "/Supply/List",
            mtype: "post",
            datatype: "json",
            colNames: ['操作','供应商编码', '供应商名称', '供应商性质', '供应商资质', '法人代表', '联系人', '座机', '手机', '传真', '电子邮件', '供应商网址', '邮编', '介绍'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 40, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_CustCode', index: 'MV_CustCode', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_CustName', index: 'MV_CustName', width: 30, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_Property', index: 'MV_Property', width: 25, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_Aptitude', index: 'MV_Aptitude', width: 20, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_LegalPerson', index: 'MV_LegalPerson', width: 30, sortable: true, hidden: false },
                        { name: 'MV_ContactPerson', index: 'MV_ContactPerson', width: 40, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_Telphone', index: 'MV_Telphone', width: 50, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_MobilePhone', index: 'MV_MobilePhone', width: 50, align: 'center', sortable: false, hidden: false },
                        { name: 'MV_Fax', index: 'MV_Fax', width: 50, align: 'center', sortable: false, hidden: false },
                  { name: 'MV_Email', index: 'MV_Email', width: 50, align: 'center', sortable: false, hidden: false },
                          { name: 'MV_Site', index: 'MV_Site', width: 50, align: 'center', sortable: false, hidden: false },
                  { name: 'MV_ZipCode', index: 'MV_ZipCode', width: 50, align: 'center', sortable: false, hidden: false },
                   { name: 'MV_Introduction', index: 'MV_Introduction', width: 50, align: 'center', sortable: false, hidden: false }
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
                    var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/Supply/Edit/" + ret.MV_CustCode + "'>编辑</a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: create + be });
                }
            },
            userDataOnFooter: true
        }); //grid


    }
};