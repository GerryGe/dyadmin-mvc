using Dychar.Dyadmin.Web.Models.Common.Modals;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Dychar.Dyadmin.Web.Views.Shared.Components.MenuMessage
{
    public class MenuMessageViewComponent : ViewComponent
    {

        public MenuMessageViewComponent()
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
                UserId = Guid.NewGuid().ToString(),
                DisplayName = "Support Team",
                AvatarURL = "/dist/img/avatar2.png",
                ShortDesc = "Why not buy a new awesome theme?",
                TimeSpan = "5 mins",
                URLPath = "#",
            });

            messages.Add(new ModalMessageViewModel
            {
                Id = 1,
                UserId = Guid.NewGuid().ToString(),
                DisplayName = "Ken",
                AvatarURL = "/dist/img/avatar3.png",
                ShortDesc = "For approval",
                TimeSpan = "15 mins",
                URLPath = "#",
            });

            return messages;
        }
    }
}
