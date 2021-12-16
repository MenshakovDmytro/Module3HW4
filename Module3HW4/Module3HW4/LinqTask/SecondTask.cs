using System.Linq;
using System.Collections.Generic;

namespace Module3HW4.LinqTask
{
    public class SecondTask
    {
        public void CallLinqMethods(List<Contact> list)
        {
            var firstOrDefaultElement = list.FirstOrDefault();
            var youngContacts = list.Where(w => w.Age < 25);
            var modifiedNumbers = list.Select(s => s.PhoneNumber.Insert(0, "+"));
            var amountOfOlderContacts = list.Count(c => c.Age > 25);
            var sortedContacts = list.OrderBy(o => o.Age).ThenBy(t => t.FirstName);
            var averageAge = list.Average(a => a.Age);
            var groupedElements = list.Take(3);
        }
    }
}