using SneakersUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace SneakersUI.ViewModels
{
    public class SneakersViewModel
    {
        public ObservableCollection<Sneakers> sneakers { get; set; }
        public ObservableCollection<SneakerColor> sneakerColor { get; set; }

        public SneakersViewModel()
        {
            sneakers = new ObservableCollection<Sneakers>
            {
                new Sneakers { Name="NMD_R1 candy", Price="162",Picture="https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" },
                new Sneakers { Name="NMD_R1 pink white", Price="142",Picture="https://images.unsplash.com/photo-1552346154-21d32810aba3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80" },
                new Sneakers { Name="NMD_R1 mint pink", Price="179",Picture="https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=643&q=80" },
                new Sneakers { Name="NMD_R1 white mint", Price="154",Picture="https://images.unsplash.com/photo-1521093470119-a3acdc43374a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" }
            };

            sneakerColor = new ObservableCollection<SneakerColor>
            {
                //new SneakerColor { ColorOption = "#819e94" },
                //new SneakerColor { ColorOption = "#dde5ed" },
                //new SneakerColor { ColorOption = "#d6c2bf" }
          
                new SneakerColor { ColorOption = ColorConverters.FromHex("#819e94") },
                new SneakerColor { ColorOption = ColorConverters.FromHex("#dde5ed") },
                new SneakerColor { ColorOption = ColorConverters.FromHex("#d6c2bf") }
            };
        }
    }
}
