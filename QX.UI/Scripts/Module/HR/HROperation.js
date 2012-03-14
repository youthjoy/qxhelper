/// <reference path="../../jquery-1.4.1-vsdoc.js" />
HROperation =
{
    Init: function(type) {
        $("#tabs").tabs({ select: function(event, ui) {

            switch (ui.index) {
                case 1:
                    //财务
                    HR_Shared_GridControl.Init("/HR/FinanceList?id=" + $("#Stuff_Code").val(), "fin");
                    break;
                case 2:
                    //考勤
                    HR_Shared_GridControl.Init("/HR/AttList?id=" + $("#Stuff_Code").val(), "att");
                    break;
                case 3:
                    //考评
                    HR_Shared_GridControl.Init("/HR/EvaluationList?id=" + $("#Stuff_Code").val(), "eva");
                    break;
                case 4:
                    //奖惩
                    HR_Shared_GridControl.Init("/HR/AAList?id=" + $("#Stuff_Code").val(), "aa");
                    break;
                case 5:

                    //福利
                    HR_Shared_GridControl.Init("/HR/BenefitList?id=" + $("#Stuff_Code").val(), "be");
                    break;
                case 6:
                    //个人经历
                    HR_Shared_GridControl.Init("/HR/ExperienceList?id=" + $("#Stuff_Code").val(), "ex");
                    break;
                case 7:
            
                    HR_Shared_GridControl.Init("/HR/EduExperienceList?id=" + $("#Stuff_Code").val(), "edu");
                    break;
            }

        }
        });
        if (type != undefined && type == "edit") {
            HROperation.InitEdit();
        }
        else {
            HROperation.InitCreate();
        }
    },
    InitEdit: function() {





        //考勤
        //        HROperation.setupAttGrid($("#attgrid"), $("#attpager"), $("#attsearch"));
        //个人经历
        //        HROperation.setupExGrid($("#exgrid"), $("#expager"), $("#exsearch"));
        //        //考评
        //        HROperation.setupEvaGrid($("#evagrid"), $("#evapager"), $("#evasearch"));
        //        //奖惩
        //        HROperation.setupAAGrid($("#aagrid"), $("#aapager"), $("#aasearch"));
        //        //财务
        //        //        HROperation.setupFinanceGrid($("#fingrid"), $("#finpager"), $("#finsearch"));
        //        //福利
        //        HROperation.setupbeGrid($("#begrid"), $("#bepager"), $("#besearch"));

    },
    InitCreate: function() {

    },
    InitGender: function() {

    }
}