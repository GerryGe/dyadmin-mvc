﻿using Dychar.Dyadmin.Web.Models.Common.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dychar.Dyadmin.Web.Views.Shared.Components.MenuTask
{
    public class MenuTaskViewComponent : ViewComponent
    {

        public MenuTaskViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            var messages = GetData();
            return View(messages);
        }

        private List<ModalMessageViewModel> GetData()
        {
            var messages = new List<ModalMessageViewModel>();
            messages.Add(new ModalMessageViewModel
            {
                Id = 1,
                ShortDesc = "Design some buttons",
                URLPath = "#",
                Percentage = 20,
            });

            return messages;
        }
    }
}
