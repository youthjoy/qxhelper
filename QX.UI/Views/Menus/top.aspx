﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>
<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
.STYLE1 {font-size: 12px}
.STYLE2 {
	color: #03515d;
	font-size: 12px;
}
-->
a:link {font-size:12px; text-decoration:none; color:#000000;}
a:visited {font-size:12px; text-decoration:none; color:#000000;}
a:hover {font-size:12px; text-decoration:none; color:#FF0000;}

a.v1:link {font-size:12px; text-decoration:none; color:#03515d;}
a.v1:visited {font-size:12px; text-decoration:none; color:#03515d;}
</style>

</head>

<body>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td height="26" background="<%=Url.Content("../Content/images/main_03.gif")%>"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="227" height="26" background="<%=Url.Content("../Content/images/main_01.gif")%>" >&nbsp;</td>
        <td>&nbsp;</td>
        <td width="60"><img src="<%=Url.Content("../Content/images/main_05.gif")%>" width="60" height="26" /></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="64"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr> 
        <td width="227" height="64" background="<%=Url.Content("../Content/images/main_06.gif")%>" nowrap="nowrap" >&nbsp;</td>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="26" background="<%=Url.Content("../Content/images/main_07.gif")%>"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="26"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td width="640" height="26"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td width="30"><div align="center"><img src="<%=Url.Content("../Content/images/top_1.gif")%>" width="14" height="14" /></div></td>
                        <td  nowrap="nowrap" class="STYLE1">当前登录用户：<%=ViewData["UserName"].ToString()%> 用户角色：管理员</td>
                      </tr>
                    </table></td>
                    <td width="19"><img src="<%=Url.Content("../Content/images/main_09.gif")%>" width="19" height="26" /></td>
                    <td width="352"><table width="46%" border="0" align="right" cellpadding="0" cellspacing="0">
                      <tr>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("../Content/images/top_2.gif")%>" width="14" height="14" /></div></td>
                              <td width="35"><div align="center" class="STYLE1"><a href="#">首页</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("../Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("../Content/images/top_3.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a href="#">后退</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("../Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("../Content/images/top_4.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a href="#">前进</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("../Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("../Content/images/top_5.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a href="#">刷新</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("../Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="102"><table width="102" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="22"><div align="center"><img src="<%=Url.Content("../Content/images/top_6.gif")%>" width="14" height="14" /></div></td>
                              <td width="80"><div align="center" class="STYLE1"><a href="#">个人信息修改</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("../Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("../Content/images/top_7.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a href="/home/logout">退出</a></div></td>
                            </tr>
                        </table></td>
                        </tr>
                    </table></td>
                  </tr>
                </table></td>
                <td width="12"><img src="<%=Url.Content("../Content/images/main_13.gif")%>" width="12" height="26" /></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td height="38" background="<%=Url.Content("../Content/images/main_15.gif")%>"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="38"><table border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <%=Html.BindTopMenu(Model as List<QX.Model.System_Menu>)%>
                    </tr>
                </table></td>
                <td width="60" ><div align="right"><img src="../Content/images/main_17.gif" width="60" height="38" /></div></td>
              </tr>
            </table></td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
</table>
</body>
</html>
