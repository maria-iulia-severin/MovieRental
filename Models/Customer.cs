using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Customer
    {
        public int Id { get; set; }

        /*Overriding Default Conventions se numeste Data Annotations și am folosit în modelul Customer.cs unde 
         am constrans proprietatea Name sa not nullable și cu o dimensiune maxima de 255 de caractere.*/
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}