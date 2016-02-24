using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EasyRecord.Common;
using EasyRecord.Respository;
using EasyRecord.Respository.Category;
using EasyRecord.Respository.Entitys;

namespace EasyRecord.Controllers
{
    [EnableCors("*", "*", "*")]
    public class HomeController : ApiController
    {
        private readonly ICategoryDAL _iCategoryDAL;

        public HomeController(ICategoryDAL iCategoryDAL)
        {
            _iCategoryDAL = iCategoryDAL;
        }

        [HttpGet]
        public HttpResponseMessage Index()
        {
            var db = new EasyRecordContext();
            //var categorymodel = new CategoryEntity
            //{
            //    Name = "test"
            //};
            //db.Category.Add(categorymodel);
            //db.SaveChanges();

            return JsonHelper.GoToJson(db.Category.FirstOrDefault());
        }
    }
}
