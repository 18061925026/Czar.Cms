using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Simple001.Models;

namespace Simple001.Controllers
{
    public class ContentController:Controller
    {
        private readonly Content mContents;

        public ContentController(IOptions<Content> option)
        {
            mContents = option.Value;
        }
        public IActionResult Index()
        {
            var contents = new List<Content>();
            //for (int i = 0; i < 11; i++)
            //{
            //    contents.Add(new Content() 
            //    {
            //        Id = i, 
            //        Title = $"{i}的标题",
            //        ContentData = $"{i}的内容",
            //        Status = 1,
            //        AddTime = DateTime.Now.AddDays(-i)
            //    });
            //}
            contents.Add(mContents);
            return View(new ContentViewModel {Contents = contents});
        }
    }
}
