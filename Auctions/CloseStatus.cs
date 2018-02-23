﻿using System;

namespace Auctions
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