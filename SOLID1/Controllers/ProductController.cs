using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Service;
using Service.Services;
using System.Web.Mvc;
using Service.Services.Product;
using StructureMap;
using Entites.Product;
using System.Web.Script.Serialization;


namespace SOLID1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductFacade _productFacade;
        public ProductController(ProductFacade facade)
        {
            _productFacade = facade;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Edit(string jsonString)
        {
            JavaScriptSerializer jseralizer = new JavaScriptSerializer();

            var obj = jseralizer.Deserialize(jsonString, typeof(Product[]));



            if (_productFacade.UpdateAll(obj as Product[]))
            {
                return Json(new
                {
                    success = true
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    success = false
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}