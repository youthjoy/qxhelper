using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.Model;

using QX.BLL;
using QX.Comm;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using QX.AOP;
using QX.Config;

namespace QX.Controllers.Controllers
{
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    public class BseControll : Controller
    {
        public ActionResult JsonError(string msg)
        {
            return JsonError(msg, false);
        }

        public ActionResult JsonError(string msg, bool isText)
        {
            var json = new Dictionary<string, object> { { "Error", true }, { "Text", msg } };
            return isText ? Json(json, "text/html", JsonRequestBehavior.AllowGet) : Json(json, JsonRequestBehavior.AllowGet);
        }
        [NonAction]
        protected string GetError(ModelStateDictionary modelState)
        {
            var errorMessage = modelState.Keys.Select(key => ModelState[key].Errors.FirstOrDefault()).Where(error => error != null).Aggregate("", (current, error) => current + (error.ErrorMessage + "\r\n"));
            return errorMessage;
        }
    }

    public class MenusController : BseControll
    {
        private BLL.Bll_System_Menu MenuInstance = new Bll_System_Menu();
        private BLL.Bll_System_TopMenu TopInsatance = new BLL.Bll_System_TopMenu();
        
        System_Menu MenuModel;
        public ActionResult Index(string id)
        { 
            ViewData["MenuList"] = MenuInstance.GetChildListMenu();
            if (string.IsNullOrEmpty(id))
            {
                MenuModel = MenuInstance.GetModels("001");
                return View(MenuModel);
            }
            else
            {
                MenuModel = MenuInstance.GetModels(id); 
                var result = JsonConvert.SerializeObject(MenuModel, new JsonDateConverter("yyyy-MM-dd"));
                return JavaScript(result);
            }
           
           
        }
        [HttpPost]
        public ActionResult Index(System_Menu Smenu)
        {
            bool result = MenuInstance.Update(Smenu);
            if (result)
            {
                return RedirectToAction("Index", "Menus");
            }
            else
            {
                return View();
            }
        }
        public ActionResult List(int page, int rows, string search, string sidx, string sord)
        {
            List<System_Menu> list = MenuInstance.GetListByCode(" AND Menu_Location='top' ORDER BY Menu_Order ");
            var model = list.AsQueryable<System_Menu>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(result);
        }
        public ActionResult Edit(string id)
        {
            System_Menu model = MenuInstance.GetModels(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditData(System_Menu SMenu)
        {
            bool result = false;
            try
            {
                result = MenuInstance.Update(SMenu,ModelState.IsValid);
            }
            catch (ModelExceptions e)
            {
                e.FillModelState(ModelState);
            }            
            if (result && ModelState.IsValid )
            {               
                //return RedirectToAction("Index", "Menus");
                return View("/Menus/index" + SMenu.Menu_Code, SMenu);
            }
            else
            {
                return JsonError(GetError(ModelState), true);
            }
              
        }
        [HttpPost]
        public ActionResult Create(System_Menu SMenu)
        {
            SMenu.Shortcut = 1;
            bool result = MenuInstance.Insert(SMenu);
            if (result)
            {
                return RedirectToAction("Index", "Menus");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Menussy(string Shortcut)
        {
            return View();
        }
        [HttpPost]
        public ActionResult MoveItemUp(string preId,string curId)
        {
            int _preId = 0;
            int _curId = 0;
            int.TryParse(preId, out _preId);
            int.TryParse(curId, out _curId);
            System_Menu preMode = MenuInstance.GetModel(_preId);
            System_Menu curMode = MenuInstance.GetModel(_curId);
            int preOrderId = preMode.Menu_Order;
            int curOrderId = curMode.Menu_Order;
            preMode.Menu_Order = curOrderId;
            curMode.Menu_Order = preOrderId;
            MenuInstance.Update(preMode);
            MenuInstance.Update(curMode);
            //BLL.Bll_Menus_Move.sortUp(id);
            return Content("success");
        }
        public ActionResult MoveItemDown(string curId, string nextId)
        {
            int _curId = 0;
            int _nextId = 0;
            int.TryParse(curId, out _curId);
            int.TryParse(nextId, out _nextId);
            System_Menu curMode = MenuInstance.GetModel(_curId);
            System_Menu nextMode = MenuInstance.GetModel(_nextId);
            int curOrderId = curMode.Menu_Order;
            int nextOrderId = nextMode.Menu_Order;
            curMode.Menu_Order = nextOrderId;
            nextMode.Menu_Order = curOrderId;
            MenuInstance.Update(nextMode);
            MenuInstance.Update(curMode);
            return Content("success");
        }

        public ActionResult Stuff_ContactEdit(string id)
        {
            var model = new Bll_System_Menu().GetModel(string.Format("AND Menu_Code='{0}'", id));
            var result = JsonConvert.SerializeObject(model, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(result);
        }
        [HttpPost]
        public ActionResult EditContact(System_Menu sf)
        {
            return new BLL.Bll_System_Menu().AddUpdatePlanObject(sf) ? Content("success") : Content("false");
        }
        [HttpPost]
        public ActionResult Menusadd(System_Menu sf)
        {
            bool result = new BLL.Bll_System_Menu().Update(sf);
            string strResult = result ? sf.Menu_Code : "fail";
            return Content(strResult);
        }


        public ActionResult QuickLink()
        {
            var DataSource =  MenuInstance.GetChildListMenu().OrderBy(o=>o.Menu_Order).ToList();

            //权限过滤
            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                DataSource = DataSource.Where(o => BLL.Bll_Comm.UserPermissionArray(SessionConfig.UserId()).Contains(o.Menu_Code))
                                             .ToList();
            }

            ViewData["MenuList"] = DataSource;



            var model = TopInsatance.GetModel(" AND Menu_User='" + SessionConfig.UserId() + "' ");
            ViewData["TopList"] = model!=null? model.Menu_Links:"";

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SaveQuickMenu()
        {
            var LinkHtml = Request["Html"].Trim();
            var model = TopInsatance.GetModel(" AND Menu_User='" + SessionConfig.UserId() + "' ");
            if (model!=null)
            {
                model.Menu_Links=LinkHtml;
                TopInsatance.Update(model);
            }else{
                var NewModel = new System_TopMenu()
                {
                    Menu_User = SessionConfig.UserId(),
                    Menu_Links = LinkHtml
                };
                TopInsatance.Insert(NewModel);
            }
            return Content("success");
        }

    }
}
