namespace CleanArchitecture.Domain.Abstractions
{
    //Mutlaka bir class bağımlı olması lazım
    public abstract class Entity
    {
        //CONSTRUCTURE KULLADIM OTOMATİK GUİD DEĞERİ ALICAK
        public Entity() { 
           Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set;}
    }
}
