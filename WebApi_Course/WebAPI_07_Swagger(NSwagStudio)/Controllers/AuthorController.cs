﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI_07_Swagger.Models;
using WebAPI_07_Swagger.Repository;

namespace WebAPI_07_Swagger.Controllers
{
    public class AuthorController : BaseDBController<Author, EFCoreAuthorRepository>
    {
        // 只要在控制器的构造函数里面写了这个参数，ServiceProvider就会帮我们link。这一步是在Mvc初始化控制器的时候完成的
        public AuthorController(EFCoreAuthorRepository repository) : base(repository)
        {
        }
    }
}
