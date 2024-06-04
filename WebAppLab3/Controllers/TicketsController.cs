using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebAppLab3.Data;
using WebAppLab3.Models;

namespace WebAppLab3.Controllers
{
    public class TicketsController : Controller
    {
        private readonly AppDbContext _dbContext;

        public TicketsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var flights = _dbContext.Flights.Include(f => f.Seats).ToList();
            return View(flights);
        }

        public IActionResult Book(int id)
        {
            var selectedFlight = _dbContext.Flights
                .Include(f => f.Seats)
                .Include(f => f.Comments) 
                .FirstOrDefault(f => f.Id == id);

            if (selectedFlight == null)
            {
                return NotFound();
            }
            selectedFlight.Comments = selectedFlight.Comments.OrderByDescending(c => c.Likes - c.Dislikes).ToList();

            ViewData["FlightName"] = selectedFlight.Name;
            ViewData["FlightDescription"] = selectedFlight.Description;

            return View(selectedFlight);
        }

        [HttpPost]
        public IActionResult Book(int id, int selectedSeatId)
        {
            try
            {
                var selectedFlight = _dbContext.Flights.Include(f => f.Seats).FirstOrDefault(f => f.Id == id);
                if (selectedFlight == null)
                {
                    return NotFound();
                }

                var seatToBook = selectedFlight.Seats.FirstOrDefault(s => s.Id == selectedSeatId);

                if (seatToBook != null && !seatToBook.IsBooked)
                {
                    seatToBook.IsBooked = true;
                    _dbContext.SaveChanges();

                    return Ok();
                }

                return BadRequest($"Error booking seat. Seat with ID {selectedSeatId} may already be booked.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error booking seat: {ex}");
                return BadRequest("Error booking seat. An unexpected error occurred.");
            }
        }
        [HttpPost]
        public IActionResult AddComment(int id, string username, string message, int rating)
        {
            try
            {
                var selectedFlight = _dbContext.Flights.Include(f => f.Comments).FirstOrDefault(f => f.Id == id);
                if (selectedFlight == null)
                {
                    return NotFound();
                }

                var comment = new Comment
                {
                    Username = username,
                    Message = message,
                    Rating = rating,
                    Timestamp = DateTime.Now,
                    Likes = 0,
                    Dislikes = 0
                };

                selectedFlight.Comments.Add(comment);
                _dbContext.SaveChanges();

                return RedirectToAction("Book", new { id });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding comment: {ex}");
                return BadRequest("Error adding comment. An unexpected error occurred.");
            }
        }
        public IActionResult LikeComment(int commentId)
        {
            var comment = _dbContext.Comments.FirstOrDefault(c => c.Id == commentId);
            if (comment == null)
            {
                return NotFound();
            }

            comment.Likes++;
            _dbContext.SaveChanges();

            return Ok();
        }

        public IActionResult DislikeComment(int commentId)
        {
            var comment = _dbContext.Comments.FirstOrDefault(c => c.Id == commentId);
            if (comment == null)
            {
                return NotFound();
            }

            comment.Dislikes++;
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
