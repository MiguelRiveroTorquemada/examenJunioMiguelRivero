
using Microsoft.AspNetCore.Mvc;
using LibroItem;
using Libros.Data;

namespace LibrosController;

[ApiController]
[Route("[Controller]")]

public class LibrosController : ControllerBase
{

    private readonly DataContext _context;

    public LibrosController(DataContext dataContext)
    {
        _context = dataContext;
    }

    [HttpGet]
    public ActionResult<List<LibroItems>> Get(){
    return Ok (_context.LibroItem);
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult<LibroItems> Get(int id)
    {
    var LibroItems = _context.LibroItem.Find(id);
        return LibroItems == null? NotFound()
            : Ok(LibroItems);
    }
    /*
    [HttpGet]
    public ActionResult<List<CarritoItems>> Get()
    {
        List<CarritoItems> carrito = _context.CarritoItem.ToList();
        return carrito == null? NoContent()
            : Ok(carrito);
    }
*/

    [HttpPost]
    public ActionResult<LibroItems> Post([FromBody] LibroItems likes)
    {
         LibroItems existingLibroItems= _context.LibroItem.Find(likes.id);
        if (existingLibroItems != null)
        {
            return Conflict("Ya existe un elemento ");
        }
        _context.LibroItem.Add(likes);
        _context.SaveChanges();

        string resourceUrl = Request.Path.ToString() + "/" + likes.id;
        return Created(resourceUrl, likes);
    }

    [HttpPut("{id:int}")]
    public ActionResult<LibroItems> Update([FromBody] LibroItems likes, int id)
    {
        LibroItems libroItemToUpdate = _context.LibroItem.Find(id);
        if (libroItemToUpdate == null)
        {
            return NotFound("Elemento del Peliculas no encontrado");
        }
        libroItemToUpdate.puntuacion = likes.puntuacion;
        libroItemToUpdate.id = likes.id;
        _context.SaveChanges();
        string resourceUrl = Request.Path.ToString() + "/" + likes.id;

        return Created(resourceUrl, likes);
    }
        [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        LibroItems libroItemToDelete = _context.LibroItem.Find(id);
        if (libroItemToDelete == null)
        {
            return NotFound("Elemento del peliculas no encontrado");
        }
        _context.LibroItem.Remove(libroItemToDelete);
        _context.SaveChanges();
        return Ok(libroItemToDelete);
    }

}
