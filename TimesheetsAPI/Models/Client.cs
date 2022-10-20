using System.ComponentModel.DataAnnotations;

namespace TimesheetsAPI.Models
{
    public class Client
    {

        public Client(int clientId, string companyName, string billingAddress, string contactName, string contactTelephone, string contactEmail)
        {
            ClientId = clientId;
            CompanyName = companyName;
            BillingAddress = billingAddress;
            ContactName = contactName;
            ContactTelephone = contactTelephone;
            ContactEmail = contactEmail;
        }

        public int ClientId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string BillingAddress { get; set; }

        [Required]
        public string ContactName { get; set; }

        //nullable, maybe they dont have a contact number??
        public string ContactTelephone { get; set; }

        public string ContactEmail { get; set; }

    }
}
