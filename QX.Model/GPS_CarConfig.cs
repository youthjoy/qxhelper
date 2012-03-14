using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 车辆配置表
   /// </summary>
   [Serializable]
   public partial class GPS_CarConfig
   {
      private decimal g_ID;
      private bool g_ID_IsChanged=false;
      public decimal G_ID
      {
         get{ return g_ID; }
         set{ g_ID = value; g_ID_IsChanged=true; }
      }
      public bool G_ID_IsChanged
      {
         get{ return g_ID_IsChanged; }
         set{ g_ID_IsChanged = value; }
      }
      private string car_No;
      private bool car_No_IsChanged=false;
      public string Car_No
      {
         get{ return car_No; }
         set{ car_No = value; car_No_IsChanged=true; }
      }
      public bool Car_No_IsChanged
      {
         get{ return car_No_IsChanged; }
         set{ car_No_IsChanged = value; }
      }
      private string car_Icon;
      private bool car_Icon_IsChanged=false;
      public string Car_Icon
      {
         get{ return car_Icon; }
         set{ car_Icon = value; car_Icon_IsChanged=true; }
      }
      public bool Car_Icon_IsChanged
      {
         get{ return car_Icon_IsChanged; }
         set{ car_Icon_IsChanged = value; }
      }
      private string car_CurPerson;
      private bool car_CurPerson_IsChanged=false;
      public string Car_CurPerson
      {
         get{ return car_CurPerson; }
         set{ car_CurPerson = value; car_CurPerson_IsChanged=true; }
      }
      public bool Car_CurPerson_IsChanged
      {
         get{ return car_CurPerson_IsChanged; }
         set{ car_CurPerson_IsChanged = value; }
      }
      private string car_CurPersonTel;
      private bool car_CurPersonTel_IsChanged=false;
      public string Car_CurPersonTel
      {
         get{ return car_CurPersonTel; }
         set{ car_CurPersonTel = value; car_CurPersonTel_IsChanged=true; }
      }
      public bool Car_CurPersonTel_IsChanged
      {
         get{ return car_CurPersonTel_IsChanged; }
         set{ car_CurPersonTel_IsChanged = value; }
      }
      private string car_Address;
      private bool car_Address_IsChanged=false;
      public string Car_Address
      {
         get{ return car_Address; }
         set{ car_Address = value; car_Address_IsChanged=true; }
      }
      public bool Car_Address_IsChanged
      {
         get{ return car_Address_IsChanged; }
         set{ car_Address_IsChanged = value; }
      }
      private string car_ShowTxtR;
      private bool car_ShowTxtR_IsChanged=false;
      public string Car_ShowTxtR
      {
         get{ return car_ShowTxtR; }
         set{ car_ShowTxtR = value; car_ShowTxtR_IsChanged=true; }
      }
      public bool Car_ShowTxtR_IsChanged
      {
         get{ return car_ShowTxtR_IsChanged; }
         set{ car_ShowTxtR_IsChanged = value; }
      }
      private string car_ShowTxt;
      private bool car_ShowTxt_IsChanged=false;
      public string Car_ShowTxt
      {
         get{ return car_ShowTxt; }
         set{ car_ShowTxt = value; car_ShowTxt_IsChanged=true; }
      }
      public bool Car_ShowTxt_IsChanged
      {
         get{ return car_ShowTxt_IsChanged; }
         set{ car_ShowTxt_IsChanged = value; }
      }
      /// <summary>
      /// running,stoped
      /// </summary>
      private string car_Staus;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool car_Staus_IsChanged=false;
      /// <summary>
      /// running,stoped
      /// </summary>
      public string Car_Staus
      {
         get{ return car_Staus; }
         set{ car_Staus = value; car_Staus_IsChanged=true; }
      }
      /// <summary>
      /// running,stoped
      /// </summary>
      public bool Car_Staus_IsChanged
      {
         get{ return car_Staus_IsChanged; }
         set{ car_Staus_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
