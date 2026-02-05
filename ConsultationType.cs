namespace Laegehuset
{
    public class ConsultationType : Entity
    {
        public string name { get; set; }
        public int duration { get; private set; }

        ConsultationType(string name, int duration)
        {
            this.name = name;
            setDuration(duration);
        }

        public void setDuration(int duration)
        {
            if (duration <= 0) throw new InvalidOperationException("Varighed skal være positiv");
            this.duration = duration;
        }
    }
}
