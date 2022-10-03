using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdo;

namespace Sdo.Events.Jira
{
    internal class JiraIssueTransitionEvent : EventBase
    {
        public JiraIssue Issue { get; set; }
    }
}
