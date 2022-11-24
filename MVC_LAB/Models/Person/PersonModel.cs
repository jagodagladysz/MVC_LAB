namespace MVC_LAB.Models.Person
{
    public class PersonModel
    {
        public PersonModel()
        {

        }

        public int ID { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public string City { get; set; }

        public List<PersonModel> GetPersons()
        {
            return new List<PersonModel>()
            {
                new PersonModel()
                {
                    Name = "Andrzej",
                    City = "rzeszow",
                    Gender = GenderEnum.Male,
                    ID = 1,
                },
                new PersonModel()
                {
                    Name = "katarzyna",
                    City = "rzeszow",
                    Gender = GenderEnum.Female,
                    ID = 2,
                },
                new PersonModel()
                {
                    Name = "julia",
                    City = "krakow",
                    Gender = GenderEnum.Female,
                    ID = 3,
                },
                new PersonModel()
                {
                    Name = "piotr",
                    City = "warszawa",
                    Gender = GenderEnum.Male,
                    ID = 4,
                },

            };
        }
    }
}
