using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string GameId { get; set; }
        public string GamerId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal OrderPrice { get; set; }
    }
}
