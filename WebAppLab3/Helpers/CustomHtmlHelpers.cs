using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppLab3.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlContent DisplayFlightSummary(this IHtmlHelper htmlHelper, string name, string description, int id)
        {
            var content = $"<strong>{name}</strong><p>{description}</p><a href=\"/Tickets/Book/{id}\">Book Now</a>";
            return new HtmlString(content);
        }
        public static IHtmlContent DisplaySeatInfo(this IHtmlHelper htmlHelper, string seatNumber, bool isBooked)
        {
            var status = isBooked ? "Booked" : "Available";
            var content = $"<div class='seat' data-seat-number='{seatNumber}' data-is-booked='{isBooked}'>{seatNumber} ({status})</div>";
            return new HtmlString(content);
        }
    }

}