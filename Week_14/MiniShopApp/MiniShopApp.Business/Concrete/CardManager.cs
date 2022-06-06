using MiniShopApp.Business.Abstract;
using MiniShopApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class CardManager : ICardService
    {
        private ICardRepository _cardRepository;

        public CardManager(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public void InitializeCard(string userId)
        {
            _cardRepository.Create(new Entity.Card() { UserId = userId });
        }
    }
}
