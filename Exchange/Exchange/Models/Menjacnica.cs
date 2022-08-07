namespace Exchange.Models
{
    public class Menjacnica
    {
        public int Id { get; set; }
        public string disclaimer { get; set; }
        public int timestamp { get; set; }
        public string Base { get; set; }
        public Rates rates { get; set; }
        public Menjacnica(int id, string disclaimer, int timestamp, string @base)
        {
            Id = id;
            this.disclaimer = disclaimer;
            this.timestamp = timestamp;
            Base = @base;

        }
        public Menjacnica()
        {

        }
    }
}
