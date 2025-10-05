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
                  "https://science.nasa.gov/wp-content/uploads/2024/03/pluto-new-horizons-pia20291-16x9-1.jpg",
                  "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/internal_resources/5091/Pluto-1.jpeg?w=1280&h=900&fit=clip&crop=faces%2Cfocalpoint",
                  "https://science.nasa.gov/wp-content/uploads/2024/10/poster-pluto-front-b-1.jpg?resize=582,900"
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
                  "https://assets.science.nasa.gov/dynamicimage/assets/science/astro/exo-explore/internal_resources/598/Ceres.jpeg?w=1041&h=1041&fit=clip&crop=faces%2Cfocalpoint",
                  "https://science.nasa.gov/wp-content/uploads/2024/03/ceres-dawn-pia19562-16x9-1.jpg?resize=600,338",
                  "https://science.nasa.gov/wp-content/uploads/2017/11/ceres-full-globe-pia21906-1920x640-1.jpg?resize=600,200"
                }
            },
              new()
            {
                Name = "Haumea",
                Subtitle = "One of the fastest rotating large objects in our solar system",
                HeroImage = "haumea.png",
                Description = "Haumea is located in the Kuiper Belts, a doughnut-shaped region of icy bodies beyond the orbit of Neptune",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                  "https://i0.wp.com/spacenews.com/wp-content/uploads/2022/10/Screen-Shot-2022-10-18-at-6.38.28-PM.png?w=864&ssl=1",
                  "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/h/haumea_th.jpg?w=320&h=240&fit=clip&crop=faces%2Cfocalpoint",
                  "https://www.universetoday.com/article_images/haumea_nasa.jpg"
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
                  "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8-430-80.jpg.webp",
                  "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/internal_resources/5067/Makemake_moon-1.jpeg?w=800&h=600&fit=clip&crop=faces%2Cfocalpoint",
                  "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/m/makemake_th.jpg?w=320&h=240&fit=clip&crop=faces%2Cfocalpoint"

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
                 "https://www.solarsystemscope.com/spacepedia/images/handbook/renders/eris.png",
                 "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/2023/09/e/ErisArtistConcept1200w.jpg?w=1200&h=900&fit=clip&crop=faces%2Cfocalpoint",
                 "https://assets.science.nasa.gov/dynamicimage/assets/science/psd/solar/internal_resources/3256/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun.jpeg?w=800&h=600&fit=clip&crop=faces%2Cfocalpoint"
                }
            }
        };

        public static List<DwarfPlanet> GetAllDwarfPlanets()
       => dwarfPlanets;
    }
}
