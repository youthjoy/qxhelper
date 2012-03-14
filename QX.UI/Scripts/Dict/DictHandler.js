var Dict_DictHandler =
{
    thisTree: null,
    thisForm: null,
    CurSelNode: null,
    CurNode: null,
    hasNewNode: false,
    InitAddDictEvent: function() {
        if (Dict_DictHandler.CurSelNode != null) {
            Dict_DictHandler.thisTree.jstree("create", null, "last", { "attr": { "rel": "folder"} }, function() { }, true);
        }
        else {
            ShowMsg("请选择要添加的子节点");
        }

    }, //初始化添加数据
    InitAddDict: function(obj) {
        Dict_DictHandler.BindForm(obj);

    }, //绑定表单数据
    BindForm: function(jsonData) {
        for (var d in jsonData) {
            var $obj = $("#" + d)
            if ($obj.length != 0) {
                $obj.val(jsonData[d]);
            }
        }
    }, //
    AfterOperation: function(data) {
        if (data.result == "success") {
            var SearchNode = data.target.Dict_Code;
            if (Dict_DictHandler.hasNewNode) {
                SearchNode = "temp_" + SearchNode;                
            }
            Dict_DictHandler.thisTree.jstree("set_text", $("#" + SearchNode), data.target.Dict_Name);
            Dict_DictHandler.thisForm[0].reset();
            Dict_DictHandler.hasNewNode = false;
            ShowMsg("提交信息成功！");

        }
    }, //编辑事件初始化
    InitEditDictEvent: function() {
        //        ShowMsg(Dict_DictHandler.CurSelNode.attr("id"));
        if (Dict_DictHandler.CurSelNode != null) {
            var code = Dict_DictHandler.CurSelNode.attr("id");
            Dict_DictHandler.GetEditData(code);

        }
    },
    GetEditData: function(code) {
        $.ajax({
            type: "post",
            url: "/Dict/GetNode",
            data: { nodeCode: code, nodeKey: Itype },
            success: function(re, textStatus) {
                if (re != null && re.result == "success") {
                    Dict_DictHandler.InitEditDict(re.data);
                    //                        Dict_DictHandler.BindForm(re);
                }
                else {
                    ShowMsg("获取数据失败!");
                }
            }
        });
    },
    //初始化编辑数据
    InitEditDict: function(re) {
        Dict_DictHandler.BindForm(re);
    }, //删除树控件节点事件
    DelDictEvent: function() {
        Dict_DictHandler.thisTree.jstree("remove");
    },
    Save: function() {
        if (!Dict_DictHandler.thisForm.validate().form()) {
            return false;
        }
        //$(".err_display").removeClass();
        if ($("#Dict_Code").val() == "" || $("#Dict_Code").val() == null) {
            ShowMsg("数据有误");
            return;
        }
        Dict_DictHandler.thisForm.submit();

    },
    Cancel: function() {
        location = location;
    },
    NewNodeCode: null,
    //是否允许多层级
    IsLevel: false,
    Init: function(isLevel) {
        if (isLevel != undefined || isLevel != 0) {
            Dict_DictHandler.IsLevel = true;
        }

        //树控件
        Dict_DictHandler.thisTree = $("#DictList");
        //表单控件
        Dict_DictHandler.thisForm = $("#dictform");

        $("#Dict_Code").change(function() {
            if (Dict_DictHandler.NewNodeCode != null) {
                var val = $(this).val();
                var $dict = $("#" + Dict_DictHandler.NewNodeCode);
                $dict.attr("id", val);
                Dict_DictHandler.NewNodeCode = val;
                //                var node = Dict_DictHandler.thisTree.jstree("_get_node", Dict_DictHandler.NewNodeCode);

                //                var node1 = Dict_DictHandler.thisTree.jstree("_get_node",$("#"+ Dict_DictHandler.NewNodeCode));
                //                $obj = $("#" + );
                //                $obj.attr("id", val);
                //                Dict_DictHandler.NewNodeCode = val;

            }
            //            ._get_node ( node , allow_multiple )
        });

        //树控件初始化(事件)
        //NODE-->type(Create_node)   REF_NODE 添加的节点

        Dict_DictHandler.thisTree.bind("create.jstree", function(e, data) {
            if (Dict_DictHandler.CurSelNode != null) {

                if (Dict_DictHandler.hasNewNode) {
                    $.jstree.rollback(data.rlbk);
                    ShowMsg("请先提交新建项！");
                    return;
                }

                var node = Dict_DictHandler.CurSelNode;

                //                var node = $.jstree._focused()._get_node();

                var parentCode = $(node).attr("id");

                $.ajax({
                    type: "post",
                    url: "/Dict/CreateNode",
                    dataType: "json",
                    data: { parentCode: parentCode, itype: Itype },
                    success: function(re, textStatus) {
                        if (re.result == "success") {
                            $(data.rslt.obj).find("a").attr("id", "temp_" + re.Dict_Code);
                            Dict_DictHandler.NewNodeCode = re.Dict_Code;
                            Dict_DictHandler.InitAddDict(re);
                            Dict_DictHandler.hasNewNode = true;
                            $("#Dict_Name").val("");
                            $("#Dict_Desp").val("");
                            $("#Dict_Bak").val("");
                            $("#Dict_ID").val("");
                            Dict_DictHandler.CurNode = "temp_" + re.Dict_Code;
                        }
                        else {
                            $.jstree.rollback(data.rlbk);
                            ShowMsg("该类别不允许添加多层级选项!");
                        }
                    }
                });
            }

        });
        Dict_DictHandler.thisTree.bind("loaded.jstree", function(event, data) {
            Dict_DictHandler.thisTree.jstree("open_all");
        });


        Dict_DictHandler.thisTree.bind("dblclick_node.jstree", function(event, data) {
            //var id = data.rslt.obj[0].childNodes[1].id;
            //Dict_DictHandler.GetEditData(id);
        });

        Dict_DictHandler.thisTree.bind("remove.jstree", function(e, data) {

            data.rslt.obj.each(function(item) {
                //                ShowMsg($(this).find("a").attr("id"));
                $.ajax({
                    type: 'POST',
                    url: "/Dict/DeleteNode/",
                    data: { code: $(this).find("a").attr("id"), type: Itype },
                    success: function(r) {
                        if (r.result == "success") {
                            ShowMsg("删除成功");
                            Dict_DictHandler.hasNewNode = false;
                            data.inst.refresh();
                        } else {
                            //data.inst.rollback();
                            //$.jstree.rollback();
                            ShowMsg(r.msg);
                            $.jstree.rollback(data.rlbk);
                        }
                        //window.location.reload();
                    }
                });
            });
        });

        //        Dict_DictHandler.thisTree.bind("rename.jstree", function(e, data) {
        //        })


        //数据控件事件绑定
        $("#DictList").bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                Dict_DictHandler.CurSelNode = $subject;
                var id = $subject.attr("id");

                if (Dict_DictHandler.hasNewNode) {
                    //alert(id);
                    //alert(Dict_DictHandler.CurNode);
                    if (id == Dict_DictHandler.CurNode) {
                        //编辑
                        Dict_DictHandler.GetEditData(id);
                    } else {
                        ShowMsg("请先编辑提交新建项");
                    }

                } else {
                    Dict_DictHandler.GetEditData(id);
                }

            }
        });


        $("#Add_folder").click(function() {

            Dict_DictHandler.InitAddDictEvent();
        });

        $("#Edit_folder").click(function() {
            Dict_DictHandler.InitEditDictEvent();
        });

        $("#Del_folder").click(function() {
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    Dict_DictHandler.DelDictEvent();
                }
            });
        });

        //表单初始化option
        var options = {
            success: function(data) { Dict_DictHandler.AfterOperation(data); },  // post-submit callback
            width: 800,
            timeout: 3000
        };

        // bind form using 'ajaxForm'
        Dict_DictHandler.thisForm.ajaxForm(options);
    }
}