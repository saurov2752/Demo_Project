using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Models;
using System.Data;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DAL.db dblayer = new DAL.db();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            DataSet ds = dblayer.get_record();
            List<PostStatus> oDatas = new List<PostStatus>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                oDatas.Add(new PostStatus
                {
                    PostID = Convert.ToInt32(dr["PostID"]),
                    PostDetail = dr["PostDetail"].ToString(),
                    PostUserID = Convert.ToInt32(dr["PostUserID"]),
                    PostDate = Convert.ToDateTime(dr["PostDate"]),
                    CommentID = Convert.ToInt32(dr["CommentID"]),
                    CommentDetails = dr["CommentDetails"].ToString(),
                    CommentUserID=Convert.ToInt32(dr["CommentUserID"]),
                    CommentDate = Convert.ToDateTime(dr["CommentDate"]),
                    LikeNo=Convert.ToInt32(dr["LikeNo"]),
                    DislikeNo=Convert.ToInt32(dr["DislikeNo"]),
                    CommentNo = Convert.ToInt32(dr["CommentNo"]),
                    PostUserName = dr["PostUserName"].ToString(),
                    CommentUserName = dr["CommentUserName"].ToString()
                });
            }
            return Json(oDatas, JsonRequestBehavior.AllowGet);
        }

	}
}