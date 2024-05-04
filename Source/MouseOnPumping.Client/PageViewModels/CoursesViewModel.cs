using Microsoft.AspNetCore.Components;
using MouseOnPumping.Core;
using MouseOnPumping.Core.Models;

namespace MouseOnPumping.Client.PageViewModels
{
    public class CoursesViewModel : ComponentBase
    {
        [Inject]
        public required MouseClient Client { get; init; }
        [Inject]
        public required NavigationManager Navigation { get; init; }

        public List<AvailableСourse> Courses { get; private set; } = [
            new(0, "English for developers", "None", 24),
            new(0, "Многопоточный Python", "None", 35),
            new(0, "Алгоритмы на Python", "None", 14),
            new(0, "FRONTEND: HTML CSS JS", "None", 1),
            new(0, "Верстка и создание сайтов в Webflow", "None", 19)
        ];

        public readonly List<string> Urls = [
            "FrameE.svg",
            "FrameW.svg",
            "FrameHtml5.svg",
            "FramePython.svg"
        ];

        private int _iterator = 0;

        protected async override Task OnInitializedAsync()
        {
            if (!Client.IsAuthorized)
                Navigation.NavigateTo("/login");

            Courses = await Client.GetCoursesAsync();
            await base.OnInitializedAsync();
        }

        public string GetNextImageUrl()
        {
            _iterator = _iterator + 1;
            _iterator %= Urls.Count;
            return  "./images/courses-page/icons/" + Urls[_iterator];
        }
    }
}
