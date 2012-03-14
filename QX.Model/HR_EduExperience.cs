using System;
using System.Data;


namespace QX.Model
{
    /// <summary>
    /// 个人经历
    /// </summary>
    [Serializable]
    public partial class HR_EduExperience
    {
        /// <summary>
        /// 经历序号
        /// </summary>
        private int eXa_ID;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_ID_IsChanged = false;
        /// <summary>
        /// 经历序号
        /// </summary>
        [MetaData("EXa_ID", "经历序号")]
        public int EXa_ID
        {
            get { return eXa_ID; }
            set { eXa_ID = value; eXa_ID_IsChanged = true; }
        }
        /// <summary>
        /// 经历序号
        /// </summary>
        public bool EXa_ID_IsChanged
        {
            get { return eXa_ID_IsChanged; }
            set { eXa_ID_IsChanged = value; }
        }
        /// <summary>
        /// 个人经历编码
        /// </summary>
        private string eXa_Code;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_Code_IsChanged = false;
        /// <summary>
        /// 个人经历编码
        /// </summary>
        [MetaData("EXa_Code", "个人经历编码")]
        public string EXa_Code
        {
            get { return eXa_Code; }
            set { eXa_Code = value; eXa_Code_IsChanged = true; }
        }
        /// <summary>
        /// 个人经历编码
        /// </summary>
        public bool EXa_Code_IsChanged
        {
            get { return eXa_Code_IsChanged; }
            set { eXa_Code_IsChanged = value; }
        }
        /// <summary>
        /// 员工编码
        /// </summary>
        private string eXa_StuffCode;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_StuffCode_IsChanged = false;
        /// <summary>
        /// 员工编码
        /// </summary>
        [MetaData("EXa_StuffCode", "员工编码")]
        public string EXa_StuffCode
        {
            get { return eXa_StuffCode; }
            set { eXa_StuffCode = value; eXa_StuffCode_IsChanged = true; }
        }
        /// <summary>
        /// 员工编码
        /// </summary>
        public bool EXa_StuffCode_IsChanged
        {
            get { return eXa_StuffCode_IsChanged; }
            set { eXa_StuffCode_IsChanged = value; }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        private string eXa_StuffName;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_StuffName_IsChanged = false;
        /// <summary>
        /// 员工姓名
        /// </summary>
        [MetaData("EXa_StuffName", "员工姓名")]
        public string EXa_StuffName
        {
            get { return eXa_StuffName; }
            set { eXa_StuffName = value; eXa_StuffName_IsChanged = true; }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public bool EXa_StuffName_IsChanged
        {
            get { return eXa_StuffName_IsChanged; }
            set { eXa_StuffName_IsChanged = value; }
        }
        /// <summary>
        /// 经历类型
        /// </summary>
        private string eXa_Type;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_Type_IsChanged = false;
        /// <summary>
        /// 经历类型
        /// </summary>
        [MetaData("EXa_Type", "学历类型")]
        public string EXa_Type
        {
            get { return eXa_Type; }
            set { eXa_Type = value; eXa_Type_IsChanged = true; }
        }
        /// <summary>
        /// 经历类型
        /// </summary>
        public bool EXa_Type_IsChanged
        {
            get { return eXa_Type_IsChanged; }
            set { eXa_Type_IsChanged = value; }
        }
        /// <summary>
        /// 经历单位
        /// </summary>
        private string eXa_Corrp;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_Corrp_IsChanged = false;
        /// <summary>
        /// 经历单位
        /// </summary>
        [MetaData("EXa_Corrp", "学历")]
        public string EXa_Corrp
        {
            get { return eXa_Corrp; }
            set { eXa_Corrp = value; eXa_Corrp_IsChanged = true; }
        }
        /// <summary>
        /// 经历单位
        /// </summary>
        public bool EXa_Corrp_IsChanged
        {
            get { return eXa_Corrp_IsChanged; }
            set { eXa_Corrp_IsChanged = value; }
        }
        /// <summary>
        /// 经历职位
        /// </summary>
        private string eXa_Title;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_Title_IsChanged = false;
        /// <summary>
        /// 经历职位
        /// </summary>
        [MetaData("EXa_Title", "专业")]
        public string EXa_Title
        {
            get { return eXa_Title; }
            set { eXa_Title = value; eXa_Title_IsChanged = true; }
        }
        /// <summary>
        /// 经历职位
        /// </summary>
        public bool EXa_Title_IsChanged
        {
            get { return eXa_Title_IsChanged; }
            set { eXa_Title_IsChanged = value; }
        }
        /// <summary>
        /// 简介
        /// </summary>
        private string eXa_Intro;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_Intro_IsChanged = false;
        /// <summary>
        /// 简介
        /// </summary>
        [MetaData("EXa_Intro", "简介")]
        public string EXa_Intro
        {
            get { return eXa_Intro; }
            set { eXa_Intro = value; eXa_Intro_IsChanged = true; }
        }
        /// <summary>
        /// 简介
        /// </summary>
        public bool EXa_Intro_IsChanged
        {
            get { return eXa_Intro_IsChanged; }
            set { eXa_Intro_IsChanged = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        private string eXa_Bak;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool eXa_Bak_IsChanged = false;
        /// <summary>
        /// 备注
        /// </summary>
        [MetaData("EXa_Bak", "备注")]
        public string EXa_Bak
        {
            get { return eXa_Bak; }
            set { eXa_Bak = value; eXa_Bak_IsChanged = true; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public bool EXa_Bak_IsChanged
        {
            get { return eXa_Bak_IsChanged; }
            set { eXa_Bak_IsChanged = value; }
        }
        private DateTime eXa_Start;
        private bool eXa_Start_IsChanged = false;
        [MetaData("EXa_Start", "")]
        public DateTime EXa_Start
        {
            get { return eXa_Start; }
            set { eXa_Start = value; eXa_Start_IsChanged = true; }
        }
        public bool EXa_Start_IsChanged
        {
            get { return eXa_Start_IsChanged; }
            set { eXa_Start_IsChanged = value; }
        }
        private DateTime eXa_End;
        private bool eXa_End_IsChanged = false;
        [MetaData("EXa_End", "")]
        public DateTime EXa_End
        {
            get { return eXa_End; }
            set { eXa_End = value; eXa_End_IsChanged = true; }
        }
        public bool EXa_End_IsChanged
        {
            get { return eXa_End_IsChanged; }
            set { eXa_End_IsChanged = value; }
        }
        private int stat;
        private bool stat_IsChanged = false;
        [MetaData("Stat", "")]
        public int Stat
        {
            get { return stat; }
            set { stat = value; stat_IsChanged = true; }
        }
        public bool Stat_IsChanged
        {
            get { return stat_IsChanged; }
            set { stat_IsChanged = value; }
        }
    }
}