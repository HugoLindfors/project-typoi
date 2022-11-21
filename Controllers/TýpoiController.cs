using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Týpoi.Controllers
{
    public class TýpoiController : Controller
    {
        // GET: Týpoi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hem()
        {
            return View();
        }
        public ActionResult S1()
        {
            return View();
        }
        public ActionResult S2()
        {
            return View();
        }
        public ActionResult S3()
        {
            return View();
        }
        public ActionResult S4()
        {
            return View();
        }
        public ActionResult S5()
        {
            return View();
        }
        public ActionResult S6()
        {
            return View();
        }
        public ActionResult S7()
        {
            return View();
        }
        public ActionResult S8()
        {
            return View();
        }
        public ActionResult Resultat()
        {
            return View();
        }

        // POST : Týpoi
        [HttpPost]
        public ActionResult AlgebraRegel1(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);
                int b = Convert.ToInt32(fc["b"]);

                Session["ImgURL"] = "/Img/AlgebraRegel1.jpg";

                Session["Steg1"] = "(" + a + " + " + b + ")²";
                Session["Steg2"] = a + "² + 2 · " + a + " · " + b + " + " + b + "²";
                Session["Steg3"] = Math.Pow(a, 2) + " + " + (2 * a * b) + " + " + Math.Pow(b, 2);
                Session["Steg4"] = null;
                Session["Svar"] = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
                Session["Felmeddelande"] = null;
                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult AlgebraRegel2(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);
                int b = Convert.ToInt32(fc["b"]);

                Session["ImgURL"] = "/Img/AlgebraRegel2.jpg";

                Session["Steg1"] = "(" + a + " - " + b + ")²";
                Session["Steg2"] = a + "² - 2 · " + a + " · " + b + " + " + b + "²";
                Session["Steg3"] = Math.Pow(a, 2) + " - " + (2 * a * b) + " + " + Math.Pow(b, 2);
                Session["Steg4"] = null;
                Session["Svar"] = Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
                Session["Felmeddelande"] = null;
                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult AlgebraRegel3(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);
                int b = Convert.ToInt32(fc["b"]);

                Session["ImgURL"] = "/Img/AlgebraRegel3.jpg";

                Session["Steg1"] = "(" + a + " + " + b + ")(" + a + " - " + b + ")";
                Session["Steg2"] = a + "² - " + a + " · " + b + " + " + a + " · " + b + " - " + b + "²";
                Session["Steg3"] = a + "² - " + b + "²";
                Session["Steg4"] = Math.Pow(a, 2) + " - " + Math.Pow(b, 2);
                Session["Svar"] = Math.Pow(a, 2) - Math.Pow(b, 2);
                Session["Felmeddelande"] = null;
                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult AlgebraRegel4(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);
                int b = Convert.ToInt32(fc["b"]);

                Session["ImgURL"] = "/Img/AlgebraRegel4.jpg";

                Session["Steg1"] = "(" + a + " - " + b + ")³";
                Session["Steg2"] = a + "³ - 3 · "  + a + "² · " + b + " + 3 · " + a + " · " + b + "² - " + b + "³";
                Session["Steg3"] = Math.Pow(a, 3) + " - " + (Math.Pow(a, 2) * b) + " + " + (a * Math.Pow(b, 2)) + " - " + Math.Pow(b, 3);
                Session["Svar"] = Math.Pow(a, 3) - (Math.Pow(a, 2) * b) + (a * Math.Pow(b, 2)) - Math.Pow(b, 3);

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult AlgebraRegel5(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);
                int b = Convert.ToInt32(fc["b"]);

                Session["ImgURL"] = "/Img/AlgebraRegel5.jpg";

                Session["Steg1"] = "(" + a + " + " + b + ")³";
                Session["Steg2"] = a + "³ + 3 · " + a + "² · " + b + " + 3 · " + a + " · " + b + "² + " + b + "³";
                Session["Steg3"] = Math.Pow(a, 3) + " + " + (Math.Pow(a, 2) * b) + " + " + (a * Math.Pow(b, 2)) + " + " + Math.Pow(b, 3);
                Session["Svar"] = Math.Pow(a, 3) + (Math.Pow(a, 2) * b) + (a * Math.Pow(b, 2)) + Math.Pow(b, 3);

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult AlgebraRegel6(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);
                int b = Convert.ToInt32(fc["b"]);

                Session["Steg1"] = a + "³ + " + b + "³";
                Session["Steg2"] = "(" + a + " + " + b + ")(" + a + "² + 2 · " + a + " · " + b + " + " + b + "²)";
                Session["Steg3"] = a + b + "(" + (Math.Pow(a, 2) + " + " + (2 * a * b) + " + " + Math.Pow(b, 2)) + ")";
                Session["Steg4"] = a + b + " · " + (Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2));
                Session["Svar"] = (a + b) * (Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult AlgebraRegel7(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);
                int b = Convert.ToInt32(fc["b"]);

                Session["Steg1"] = a + "³ - " + b + "³";
                Session["Steg2"] = "(" + a + " - " + b + ")(" + a + "² - 2 · " + a + " · " + b + " + " + b + "²)";
                Session["Steg3"] = a - b + "(" + (Math.Pow(a, 2) + " - " + (2 * a * b) + " + " + Math.Pow(b, 2)) + ")";
                Session["Steg4"] = a - b + " · " + (Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2));
                Session["Svar"] = (a - b) * (Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult AlgebraRegelPQ(FormCollection fc)
        {
            try
            {
                double p = Convert.ToInt32(fc["p"]);
                double q = Convert.ToInt32(fc["q"]);
                double kvot = p / 2;
                double potens = Math.Pow(kvot, 2);

                @Session["ImgURL"] = "/Img/AlgebraRegelPQ.jpg";

                Session["Svar"] = "x₁ = " + ((Math.Sqrt(Math.Pow(kvot, 2) - q) - kvot) + "   " + "x₂ = " + (0 - (Math.Sqrt(potens - q) - kvot))) + " (Detta stämmer inte.)";

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult PotensRegel1(FormCollection fc)
        {
            try
            {
                double a = Convert.ToDouble(fc["a"]);
                double x = Convert.ToDouble(fc["x"]);
                double y = Convert.ToDouble(fc["y"]);
                double summa = x + y;

                @Session["ImgURL"] = "/Img/PotensRegel1.jpg";

                Session["Svar"] = (Math.Pow(a, summa));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult PotensRegel2(FormCollection fc)
        {
            try
            {
                double a = Convert.ToDouble(fc["a"]);
                double x = Convert.ToDouble(fc["x"]);
                double y = Convert.ToDouble(fc["y"]);
                double dif = x - y;

                @Session["ImgURL"] = "/Img/PotensRegel2.jpg";

                Session["Svar"] = (Math.Pow(a, dif));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult PotensRegel3(FormCollection fc)
        {
            try
            {
                double a = Convert.ToDouble(fc["a"]);
                double x = Convert.ToDouble(fc["x"]);
                double y = Convert.ToDouble(fc["y"]);
                double produkt = x * y;

                @Session["ImgURL"] = "/Img/PotensRegel3.jpg";

                Session["Svar"] = (Math.Pow(a, produkt));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult PotensRegel4(FormCollection fc)
        {
            try
            {
                double a = Convert.ToDouble(fc["a"]);
                double x = Convert.ToDouble(fc["x"]);
                double potens = Math.Pow(a, x);

                @Session["ImgURL"] = "/Img/PotensRegel5.jpg";

                Session["Svar"] = 1 / potens;

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult PotensRegel5(FormCollection fc)
        {
            try
            {
                double a = Convert.ToDouble(fc["a"]);
                double b = Convert.ToDouble(fc["b"]);
                double x = Convert.ToDouble(fc["x"]);
                double produkt = a * b;

                @Session["ImgURL"] = "/Img/PotensRegel5.jpg";

                Session["Svar"] = (Math.Pow(produkt, x));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult PotensRegel6(FormCollection fc)
        {
            try
            {
                double a = Convert.ToDouble(fc["a"]);
                double b = Convert.ToDouble(fc["b"]);
                double x = Convert.ToDouble(fc["x"]);
                double kvot = a / b;

                @Session["ImgURL"] = "/Img/PotensRegel6.jpg";

                Session["Svar"] = (Math.Pow(kvot, x));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult PotensRegel7(FormCollection fc)
        {
            try
            {
                double a = Convert.ToDouble(fc["a"]);
                double n = Convert.ToDouble(fc["n"]);
                double kvot = 1 / n;

                @Session["ImgURL"] = "/Img/PotensRegel7.jpg";

                Session["Svar"] = (Math.Pow(a, kvot));

                return RedirectToAction("Resultat");
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
        public ActionResult Absolutbelopp(FormCollection fc)
        {
            try
            {
                int a = Convert.ToInt32(fc["a"]);

                if (a < 0)
                {
                    @Session["ImgURL"] = "/Img/Absolutbelopp.jpg";

                    Session["Svar"] = a * -1;
                    return RedirectToAction("Resultat");
                }
                else
                {
                    @Session["ImgURL"] = "/Img/Absolutbelopp";

                    Session["Svar"] = a;
                    return RedirectToAction("Resultat");
                }
            }
            catch
            {
                Session["Steg1"] = null;
                Session["Steg2"] = null;
                Session["Steg3"] = null;
                Session["Steg4"] = null;
                Session["Svar"] = null;
                Session["Felmeddelande"] = "Du gjorde något fel, vänlig försök igen.";
                return RedirectToAction("Resultat");
            }
        }
    }
}