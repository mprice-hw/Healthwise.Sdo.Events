using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthwise.Sdo;

namespace Healthwise.Sdo.Events.Jira
{
    public class JiraIssueTransitionEvent : EventBase
    {
        public JiraIssue Issue { get; set; }
    }
}
