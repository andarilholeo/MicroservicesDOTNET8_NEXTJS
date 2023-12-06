﻿namespace AuctionService.DTOs;

public record AuctionDTO
(
    Guid Id,
    int ReservePrice,
    string Seller,
    string Winner,
    int? SoldAmount,
    int? CurrentHighBid,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    DateTime AuctionEnd,


    string Status
);