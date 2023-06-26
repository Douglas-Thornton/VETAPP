﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETAPP.ViewModels
{
    public class Models
    {
        public class User
        {
            public int UserID { get; set; }
            public string FirstName { get; set; }
            public string Surname { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Suburb { get; set; }
            public string Postcode { get; set; }
            public string LoginUsername { get; set; }
            public string LoginPassword { get; set; }
            public string WebpageAnimalPreference { get; set; }

            public virtual ICollection<Pet> Pets { get; set; }
        }

        public class Pet
        {
            public int PetID { get; set; }
            public int OwnerID { get; set; }
            public string PetName { get; set; }
            public string PetBreed { get; set; }
            public string PetAge { get; set; }
            public string PetGender { get; set; }
            public string PetPhotoFileLocation { get; set; }
            public bool PetDiscoverability { get; set; }

            public virtual User Owner { get; set; }
        }

    }
}
