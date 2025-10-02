using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiPlanets.Models;

namespace MauiPlanets.Services
{
    internal class DwarfPlanetServices
    {
        private static List<DwarfPlanet> dwarfPlanets = new()
        {
            new()
            {
                Name = "Pluto",
                Subtitle = "Most famous dwarf planet",
                HeroImage = "pluto.png",
                Description = "Pluto use to be our 9th planet but got reclassified",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                  "https://science.nasa.gov/wp-content/uploads/2024/03/pluto-new-horizons-pia20291-16x9-1.jpg"
                }

            },
             new()
            {
                Name = "Ceres",
                Subtitle = "The only dwarf planet in the inner solar system",
                HeroImage = "ceres.png",
                Description = "Ceres was called an asteroid for many years",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                  "https://assets.science.nasa.gov/dynamicimage/assets/science/astro/exo-explore/internal_resources/598/Ceres.jpeg?w=1041&h=1041&fit=clip&crop=faces%2Cfocalpoint"
                }
            },
              new()
            {
                Name = "Haumea",
                Subtitle = "One of the fastest rotating large objects in our solar system",
                HeroImage = "hauema.png",
                Description = "Haumea is located in the Kuiper Belts, a doughnut-shaped region of icy bodies beyond the orbit of Neptune",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                  "https://i0.wp.com/spacenews.com/wp-content/uploads/2022/10/Screen-Shot-2022-10-18-at-6.38.28-PM.png?w=864&ssl=1"
                }
            },

            new()
            {
                Name = "MakeMake",
                Subtitle = "Second brightest object in Kuiper Belt",
                HeroImage = "makemake.png",
                Description = "Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Bel",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                  "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8-430-80.jpg.webp"
                }
            },
                new()
                {
                    Name = "Eris",
                    Subtitle = "The biggest dwarf planet",
                    HeroImage = "eris.png",
                    Description = "Eris is the second-largest known dwarf planet in the Solar System",
                    AccentColorStart = Color.FromArgb("#353535"),
                    AccentColorEnd = Color.FromArgb("#8d9098"),
                    Images = new()
                    {
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_eris_1600x900.jpg"
                    }
                }
        };

        public static List<DwarfPlanet> GetAllDwarfPlanets()
       => dwarfPlanets;
    }
}
