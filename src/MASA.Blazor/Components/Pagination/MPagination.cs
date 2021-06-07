﻿using BlazorComponent;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASA.Blazor
{
    public partial class MPagination : BPagination
    {
        [Parameter]
        public bool Circle { get; set; }

        [Parameter]
        public bool Disabled { get; set; }

        [Parameter]
        public bool Dark { get; set; }

        protected override void SetComponentClass()
        {
            CssProvider
                .Apply(cssBuilder =>
                {
                    cssBuilder
                        .Add("m-pagination")
                        .AddIf("m-pagination--circle", () => Circle)
                        .AddIf("m-pagination--disabled", () => Disabled)
                        .AddTheme(Dark);
                })
                .Apply("navigation-prev", cssBuilder =>
                {
                    cssBuilder
                        .Add("m-pagination__navigation")
                        .AddIf("m-pagination__navigation--disabled", () => PrevDisabled);
                })
                .Apply("navigation-next", cssBuilder =>
                {
                    cssBuilder
                        .Add("m-pagination__navigation")
                        .AddIf("m-pagination__navigation--disabled", () => NextDisabled);
                })
                .Apply("more", cssBuilder =>
                {
                    cssBuilder
                        .Add("m-pagination__more");
                })
                .Apply("current-item", cssBuilder =>
                {
                    cssBuilder
                        .Add("m-pagination__item")
                        .Add("m-pagination__item--active")
                        .AddBackgroundColor(Color);
                })
                .Apply("item", cssBuilder =>
                {
                    cssBuilder
                        .Add("m-pagination__item");
                });

            AbstractProvider
                .Apply<BIcon, MIcon>();
        }
    }
}
