using UTSMedicalSystem.FrontEnd.Controllers; using UTSMedicalSystem.FrontEnd.Data; using Microsoft.AspNetCore.Mvc;  using Microsoft.EntityFrameworkCore; using Microsoft.VisualStudio.TestTools.UnitTesting;  namespace UnitTestProject.Testing {     [TestClass]     public class ControllerTesting     {         [TestMethod]         public void VerifyIdexViewTpe()         {              //Arrange             var controller = new HomeController();              var result = controller.Index();              //Assert             Assert.IsNotNull(result);             Assert.IsInstanceOfType(result,typeof(ViewResult));          }      } } 