using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAPI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SalesAPIContext(
                serviceProvider.GetRequiredService<DbContextOptions<SalesAPIContext>>()))
            {
                if (context.SalesItem.Count() > 0)
                {
                    return;   // DB has been seeded
                }

                context.SalesItem.AddRange(
                    new SalesItem
                    {
                        Title = "[SSD] Samsung 1TB 860 EVO - $99 (36% off, Pbtech)",
                        Url = "https://images.samsung.com/is/image/samsung/uk-860-evo-sata-3-2-5-ssd-mz-76e4t0b-eu-rperspectiveblack-89335799?$PD_GALLERY_L_JPG$",
                        Tags = "SSD",
                        PublishDate = "20/11/2018 4:20pm",
                        UpvoteCount = 54,
                        Links = "https//otherlink.com/samsung-ssd",
                        Width = "760",
                        Height = "760"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
