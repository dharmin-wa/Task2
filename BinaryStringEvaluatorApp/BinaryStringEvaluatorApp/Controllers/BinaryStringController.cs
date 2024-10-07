using BinaryStringEvaluatorApp.Helper;
using BinaryStringEvaluatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BinaryStringEvaluatorApp.Controllers
{
    public class BinaryStringController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BinaryStringViewModel());
        }

        [HttpPost]
        public IActionResult Index(BinaryStringViewModel model)
        {
            if (!string.IsNullOrEmpty(model.BinaryString))
            {
                if (BinaryStringEvaluator.IsGoodBinaryString(model.BinaryString))
                {
                    model.Result = $"Your Binary String Is: {model.BinaryString}, Result: GOOD";
                }
                else
                {
                    model.Result = $"Your Binary String Is: {model.BinaryString}, Result: NOT GOOD.";
                }
            }
            else
            {
                model.Result = "Please enter a valid binary string.";
            }

            return View(model);
        }
    }
}
