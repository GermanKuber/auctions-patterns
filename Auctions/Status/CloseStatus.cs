﻿using System;
using Auctions.Domain;

namespace Auctions.Status
{
    public class CloseStatus : IStatus
    {
        public AuctionStatusEnum Status { get; } = AuctionStatusEnum.Closed;

        public void Do()
        {
            Console.WriteLine("Estoy cerrado");
        }
    }
}