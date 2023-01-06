using System.ComponentModel.DataAnnotations;

namespace CollectiveStartUpClub.Models
{
    public class StartUpClub
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This information is required.")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "This information is required.")]
        public string InvestorSummary { get; set; }
        [Required(ErrorMessage = "This information is required.")]
        public string ASourceOfInspiration { get; set; }
        [Required(ErrorMessage = "This information is required.")]
        public string MarketOpportunity { get; set; }
        [Required(ErrorMessage = "This information is required.")]
        public string YourCompetitors { get; set; }
        [Required(ErrorMessage = "This information is required.")]
        public string CurrentPhaseOfTheProject { get; set; }
        [Required(ErrorMessage = "This information is required.")]
        public string PatentTrademarkApplicationDetailsOfTheProject { get; set; }
        [Required(ErrorMessage = "Your Growth Strategies are required.")]
        public string YourGrowthStrategies { get; set; }
        [Required(ErrorMessage = "Application Type is required.")]
        public string ApplicationType { get; set; }

        //[Display(Name ="Kullanıcı Adı", Prompt ="johndoe")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This information is required.")]
        public string Surname { get; set; }

        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "E-mail is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        public string TelNo { get; set; }

        [Required(ErrorMessage = "Education Status are required.")]
        public string EducationStatus { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

    }
}
