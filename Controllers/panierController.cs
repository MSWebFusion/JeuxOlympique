using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using JeuxOlympique.Models;
using Microsoft.AspNet.Identity;

namespace JeuxOlympique.Controllers
{
    public class panierController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: panier
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            List<panier> paniers = db.paniers.ToList().Where(u => u.UserId == User.Identity.GetUserId() && u.paye == false).ToList() ;

            return View(paniers);
        }

        // GET: panier/Details/5
        public ActionResult Details(int? idOffre)
        {
            if (idOffre == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panier MonPanier = new panier();
            if (!User.Identity.IsAuthenticated)
            {
                // Rediriger l'utilisateur vers une page de connexion
                return RedirectToAction("Login", "Account"); // Assurez-vous de remplacer "Login" et "Account" par les noms appropriés de vos contrôleurs et actions de connexion
            }
            try
            {
                MonPanier.UserId = User.Identity.GetUserId();
                MonPanier.Offre = db.Offres.Find(idOffre); ;
                MonPanier.Quantite = 1;

                db.paniers.Add(MonPanier);
                db.SaveChanges();
                Session["Quantity"] = db.paniers.ToList().Where(u => u.UserId == User.Identity.GetUserId() && u.paye == false).ToList().Sum(u => u.Quantite);
            }
            catch (Exception)
            {
                return RedirectToAction("OffresClientView", "Offres");
            }

            ViewData["Offre"] = db.Offres.Find(idOffre);

            return RedirectToAction("Index"); ;
        }

        // GET: panier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: panier/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PanierID,TypeOffre,NombrePersonnes,Prix")] panier panier)
        {
            if (ModelState.IsValid)
            {
                db.paniers.Add(panier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(panier);
        }

        // GET: panier/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panier panier = db.paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // POST: panier/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PanierID, UserId, Quantite")] panier panier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(panier).State = EntityState.Modified;
                db.SaveChanges();
                Session["Quantity"] = db.paniers.ToList().Where(u => u.UserId == User.Identity.GetUserId() && u.paye == false).ToList().Sum(u => u.Quantite);

                return RedirectToAction("Index");
            }
            return View(panier);
        }

        // GET: panier/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panier panier = db.paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // POST: panier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            panier panier = db.paniers.Find(id);
            db.paniers.Remove(panier);
            db.SaveChanges();
            Session["Quantity"] = db.paniers.ToList().Where(u => u.UserId == User.Identity.GetUserId() && u.paye == false).ToList().Sum(u => u.Quantite);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Payer()
        {
            List<panier> MonPanier = db.paniers.ToList().Where(u => u.UserId == User.Identity.GetUserId() && u.paye == false).ToList();
            Session["Quantity"] = db.paniers.ToList().Where(u => u.UserId == User.Identity.GetUserId() && u.paye == false).ToList().Sum(u => u.Quantite);


            return View(MonPanier);
        }

        public ActionResult SupprimerPanier(int id)
        {
            panier monPanier = db.paniers.Find(id);

            db.paniers.Remove(monPanier);

            return RedirectToAction("OffresClientView", "Offres");
        }

        public ActionResult ViderPanier()
        {
            // Récupérer les éléments du panier de l'utilisateur actuellement connecté
            var userId = User.Identity.GetUserId();
            List<panier> paniers = db.paniers.ToList().Where(u => u.UserId == User.Identity.GetUserId() && u.paye == false).ToList();

            // Supprimer tous les éléments du panier
            foreach (var item in paniers)
            {
                item.paye = true;
            }

            db.SaveChanges(); // Sauvegarder les modifications dans la base de données

            // Retourner un statut HTTP 200 (OK) pour indiquer que la suppression a réussi
            return Json(new { success = true });
        }

        //public ActionResult validationPaiement(int id)
        //{
        //    //Création du envoie du mail avec les informations demandé
        //    return RedirectToAction("OffresClientView", "Offres");
        //}



    }
}
