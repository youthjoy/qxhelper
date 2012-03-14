using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 顶部快捷方式
   /// </summary>
   [Serializable]
   public partial class System_TopMenu
   {
      private decimal menu_ID;
      private bool menu_ID_IsChanged=false;
      public decimal Menu_ID
      {
         get{ return menu_ID; }
         set{ menu_ID = value; menu_ID_IsChanged=true; }
      }
      public bool Menu_ID_IsChanged
      {
         get{ return menu_ID_IsChanged; }
         set{ menu_ID_IsChanged = value; }
      }
      private string menu_User;
      private bool menu_User_IsChanged=false;
      public string Menu_User
      {
         get{ return menu_User; }
         set{ menu_User = value; menu_User_IsChanged=true; }
      }
      public bool Menu_User_IsChanged
      {
         get{ return menu_User_IsChanged; }
         set{ menu_User_IsChanged = value; }
      }
      private string menu_Links;
      private bool menu_Links_IsChanged=false;
      public string Menu_Links
      {
         get{ return menu_Links; }
         set{ menu_Links = value; menu_Links_IsChanged=true; }
      }
      public bool Menu_Links_IsChanged
      {
         get{ return menu_Links_IsChanged; }
         set{ menu_Links_IsChanged = value; }
      }
   }
}
