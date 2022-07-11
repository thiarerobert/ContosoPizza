using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

//Attributs standard
[ApiController]
[Route("[controller]")]

//Création d'une classe PizzaController qui hérite de la classe ControllerBase
public class PizzaController: ControllerBase {
    public PizzaController(){
    
    }

    //Récupérer tous les pizzas
        [HttpGet]
        public ActionResult<List <Pizza>> GetAll() => 
        PizzaService.GetAll();
    
    //Récupérer un pizza par son ID
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);
        if(pizza ==null)
        return NotFound();
        return pizza;
    }
}