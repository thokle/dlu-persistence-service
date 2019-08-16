using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class UdsendingKontakter
    {
        private int? bladId;
        private int id;
        private string name;
        private string email;
        private string kontaktType;
        private int? telefonnummer;
        private string titel;
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string KontaktType { get => kontaktType; set => kontaktType = value; }
        public int? Telefonnummer { get => telefonnummer; set => telefonnummer = value; }
        public int? BladId { get => bladId; set => bladId = value; }
        public int Id { get => id; set => id = value; }
        public string Titel { get => titel; set => titel = value; }
    }
}
