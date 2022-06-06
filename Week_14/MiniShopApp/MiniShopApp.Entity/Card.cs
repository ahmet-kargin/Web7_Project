using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Entity
{
    public class Card
    {
        public int CardId { get; set; }
        public string UserId { get; set; }
        public List<CardItem> cardItems { get; set; }
    }
}
