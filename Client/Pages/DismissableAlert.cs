using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaProjectTest.Client.Pages
{
    public partial class DismissableAlert
    {

        private bool show;
        [Parameter]
        public bool Show
        {
            get => this.show;
            set
            {
                if (value != this.show)
                {
                    this.show = value;
                    ShowChanged?.Invoke(this.show);
                }
            }
        }
        [Parameter]
        public Action<bool> ShowChanged { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        public void Dismiss()
        => Show = false;
    }
}
