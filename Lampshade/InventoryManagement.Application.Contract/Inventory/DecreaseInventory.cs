﻿namespace InventoryManagement.Application.Contract.Inventory
{
    public class DecreaseInventory
    {
        public long InventoryId { get; set; }
        public long ProductId { get; set; }
        public long Count { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }

        public DecreaseInventory(long productId, long count, string description, long orderId)
        {
            ProductId = productId;
            Count = count;
            Description = description;
            OrderId = orderId;
        }

        public DecreaseInventory()
        {
            
        }
    }
}