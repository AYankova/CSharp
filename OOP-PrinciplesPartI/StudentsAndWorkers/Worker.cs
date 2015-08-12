namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary can't be a negative number!");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException("Working hours are in the range [0;24]!");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = 0;

            try
            {
              result = this.WeekSalary / (5 * this.WorkHoursPerDay);
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("Name: {0,-10} {1,-10} Money per hour: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}

