using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp.Model
{
    public class PropertyRepo
    {
        public static List<Property> AllProperties => new List<Property>
        {
            new Property
            {
                Address = "Manhattan, New York",
                Price = 350550,
                DefaultImage = "https://hips.hearstapps.com/hmg-prod/images/luxury-traditonal-styled-home-royalty-free-image-1727378799.jpg?crop=1xw:0.81946xh;center,top&resize=1200:*",
                Images = new List<string>
                {
                    "https://cdn.pixbay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                }
            },
            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage = "https://town-n-country-living.com/wp-content/uploads/2023/06/craftsman-exterior.jpg",
                Images = new List<string>
                {
                    "https://cdn.pixbay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                    "https://cdn.pixbay.com/photo/2019/10/17/02/39/villa-4555815_640.jpg",
                    "https://cdn.pixbay.com/photo/2017/10/16/02/20/property-staging-2855944_640.jpg"
                }
            },
            new Property
            {
                Address = "Brooklyn, New York",
                Price = 250000,
                DefaultImage = "https://res.cloudinary.com/brickandbatten/images/w_464,h_283,dpr_2/f_auto,q_auto/v1713267421/wordpress_assets/313364-Alabaster-Caviar-TeakStain-A-copy/313364-Alabaster-Caviar-TeakStain-A-copy.jpg?_i=AA",
                Images = new List<string>
                {
                    "https://cdn.pixbay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                    "https://cdn.pixbay.com/photo/2019/10/17/02/39/villa-4555815_640.jpg"
                }
            },
            new Property
            {
                Address = "Manhattan, New York",
                Price = 400500,
                DefaultImage = "https://static.schumacherhomes.com/umbraco/media/wvflutbh/image4.jpg?format=webp",
                Images = new List<string>
                {
                    "https://cdn.pixbay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixbay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                    "https://cdn.pixbay.com/photo/2019/10/17/02/39/villa-4555815_640.jpg",
                    "https://cdn.pixbay.com/photo/2017/10/16/02/20/property-staging-2855944_640.jpg"
                }
            }
        };
    }
}
