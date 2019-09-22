using System.Collections.Generic;

namespace Lab_2
{
    public class Storage
    {
        private List<Client> _clients = new List<Client>();
        private List<Cosmetic> _cosmetics = new List<Cosmetic>();

        public void AddCosmetic(Cosmetic cosmetic)
        {
        }

        public void SellCosmetic(Client client, Cosmetic cosmetic)
        {
        }

        public List<Cosmetic> GetCosmetics()
        {
            return new List<Cosmetic>();
        }
    }
}