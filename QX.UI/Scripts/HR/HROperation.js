/// <reference path="../../jquery-1.4.1-vsdoc.js" />
HROperation =
{
    Init: function(type) {
        $("#tabs").tabs({ select: function(event, ui) {

            switch (ui.index) {
                case 1:
                    //财务
                    HR_Shared_GridControl.Init("/HR/FinanceList?type=" + $("#Stuff_Code").val(), "fin");
                    break;
                case 2:
                    //考勤
                    HR_Shared_GridControl.Init("/HR/AttList?type=" + $("#Stuff_Code").val(), "att");
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
                    HR_Exxperience_GridControl.Init("/HR/ExperienceList?id=" + $("#Stuff_Code").val(), "ex");
                    break;
                case 7:
                    //教育
                    HR_EduSSExperience_GridControl.Init("/HR/ExperienceListJY?id=" + $("#Stuff_Code").val(), "edu");
                    break;
            }
        }
        });
        if (type != undefined && type == "edit") {
            HROperation.InitEdit();
        }
        else if (type == "create") {
            HROperation.InitCreate();
        }
    },
    InitEdit: function() {

    },
    InitCreate: function() {
        Common_Select_Dict.Init($("#Stuff_Gender"), "Gender");
        Common_Tree_Dept.Init("Stuff_DepName", function(code, name) { $("#Stuff_DepName").val(name); $("#Stuff_DepCode").val(code); });
    },
    InitGender: function() {

    }
}