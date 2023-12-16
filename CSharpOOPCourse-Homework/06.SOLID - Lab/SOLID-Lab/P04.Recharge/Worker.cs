using P04.Recharge.Contracts;

namespace P04.Recharge
{
    public abstract class Worker : IIdentifiable, IWorker
    {
        public Worker(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }

        public int WorkingHours { get; private set; }

        public virtual void Work(int hours)
        {
            this.WorkingHours += hours;
        }
    }
}