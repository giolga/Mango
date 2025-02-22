using Mango.Web.Models;
using Mango.Web.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }


        public async Task<IActionResult> CouponIndex()
        {
            List<CouponDto>? list = new List<CouponDto>();

            ResponseDto? response = await _couponService.GetAllCouponsAsync();

            if(response.IsSuccess && response != null)
            {
                list = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result)!);
            }

            return View(list);
        }

        public async Task<IActionResult> CouponCreate()
        {

            return View();
        }
    }
}
