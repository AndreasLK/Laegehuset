namespace Laegehuset
{
    public class Consultation : Entity
    {
        public ConsultationType type { get; private set;}
        public DateTime startTime { get; private set; }
        public Doctor doctor { get; private set; }
        public Patient patient { get; private set; }

        public DateTime? endTime = null; //Udregnet

        private int buffer = 5;

        Consultation(ConsultationType type, DateTime startTime, Doctor doctor, Patient patient){
            SetStartTime(startTime);
            setType(type);
            this.doctor = doctor;
            this.patient = patient;
            }


        public void CalculateEndTime()
        {
            endTime = startTime.AddMinutes(type.duration + buffer);
        }

        public void SetStartTime(DateTime startTime)
        {
            if (startTime < DateTime.Now) throw new InvalidOperationException("Tid skal være i fremtiden -Ændre denne fejl når tidsmaskinen er opfundet");
            this.startTime = startTime;
        }

        public void setType(ConsultationType type)
        {
            this.type = type;
            CalculateEndTime();
        }

    }
}
