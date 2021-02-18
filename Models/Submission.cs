using System.ComponentModel.DataAnnotations;
//for the [Display()]

namespace FormSubmission.Models
{
    public class Submission
    {
        [Required(ErrorMessage = "First Name Required")]
        [MinLength(4, ErrorMessage="The First Name must be at least 4 characters.")]
        public string FirstName {get;set;}
        // [Display(Name="Release Date")]
        //replaces the asp-for
        //-----------------------------------------------------
        
        [Required(ErrorMessage = "Last Name required")]
        [MinLength(4, ErrorMessage="The Last Name must be at least 4 characters.")]
        public string LastName {get;set;}
        //-----------------------------------------------------

        [Required(ErrorMessage = "Age required")]
        public int Age {get;set;}
        //-----------------------------------------------------
        [Required(ErrorMessage = "Email required")]
        public string Email {get;set;}
        //-----------------------------------------------------
        [Required(ErrorMessage = "Password Required")]
        public string Password {get;set;}
        //-----------------------------------------------------
    } 
}