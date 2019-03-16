using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDDemoAngular.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDDemoAngular.Controllers
{
    //یک ای پی آی تولید کنیم که رکوردهای جدول رو به صورت جی سون به ما تحویل بدهد
    public class APIController : Controller
    {
        //شی نماد پایگاه
        private readonly ClassNamadPayegah _db;

        //کانستراکتر
        public APIController(ClassNamadPayegah db)
        {
            _db = db;
        }
        public JsonResult GetCategories()  // ای پی آی با خروجی جی سون ریزالت به نام گت کتگوریز_این مورد اطلاعات را از دیتابیس استخراج می کند
        {
            return Json(_db.Categories);
        }

        //حالا باید اکشن دیلیت را تعریف کنیم
        public JsonResult DeleteCategories(int id)
        {
            var category = _db.Categories.Find(id); //فایند این آی دی در کتگوریز
            _db.Categories.Remove(category);
            _db.SaveChanges();//تغییرات ذخیره شود
            return GetCategories();
        }
        //حذف اوکی شد. حالا بایداین اکشن را در ایندکس فراخوانی کنیم


    }
}