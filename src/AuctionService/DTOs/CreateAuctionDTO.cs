using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public record CreateAuctionDTO
(
    [Required]
    string Make,

    [Required]
    string Model,

    [Required]
    int Year,

    [Required]
    string Color,

    [Required]
    int Mileage,

    [Required]
    string ImageUrl,

    [Required]
    int ReservePrice,

    [Required]
    DateTime AuctionEnd
);