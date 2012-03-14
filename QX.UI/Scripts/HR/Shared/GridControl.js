HR_Shared_GridControl = {
    setupFinanceGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/FinanceList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '员工编码', '原职位', '原工资', '现职位', '现工资', '说明', '备注'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                           { name: 'HM_ECode', index: 'HM_ECode', width: 100, align: 'center', sortable: false, hidden: true },
                        { name: 'HM_OTitle', index: 'HM_OTitle', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HM_OSalary', index: 'HM_OSalary', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HM_CTitle', index: 'HM_CTitle', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HM_CSalary', index: 'HM_CSalary', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HM_Content', index: 'HM_Content', width: 100, sortable: true, hidden: false },
                        { name: 'HM_Bak', index: 'HM_Bak', width: 100, align: 'center', sortable: false, hidden: false }
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
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/HR/HR_In/" + ret.HM_ECode + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp;";

                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be });
                }
            },
            userDataOnFooter: true
        }); //grid

    }, //考勤
    setupAttGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/AttList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '员工编码', '开始时间', '结束时间', '工时', '理由'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                         { name: 'TS_StuffCode', index: 'TS_StuffCode', width: 150, align: 'center', sortable: false, hidden: true },
                        { name: 'TS_Start', index: 'TS_Start', width: 150, align: 'center', sortable: false, hidden: false },
                        { name: 'TS_End', index: 'TS_End', width: 150, align: 'center', sortable: false, hidden: false },
                        { name: 'TS_Total', index: 'TS_Total', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'TS_Matter', index: 'TS_Matter', width: 100, align: 'center', sortable: false, hidden: false }
                      ],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortname: 'TS_Total',
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '员工考勤信息',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/HR/HR_TimeSheet/" + ret.TS_StuffCode + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>";
                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    //                    startDate = ParseUTCDate(ret.TS_Start);
                    grid.jqGrid('setRowData', ids[i], { Edit: be +del});

                    //                    grid.jqGrid('setRowData', ids[i], { TS_Start: startDate });
                }
            },
            userDataOnFooter: true
        }); //grid
    }, //奖惩
    setupAAGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/AAList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '员工编码', '员工姓名', '奖惩时间', '说明', '金额'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'AA_ECde', index: 'AA_ECde', width: 100, align: 'center', sortable: false, hidden: true },
                        { name: 'AA_EName', index: 'AA_EName', width: 100, align: 'center', sortable: false, hidden: true },
                        { name: 'AA_Date', index: 'AA_Date', width: 120, align: 'center', sortable: false, hidden: false },
                         { name: 'AA_Content', index: 'AA_Content', width: 200, align: 'center', sortable: false, hidden: false },
                        { name: 'AA_Sum', index: 'AA_Sum', width: 100, align: 'center', sortable: false, hidden: false }
                      ],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortname: 'AA_EName',
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '员工奖惩信息列表',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/HR/HR_AA/" + ret.AA_ECde + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>";
                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be +del});
                }
            },
            userDataOnFooter: true
        }); //grid
    }, //考评
    setupEvaGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/EvaluationList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '员工编码', '员工姓名', '考评日期', '考评记录', '考评总结', '考评人', '考评等级', '备注'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'Eva_StuffCode', index: 'Eva_StuffCode', width: 100, align: 'center', sortable: false, hidden: true },
                        { name: 'Eva_StuffName', index: 'Eva_StuffName', width: 100, align: 'center', sortable: false, hidden: true },
                        { name: 'Eva_Date', index: 'Eva_Date', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'Eva_Records', index: 'Eva_Records', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'Eva_Conclusion', index: 'Eva_Conclusion', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'Eva_Manager', index: 'Eva_Manager', width: 100, sortable: true, hidden: false },
                        { name: 'Eva_Level', index: 'Eva_Level', width: 60, align: 'center', sortable: false, hidden: false },
                         { name: 'Eva_Bak', index: 'Eva_Bak', width: 100, align: 'center', sortable: false, hidden: false }
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
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/HR/HR_Evaluation/" + ret.Eva_StuffCode + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp;";
                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be+del });
                }
            },
            userDataOnFooter: true
        }); //grid
    },
    //福利
    setupbeGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/BenefitList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '员工编码', '福利名称', '金额', '办理时间', '是否办理', '备注1'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                                { name: 'HRB_ECode', index: 'HRB_ECode', width: 100, align: 'center', sortable: false, hidden: true },
                        { name: 'HRB_Name', index: 'HRB_Name', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HRB_Sum', index: 'HRB_Sum', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HRB_IsDone', index: 'HRB_IsDone', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HRB_Date', index: 'HRB_Date', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'HRB_Bak1', index: 'HRB_Bak1', width: 100, sortable: true, hidden: false }
                      ],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortname: 'HRB_Name',
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '员工福利信息列表',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/HR/HR_Benefit/" + ret.HRB_ECode + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp;";
                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be +del});
                }
            },
            userDataOnFooter: true
        }); //grid
    }, //个人经历
    setupExGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/ExperienceList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作', '员工编码', '员工姓名', '经历单位', '经历职位', '简介', '开始时间', '结束时间', '备注'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_StuffCode', index: 'EX_StuffCode', width: 80, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_StuffName', index: 'EX_StuffName', width: 80, align: 'center', sortable: false, hidden: true },
                        { name: 'EXa_Corrp', index: 'EX_Corrp', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_Title', index: 'EX_Title', width: 80, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_Intro', index: 'EX_Intro', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_Start', index: 'EX_Start', width: 100, sortable: true, hidden: false },
                        { name: 'EXa_End', index: 'EX_End', width: 100, align: 'center', sortable: false, hidden: false },
                         { name: 'EXa_Bak', index: 'EX_Bak', width: 100, align: 'center', sortable: false, hidden: false }
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
            caption: '员工个人经历',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/HR/HR_Experience/" + ret.EX_StuffCode + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp;";
                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be+del });
                }
            },
            userDataOnFooter: true
        }); //grid
    },
    //个人教育经历
    setupEduExGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            //            url: "/HR/EduExperienceList?id=" + $("#Stuff_Code").val(),
            url: dataurl,
            mtype: "post",
            datatype: "json",
            colNames: ['操作','员工编码', '员工姓名', '学历', '专业', '简介', '开始时间', '结束时间', '备注'],
            colModel: [
                        { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_StuffCode', index: 'EX_StuffCode', width: 80, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_StuffName', index: 'EX_StuffName', width: 80, align: 'center', sortable: false, hidden: true },
                        { name: 'EXa_Corrp', index: 'EX_Corrp', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_Title', index: 'EX_Title', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_Intro', index: 'EX_Intro', width: 100, align: 'center', sortable: false, hidden: false },
                        { name: 'EXa_Start', index: 'EX_Start', width: 100, sortable: true, hidden: false },
                        { name: 'EXa_End', index: 'EX_End', width: 100, align: 'center', sortable: false, hidden: false },
                         { name: 'EXa_Bak', index: 'EX_Bak', width: 100, align: 'center', sortable: false, hidden: false }
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
            caption: '员工个人经历',
            footerrow: false,
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    //                be = "<input style='height:22px;' type='button' value='编辑' onclick=\"$('#grid').editRow('" + cl + "');\" />";

                    var ret = grid.jqGrid('getRowData', cl);
                    // var create = "<a href='Create'>添加</a>&nbsp;";

                    be = "<a href='/HR/HR_EduExperience/" + ret.EX_StuffCode + "'><img src='../../Content/images/edit1.png' border='0';alt='编辑' /></a>&nbsp;";
                    del = "<a href='#'><img src='../../Content/images/del.gif' border='0';alt='删除' /></a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: be+del });
                }
            },
            userDataOnFooter: true
        }); //grid
    },
    DataUrl: '',
    Init: function(dataurl, targetPreFix) {
        if (dataurl != undefined && dataurl != null) {
            HR_Shared_GridControl.DataUrl = dataurl;
        }
        //        else {
        //            HR_Shared_GridControl.DataUrl = "/HR/FinanceList?id=" + $("#Stuff_Code").val();
        //        }



        //财务
        //        HROperation.setupFinanceGrid($("#fingrid"), $("#finpager"), $("#finsearch"));



        switch (targetPreFix) {
            case "fin":
                HR_Shared_GridControl.setupFinanceGrid($("#fingrid"), $("#finpager"), $("#finsearch"), dataurl);
                break;
            case "att":
                HR_Shared_GridControl.setupAttGrid($("#attgrid"), $("#attpager"), $("#attsearch"), dataurl);
                break;
            case "ex":
                HR_Shared_GridControl.setupExGrid($("#exgrid"), $("#expager"), $("#exsearch"), dataurl);
                break;
            case "eva":
                //考评
                HR_Shared_GridControl.setupEvaGrid($("#evagrid"), $("#evapager"), $("#evasearch"), dataurl);
                break;
            case "aa":

                //奖惩
                HR_Shared_GridControl.setupAAGrid($("#aagrid"), $("#aapager"), $("#aasearch"), dataurl);
                break;
            case "be":
                //福利
                HR_Shared_GridControl.setupbeGrid($("#begrid"), $("#bepager"), $("#besearch"), dataurl);
            case "edu":
                //个人教育经历
                HR_Shared_GridControl.setupEduExGrid($("#edugrid"), $("#edupager"), $("#edusearch"), dataurl);
                break;
        }


    }
}


//function ParseUTCDate(milliseconds) {
//    var temp = milliseconds.split(/\D/);
//    eval("var temp = new Date(" + temp.join(",") + ")");
//}