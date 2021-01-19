using Microsoft.Xaml.Interactivity;
using Syncfusion.UI.Xaml.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleUWP
{
    public class SchedulerBehavior : Behavior<SfSchedule>
    {
        SfSchedule schedule;
        protected override void OnAttached()
        {
            base.OnAttached();
            schedule = this.AssociatedObject;
            this.AssociatedObject.CollapsedHours.Add(new ScheduleCollapsedHour()
            {
                StartHour = 1,
                EndHour = 4,
            });
            this.AssociatedObject.CollapsedHours.Add(new ScheduleCollapsedHour()
            {
                StartHour = 6,
                EndHour = 8,
            });
            this.AssociatedObject.CollapsedHours.Add(new ScheduleCollapsedHour()
            {
                StartHour = 9,
                EndHour = 11,
            });
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();    
            this.schedule = null;
        }
    }
}
  