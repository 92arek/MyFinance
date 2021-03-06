﻿using System;
using System.Web.Mvc;
using MyFinance.Services.TestSevice;
using MyFinance.ViewModels;

namespace MyFinance.Controllers
{
    public class MyTestController : Controller
    {
        private readonly IAdditionService additionService;
        private readonly IDependencyInversion<A> dependencyInversionA;
        private readonly IDependencyInversion<B> dependencyInversionB;

        public MyTestController(IAdditionService additionService,
            IDependencyInversion<A> dependencyInversionA,
            IDependencyInversion<B> dependencyInversionB)
        {
            this.additionService = additionService;
            this.dependencyInversionA = dependencyInversionA;
            this.dependencyInversionB = dependencyInversionB;
        }

        // GET: MyTest
        public ActionResult Index()
        {
            var model = new TestModel()
            {
                Name =  "Arek",
                NowDate = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection model)
        {
            TestModel tModel = new TestModel();
            TryUpdateModel(tModel);

            if (!ModelState.IsValid)
                return View();

            ResultModel result = new ResultModel(){ CalculationType = "Addition result"};
            result.ResultOfCalculation = additionService.AddNumbers(tModel.Xval.Value, tModel.Yval.Value);

            return RedirectToAction("ResultOfCalculaiton", result);
        }
        public ActionResult ResultOfCalculaiton(ResultModel model)
        {
            return View(model);
        }


        [HttpPost]
        public ActionResult MultiplyResult(FormCollection model)
        {
            TestModel multiModel = new TestModel();
            TryUpdateModel(multiModel);

            if (!ModelState.IsValid)
                return View();

            ResultModel multuResult = new ResultModel(){CalculationType = "Multiply result"};
            multuResult.ResultOfCalculation = additionService.MultiplyNumbers(multiModel.Xval.Value, multiModel.Yval.Value);

            return RedirectToAction("ResultOfCalculaiton", multuResult);
        }
        public ActionResult Multiply()
        {
            var model = new TestModel();
            
            var AandB = dependencyInversionA.ReturnLetter();
            AandB = $"{AandB} {dependencyInversionB.ReturnLetter()}";
            model.Name = AandB;

            return View(model);
        }
    }
}