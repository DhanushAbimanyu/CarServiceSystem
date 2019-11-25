using System;
using Car_Service.Context;
using Car_Service.Models;
using System.Linq;
using System.Web.Mvc;

namespace Car_Service.Controllers
{
    public class HomeController : Controller
    {

        CarContext db = new CarContext();

        public ActionResult Index()
        {
           return View(db.CarDetails.ToList());
        }

        [HttpGet]
        public ActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCar(CarDetails car)
        {
            db.CarDetails.Add(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditCar(int id)
        {
            var editcar = db.CarDetails.FirstOrDefault(s => s.Id == id);
            return View(editcar);
        }

        [HttpPost]
        public ActionResult EditCar(CarDetails car)
        {
            var editcar = db.CarDetails.FirstOrDefault(s => s.Id == car.Id);
            editcar.CarIssue = car.CarIssue;
            editcar.CarModelNo = car.CarModelNo;
            editcar.CarName = car.CarName;
            editcar.CarNumber = car.CarNumber;
            editcar.CustomerEmail = car.CustomerEmail;
            editcar.CustomerMobile = car.CustomerMobile;
            editcar.CustomerName = car.CustomerName;
            editcar.Id = car.Id;
            editcar.ReturnDate = car.ReturnDate;
            editcar.ServiceDate = car.ServiceDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCar(int id)
        {
            var deletecar = db.CarDetails.FirstOrDefault(s => s.Id == id);
            return View(deletecar);
        }

        [HttpPost]
        public ActionResult DeleteCar(CarDetails car)
        {
            var deletecar = db.CarDetails.FirstOrDefault(s => s.Id == car.Id);
            db.CarDetails.Remove(deletecar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CarDetails(int id)
        {
            var cardetails = db.CarDetails.FirstOrDefault(s => s.Id == id);
            return View(cardetails);
        }

        /*public ActionResult Dispatcher()
        {
            
            return View();
        }*/
    }
}