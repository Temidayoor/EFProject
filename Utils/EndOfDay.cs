using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFProject.Utils
{
    internal class EndOfDay
    {
        private List<string> _tasks = new List<string>();

        public EndOfDay(List<string> tasks)
        {
            _tasks = tasks;
        }

        public EndOfDay RemoveTax()
        {

            _tasks.Remove("Tax");
            return this;
        }

        public EndOfDay AddApproval(string approverName)
        {

            _tasks.Add($"Approval by {approverName}");
            return this;
        }

        public EndOfDay CheckSystem()
        {
            if (!_tasks.Contains("SHUTDOWN"))
                _tasks.Add("SHUTDOWN");

            return this;
        }

        public List<string> CloseDay()
        {
            return _tasks;
        }
    }
}
