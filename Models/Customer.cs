using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCoreMySQL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Buildings = new HashSet<Building>();
        }

        public long id { get; set; }
        public long? user_id { get; set; }
        public string? company_name { get; set; }
        public string? company_headquarters_address { get; set; }
        public string? full_name_of_the_company_contact { get; set; }
        public string? company_contact_phone { get; set; }
        public string? email_of_the_company_contact { get; set; }
        public string? company_description { get; set; }
        public string? full_name_of_service_technical_authority { get; set; }
        public string? technical_authority_phone_for_service { get; set; }
        public string? technical_manager_email_for_service { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime? customer_creation_date { get; set; }
        public long? address_id { get; set; }
        [ForeignKey("address_id")]
        public virtual Address? Address { get; set; }
        [ForeignKey("user_id")]
        public virtual User? User { get; set; }
        // [ForeignKey("building_id")]
        public virtual ICollection<Building> Buildings { get; set; }
    }
}
