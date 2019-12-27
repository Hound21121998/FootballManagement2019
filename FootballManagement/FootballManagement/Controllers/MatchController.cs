using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballManagement.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Tạo trận đấu
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// Lập lịch thi đấu
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateSchedule()
        {
            return View();
        }
        /// <summary>
        /// Cập nhật kết quả trận đấu
        /// </summary>
        /// <returns></returns>
        public ActionResult UpdateResult()
        {
            return View();
        }

    }
}