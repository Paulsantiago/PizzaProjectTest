using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaProjectTest.Client.Pages
{
    public class Timer : ComponentBase
    {
        [Parameter]
        public double TimeInSeconds { get; set; }
        [Parameter]
        public Action Tick { get; set; }
        protected override void OnInitialized()
        {
            var timer = new System.Threading.Timer(
            callback: (_) => InvokeAsync(() => Tick?.Invoke()),
            state: null,
            dueTime: TimeSpan.FromSeconds(TimeInSeconds),
            period: Timeout.InfiniteTimeSpan
        );
        }
    }
}
