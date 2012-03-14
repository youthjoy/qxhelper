<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<QX.Model.ChartConfig>" %>

<%@ Register assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>


<%
    QX.BLL.Bll_ChartMain cminstance = new QX.BLL.Bll_ChartMain();
    QX.BLL.Bll_ChartDetail cdinstance = new QX.BLL.Bll_ChartDetail();

    QX.Model.ChartMain CM = new QX.Model.ChartMain();
    List<QX.Model.ChartDetail> CDList = new List<QX.Model.ChartDetail>();
    CM = cminstance.GetModel(" AND CM_Module='" + Model.Module.ToString() + "'");
    CDList = cdinstance.GetListByCode(" AND CD_Module='" + Model.Module.ToString() + "' ");
    
    if (CM!=null || CDList.Count()>0)
    {
        Chart1.Width = CM.CM_Width;
        Chart1.Height = CM.CM_Height;
        Chart1.RenderType = RenderType.ImageTag;
        Chart1.Palette = ChartColorPalette.BrightPastel;
        Title t = new Title(!string.IsNullOrEmpty(Model.Title)?Model.Title:CM.CM_Title, 
                (Docking)Enum.Parse(typeof(Docking),CM.CM_TitleLocation,true),
                new System.Drawing.Font("Trebuchet MS", 14, System.Drawing.FontStyle.Bold), 
                System.Drawing.Color.FromArgb(26, 59, 105));
        Chart1.Titles.Add(t);
        
        foreach (string item in CM.CM_ChartAreas.Split(','))
        {
           if (!string.IsNullOrEmpty(item))
           {
               Chart1.ChartAreas.Add(item);
               
               //Chart1.ChartAreas[item].Area3DStyle.Enable3D = false; //3D展现
               //Chart1.ChartAreas[item].Area3DStyle.Rotation = 25;
               //Chart1.ChartAreas[item].Area3DStyle.Perspective = 9;
               //Chart1.ChartAreas[item].Area3DStyle.LightStyle = LightStyle.Realistic;
               
               Chart1.ChartAreas[item].AxisX.IsMarginVisible = true; // X轴 刻度分隔
               Chart1.ChartAreas[item].BorderDashStyle = ChartDashStyle.Dot;
               Chart1.ChartAreas[item].BorderColor = System.Drawing.Color.OldLace;
               Chart1.ChartAreas[item].ShadowColor = System.Drawing.Color.FromName("Transparent");

               
               /////X轴设置/////////////////////////////////////////////////////////////////////
               if (!string.IsNullOrEmpty(CM.CM_XLineColor))
               {
                   Chart1.ChartAreas[item].AxisX.LineColor = System.Drawing.Color.FromName(CM.CM_XLineColor);
               }
               if (!string.IsNullOrEmpty(CM.CM_XMajorGridLineColor))
               {
                   Chart1.ChartAreas[item].AxisX.MajorGrid.LineColor = System.Drawing.Color.FromName(CM.CM_XMajorGridLineColor);
               }               
               Chart1.ChartAreas[item].AxisX.MajorGrid.Enabled = CM.CM_XMajorGrid==1?true:false;//去掉网格
               if (!string.IsNullOrEmpty(CM.CM_XMajorGridLineColor))
               {
                   Chart1.ChartAreas[item].AxisY.MajorGrid.LineColor = System.Drawing.Color.FromName(CM.CM_XMajorGridLineColor);  
               }
               if (!string.IsNullOrEmpty(CM.CM_XMininum))
               {
                   Chart1.ChartAreas[item].AxisX.Minimum = Double.Parse(CM.CM_XMininum.ToString());  //刻度最小值
               }
               if (!string.IsNullOrEmpty(CM.CM_XMaxinum))
               {
                   Chart1.ChartAreas[item].AxisX.Maximum = Double.Parse(CM.CM_XMaxinum.ToString()); //刻度最大值
               }
               
               Chart1.ChartAreas[item].AxisX.IsMarginVisible = true;
               Chart1.ChartAreas[item].AxisX.IsReversed = false; //刻度反转
               if (!string.IsNullOrEmpty(CM.CM_XArrowStyle))
               {
                   Chart1.ChartAreas[item].AxisX.ArrowStyle = (AxisArrowStyle)Enum.Parse(typeof(AxisArrowStyle), CM.CM_XArrowStyle); //刻度样式 箭头
               }               
               Chart1.ChartAreas[item].AxisX.Crossing = 0; //纵坐标可跨度开始
               if (!string.IsNullOrEmpty(CM.CM_XInterval))
               {
                   Chart1.ChartAreas[item].AxisX.Interval = Double.Parse(CM.CM_XInterval.ToString()); //横坐标间隔数
               }
               if (!string.IsNullOrEmpty(CM.CM_XIntervalOffset))
               {
                   Chart1.ChartAreas[item].AxisX.IntervalOffset = Double.Parse(CM.CM_XIntervalOffset.ToString()); //横坐标第一个开始
               }
               if (!string.IsNullOrEmpty(CM.CM_XIntervalType))
               {
                   DateTimeIntervalType Xit=new DateTimeIntervalType();
                   if (!string.IsNullOrEmpty(Model.DateTime_XIntervalType))
                   {
                       Xit = (DateTimeIntervalType)Enum.Parse(typeof(DateTimeIntervalType), Model.DateTime_XIntervalType);
                   }else{
                       Xit=(DateTimeIntervalType)Enum.Parse(typeof(DateTimeIntervalType), CM.CM_XIntervalType);
                   }
                   Chart1.ChartAreas[item].AxisX.IntervalType = Xit ; //间隔默认模式
               }
               
               Chart1.ChartAreas[item].AxisX.IsInterlaced = false; //网络加背景
               if (!string.IsNullOrEmpty(CM.CM_XTitle))
               {
                   Chart1.ChartAreas[item].AxisX.Title = CM.CM_XTitle; //横坐标名称
               }
               if (!string.IsNullOrEmpty(CM.CM_XTitleAlignment))
               {
                   Chart1.ChartAreas[item].AxisX.TitleAlignment = (System.Drawing.StringAlignment)Enum.Parse(typeof(System.Drawing.StringAlignment), CM.CM_XTitleAlignment);     
               }                                        
               //Chart1.ChartAreas[item].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Months;
               
               
               /////Y轴设置/////////////////////////////////////////////////////////////////////
               if (!string.IsNullOrEmpty(CM.CM_YLineColor))
               {
                   Chart1.ChartAreas[item].AxisY.LineColor = System.Drawing.Color.FromName(CM.CM_YLineColor);
               }
               if (!string.IsNullOrEmpty(CM.CM_YMajorGridLineColor))
               {
                   Chart1.ChartAreas[item].AxisY.MajorGrid.LineColor = System.Drawing.Color.FromName(CM.CM_YMajorGridLineColor);
               }
               Chart1.ChartAreas[item].AxisY.MajorGrid.Enabled = CM.CM_YMajorGrid =="1" ? true : false;//去掉网格
               if (!string.IsNullOrEmpty(CM.CM_YMajorGridLineColor))
               {
                   Chart1.ChartAreas[item].AxisY.MajorGrid.LineColor = System.Drawing.Color.FromName(CM.CM_YMajorGridLineColor);
               }
               if ( !string.IsNullOrEmpty(CM.CM_YMininum))
               {
                   Chart1.ChartAreas[item].AxisY.Minimum = Double.Parse(CM.CM_YMininum.ToString());  //刻度最小值
               }
               if (!string.IsNullOrEmpty(CM.CM_YMaxinum))
               {
                   Chart1.ChartAreas[item].AxisY.Maximum = Double.Parse(CM.CM_YMaxinum.ToString()); //刻度最大值
               }

               Chart1.ChartAreas[item].AxisY.IsMarginVisible = true;
               Chart1.ChartAreas[item].AxisY.IsReversed = false; //刻度反转
               if (!string.IsNullOrEmpty(CM.CM_YArrowStyle))
               {
                   Chart1.ChartAreas[item].AxisY.ArrowStyle = (AxisArrowStyle)Enum.Parse(typeof(AxisArrowStyle), CM.CM_YArrowStyle); //刻度样式 箭头
               }
               Chart1.ChartAreas[item].AxisY.Crossing = 0; //纵坐标可跨度开始
               if (!string.IsNullOrEmpty(CM.CM_YInterval))
               {
                   Chart1.ChartAreas[item].AxisY.Interval = Double.Parse(CM.CM_YInterval.ToString()); //横坐标间隔数
               }
               if (!string.IsNullOrEmpty(CM.CM_YIntervalOffset))
               {
                   Chart1.ChartAreas[item].AxisY.IntervalOffset = Double.Parse(CM.CM_YIntervalOffset.ToString()); //横坐标第一个开始
               }
               if (!string.IsNullOrEmpty(CM.CM_YIntervalType))
               {
                   Chart1.ChartAreas[item].AxisY.IntervalType = (DateTimeIntervalType)Enum.Parse(typeof(DateTimeIntervalType), CM.CM_YIntervalType); //间隔默认模式
               }

               Chart1.ChartAreas[item].AxisY.IsInterlaced = false; //网络加背景
               if (!string.IsNullOrEmpty(CM.CM_YTitle))
               {
                   Chart1.ChartAreas[item].AxisY.Title = CM.CM_YTitle; //横坐标名称
               }
               if (!string.IsNullOrEmpty(CM.CM_YTitleAlignment))
               {
                   Chart1.ChartAreas[item].AxisY.TitleAlignment = (System.Drawing.StringAlignment)Enum.Parse(typeof(System.Drawing.StringAlignment), CM.CM_YTitleAlignment);
               }              
               
           }            
        }              
        
        // create a couple of series
        foreach (var item in CDList.OrderBy(o=>o.CD_ID))
        {
            Chart1.Series.Add(item.CD_Areas);
            //Series 类型
            Chart1.Series[item.CD_Areas].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), item.CD_ChartType);

            if (item.CD_BorderWidth!=null)
            {
                Chart1.Series[item.CD_Areas].BorderWidth = int.Parse(item.CD_BorderWidth.ToString());
            }
            if (!string.IsNullOrEmpty(item.CD_BorderColor))
            {
                Chart1.Series[item.CD_Areas].BorderColor = System.Drawing.Color.FromName(item.CD_BorderColor);
            }
            if (!string.IsNullOrEmpty(item.CD_BorderDashStyle))
            {
                Chart1.Series[item.CD_Areas].BorderDashStyle = (ChartDashStyle)Enum.Parse(typeof(ChartDashStyle), item.CD_BorderDashStyle);
            }
            
            //Chart1.Series[item.CD_Areas].Color = System.Drawing.Color.FromName("green");

            if (item.CD_IsValueShownAsLabel!=null)
            {
                Chart1.Series[item.CD_Areas].IsValueShownAsLabel = item.CD_IsValueShownAsLabel;  //显示点值，默认显示值 
            }            
            
            //Chart1.Series[item.CD_Areas].Label = "x1";                //Label自定义显示点值
            //Chart1.Series[item.CD_Areas].LabelToolTip = "ccc";        //Label提示
            //Chart1.Series[item.CD_Areas].LabelUrl = "www.baidu.com";  //Label超链接
            if (!string.IsNullOrEmpty(item.CD_LegendText))
            {
                Chart1.Series[item.CD_Areas].LegendText = item.CD_LegendText;        //自定义Legend显示名称,默认为Series名称
            }                       
           
            //Chart1.Series[item.CD_Areas].LegendToolTip = "";          //自定义Legend提示
            //Chart1.Series[item.CD_Areas].LegendUrl = "";              //定义Legend URL
            
            
            //点设置 大小，风格
            if (item.CD_MarkerSize!=null)
            {
                Chart1.Series[item.CD_Areas].MarkerSize = int.Parse(item.CD_MarkerSize.ToString());
            }
            if (!string.IsNullOrEmpty(item.CD_MarkerColor))
            {
                Chart1.Series[item.CD_Areas].MarkerColor = System.Drawing.Color.FromName(item.CD_MarkerColor); //定义点颜色 
            }
            if (!string.IsNullOrEmpty(item.CD_MarkerStyle))
            {
                Chart1.Series[item.CD_Areas].MarkerStyle = (MarkerStyle)Enum.Parse(typeof(MarkerStyle),item.CD_MarkerStyle); //定义点样式
            }
            
            //Chart1.Series[item.CD_Areas].MarkerBorderWidth = 5;     //定义点大小
            //Chart1.Series[item.CD_Areas].MarkerImage = "";     //自定义点图标
            //Chart1.Series[item.CD_Areas].MarkerImageTransparentColor=  //自定义图标透明 色            
            
            
            //Chart1.Series[item.CD_Areas].XAxisType = AxisType.Secondary;//横坐标在上
            //Chart1.Series[item.CD_Areas].XValueMember = "";
            //Chart1.Series[item.CD_Areas].XValueType = ChartValueType.Auto; //X值格式化
            //Chart1.Series[item.CD_Areas].YAxisType = AxisType.Secondary;
            //Chart1.Series[item.CD_Areas].YValueType = ChartValueType.Auto;
            
            int ParameterCount = string.IsNullOrEmpty(item.CD_Parmas)?0:item.CD_Parmas.Split(',').Count();
            System.Data.DataTable dt = new System.Data.DataTable();

            System.Data.SqlClient.SqlParameter[] param = new System.Data.SqlClient.SqlParameter[ParameterCount+1];
            
            //内置Module参数
            var ModuleParameter = new System.Data.SqlClient.SqlParameter("@Module", System.Data.SqlDbType.VarChar, 50);
            ModuleParameter.Value = item.CD_Module;
            param[0] = ModuleParameter;

            //从数据库中读取参数配置
            if (ParameterCount>0)
            {
                for (var j = 0; j < item.CD_Parmas.Split(',').Count(); j++)
                {
                    var tmp = new System.Data.SqlClient.SqlParameter(item.CD_Parmas.Split(',')[j], System.Data.SqlDbType.VarChar, 50);
                    if (Model.ProcParameters.Count>0)
                    {
                        tmp.Value = Model.ProcParameters[item.CD_Parmas.Split(',')[j]].ToString(); 
                    }                    
                    param[j + 1] = tmp;
                }
            }

            if (!string.IsNullOrEmpty(item.CD_Parmas))
            {
                if (Model.ProcParameters.Count>0)
                {
                    System.Data.IDbDataParameter[] parames = param as System.Data.IDbDataParameter[];
                    dt = QX.BLL.Bll_Comm.RunProc(item.CD_DataSource, parames);
                    if (dt.Rows.Count > 0)
                    {
                        for (var i = 0; i < dt.Rows.Count; i++)
                        {
                            Chart1.Series[item.CD_Areas].Points.AddXY(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
                        }
                    }     
                }                  
            }           
                   
        }


        Chart1.BorderlineDashStyle = ChartDashStyle.NotSet;
        Chart1.BackGradientStyle = GradientStyle.None;   
        //Chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
        //Chart1.BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);
        //Chart1.BorderlineDashStyle = ChartDashStyle.DashDot;
        Chart1.BorderWidth = 1;
        if (CM.CM_Legend!=null)
        {
            if (!CM.CM_Legend)
            {
                Chart1.Legends.Add("Legend1");
                Chart1.Legends[0].ItemColumnSeparator = LegendSeparatorStyle.DotLine;
            }
        }
        else
        {
            Chart1.Legends.Add("Legend1");
            Chart1.Legends[0].ItemColumnSeparator = LegendSeparatorStyle.DotLine;
        }
        if (!string.IsNullOrEmpty(CM.CM_LegendDock))
        {
            Chart1.Legends[0].Docking = (Docking)Enum.Parse(typeof(Docking), CM.CM_LegendDock);
        }
        if (!string.IsNullOrEmpty(CM.CM_LegendLocation))
        {
            Chart1.Legends[0].Alignment = (System.Drawing.StringAlignment)Enum.Parse(typeof(System.Drawing.StringAlignment),CM.CM_LegendLocation); //位置
        }      
        
        
        //Chart1.Legends[0].TableStyle = LegendTableStyle.Wide;
        
    }

    // Render chart control
    //Chart1.Page = this;
    //HtmlTextWriter writer = new HtmlTextWriter(Page.Response.Output);
    //Chart1.RenderControl(writer);  

    if (Chart1.Series.Count > 0)
    {
        foreach (var series in Chart1.Series)
        {
            series.PostBackValue = "#AXISLABEL";
            series.ToolTip = "#AXISLABEL";
            //series.ToolTip = "#AXISLABEL Region: #VAL{C}"; 
            //series.MapAreaAttributes =
            //     "onclick=\"javascript:ShowMsg('Mouse click event captured in the series! Series Name: #SER, Point Index: #INDEX');\"";
            //series.LegendMapAreaAttributes =
            //    "onclick=\"javascript:ShowMsg('Mouse click event captured in the legend! Series: #SER, Total Values: #TOTAL{C}');\"";


        }

    }  
      
    
