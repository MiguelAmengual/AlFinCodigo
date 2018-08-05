using System;
namespace AlFinCodigo
{
    public class PriorityTask : AbstractTask
    {
        private int priority;
        public PriorityTask(string title, int priority) : base(title)
        {
            this.Priority = priority;
        }


        public int Priority
        {
            get
            {
                return priority;
            }

            private set
            {
                EvaluatePriority(0, 999);
                this.priority = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Priority: " + Priority;
        }

        private void EvaluatePriority(int lowwerLimit, int supperLimit)
        {
            if (supperLimit > 999 || lowwerLimit < 0)
            {
                throw new ArgumentOutOfRangeException("The priority must be between 0 and 999");
            }
        }

    }
}