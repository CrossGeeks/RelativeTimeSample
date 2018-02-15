using System;
using System.Collections.ObjectModel;
using RelativeTimeSample.Models;

namespace RelativeTimeSample.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<News> News { get; set; }
        public MainPageViewModel()
        {
            News = new ObservableCollection<News>()
            {
                {new Models.News(){Title="Lorem Ipsum is simply dummy text", Date= DateTime.Now.AddDays(1), Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. "} },
                {new Models.News(){Title="Lorem Ipsum is simply", Date= DateTime.Now.AddDays(-5), Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. "} },
                {new Models.News(){Title="Lorem Ipsum is simply", Date= DateTime.Now.AddDays(-7), Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. "} },
                {new Models.News(){Title="Lorem Ipsum is simply", Date= DateTime.Now.AddDays(-30), Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy."} },
                {new Models.News(){Title="Lorem Ipsum is simply", Date= DateTime.Now.AddDays(-60), Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. "} },
                {new Models.News(){Title="Lorem Ipsum is simply", Date= DateTime.Now.AddDays(-90), Detail="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. "} },
            };
        }
    }
}
