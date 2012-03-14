var WH_MaterialTypeModule_GridControl = {
    setupGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            url: dataurl,
            mtype: 'post',
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortorder: 'asc',
            viewrecords: true,
            multiselect: true, //多选时出fre现checkbox
            width: '800',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            hiddengrid: false,
            caption: '',
            footerrow: false,
            editurl: '',
            colNames: ['序列号', '编码', '类别编码', '类别名称', '所属公司', '公司编码', '部门名称', '部门编码', '是否有效','采购员','采购员'],
            colModel: [{ name: 'MT_ID', index: 'MT_ID', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_Code', index: 'MT_Code', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_TCode', index: 'MT_TCode', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_TName', index: 'MT_TName', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_Company', index: 'MT_Company', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_CompanyCode', index: 'MT_CompanyCode', width: 100, align: 'center', sortable: true, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_Dept', index: 'MT_Dept', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_DeptCode', index: 'MT_DeptCode', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_Status', index: 'MT_Status', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_Employee', index: 'MT_Employee', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
{ name: 'MT_EmployeeName', index: 'MT_EmployeeName', width: 100, align: 'center', sortable: false, hidden: true, searchoptions: { sopt: ['eq', 'ne', 'cn']} },
],
            gridComplete: function() {
                $("#jqgh_cb").hide();
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var data = grid.getRowData(cl);

                    if (data.MT_Status == "true") {
                        $("#jqg_grid_" + cl).attr("checked", true);
                        //grid.setSelection(cl);
                    } else {
                        $("#jqg_grid_" + cl).attr("checked", false);
                    }
                }
            },
            onSelectRow: function(rowid, status) {                
                var data = grid.getRowData(rowid);                             
                //var IsCheck = $("#jqg_grid_" + rowid).attr("checked");
                //var SelectCheckBox = IsCheck ? false : true;
                $("#jqg_grid_" + rowid).attr("checked", status);
                if (data != undefined) {
                    $.ajax({
                        url: '/TypeOp/OPType/' + data.MT_Code,
                        type: 'post',
                        data: { stat: status,company:$("#MT_CompayCode").val() },
                        success: function(result) {

                        }
                    });
                }
            },
            userDataOnFooter: true
        })
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search';
        WH_MaterialTypeModule_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
        $('#' + gridobj).navGrid('#' + pagerobj, { refresh: true, edit: false, add: false, del: false, search: false });
    }
}