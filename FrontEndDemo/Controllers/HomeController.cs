using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Dictionary<string, bool> Dic = new Dictionary<string, bool>();
            Dic["aaa"] = true;
            Dic["bbb"] = false;
            List<DictionaryLinqTest> SubData = new List<DictionaryLinqTest>() {
                new DictionaryLinqTest {Count=1,Name="a" },
                new DictionaryLinqTest {Count = 2,Name = "b" },
                new DictionaryLinqTest {Count=3,Name="c" }
};
            List<DictionaryLinqTest> SubData2 = new List<DictionaryLinqTest>() {
                new DictionaryLinqTest {Count=4,Name="d" },
                new DictionaryLinqTest {Count = 5,Name = "e" },
                new DictionaryLinqTest {Count=6,Name="f" }
};
            Dictionary<int, List<DictionaryLinqTest>> Data = new Dictionary<int, List<DictionaryLinqTest>>()
            { { 1,SubData}, {2,SubData2 } };
            var Result = Data.Select(x => x.Value.Sum(c => c.Count));

            


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //TODO :lll
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class DictionaryLinqTest
    {
        public int Count { get; set; }
        public string Name { get; set; }
    }
    public class ModelDiff
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}