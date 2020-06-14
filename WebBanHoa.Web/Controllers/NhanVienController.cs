﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebBanHoa.Web.Controllers
{
    using BLL;
    using DAL.Models;
    using Common.Req;
    using Common.Rsp;

    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        public NhanVienController()
        {
            _svc = new NhanVienSvc();
        }

        [HttpPost("get-by-id")]
        public IActionResult getNhanVienById([FromBody]SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Id);
            return Ok(res);
        }
        [HttpPost("get-all")]
        public IActionResult getAllNhanVienById()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;
            return Ok(res);
        }

        private readonly NhanVienSvc _svc;
    }
}