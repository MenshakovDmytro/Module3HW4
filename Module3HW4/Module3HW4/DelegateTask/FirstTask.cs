using System;

namespace Module3HW4.DelegateTask
{
    public class FirstTask
    {
        public event Func<double, double, double> SumEvent;

        public double Sum(double x, double y) => x + y;

        public double CountSum(double x, double y)
        {
            var sum = 0D;
            SumEvent += Sum;
            SumEvent += Sum;
            foreach (Func<double, double, double> func in SumEvent.GetInvocationList())
            {
                sum += func.Invoke(x, y);
            }

            return sum;
        }

        public void TryCatch(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}