%>
<%--<asp:Chart ID="Chart1" runat="server">
    <Series>
      
    </Series>
    <ChartAreas>
     
    </ChartAreas>
</asp:Chart>
--%>

<asp:CHART id="Chart1" runat="server" Palette="BrightPastel" BackColor="#b5d7bc" ImageType="Png" ImageLocation="~/TempImages/ChartPic_#SEQ(300,3)" Width="412px" Height="296px" >
							<%--<legends>
								<asp:Legend Enabled="False" IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
							</legends>--%>
							<borderskin SkinStyle="Emboss"></borderskin>
							<%--<series>
								<asp:Series MarkerSize="8" BorderWidth="3" XValueType="Double" Name="Series1" ChartType="Line" MarkerStyle="Circle" ShadowColor="Black" BorderColor="180, 26, 59, 105" Color="220, 65, 140, 240" ShadowOffset="2" YValueType="Double"></asp:Series>
								<asp:Series MarkerSize="9" BorderWidth="3" XValueType="Double" Name="Series2" ChartType="Line" MarkerStyle="Diamond" ShadowColor="Black" BorderColor="180, 26, 59, 105" Color="220, 224, 64, 10" ShadowOffset="2" YValueType="Double"></asp:Series>
							</series>--%>
							<chartareas>
								<%--<asp:ChartArea Name="ChartArea1" BorderColor="64, 64, 64, 64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="OldLace" ShadowColor="Transparent" BackGradientStyle="TopBottom">
									<area3dstyle Rotation="25" Perspective="9" LightStyle="Realistic" Inclination="40" IsRightAngleAxes="False" WallWidth="3" IsClustered="False" />
									<axisy LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisy>
									<axisx LineColor="64, 64, 64, 64">
										<LabelStyle Font="Trebuchet MS, 8.25pt, style=Bold" />
										<MajorGrid LineColor="64, 64, 64, 64" />
									</axisx>
								</asp:ChartArea>--%>
							</chartareas>
						</asp:CHART>