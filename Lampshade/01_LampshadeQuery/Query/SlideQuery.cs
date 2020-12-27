using System.Collections.Generic;
using System.Linq;
using _01_LampshadeQuery.Contracts.Slider;
using ShopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class SlideQuery:ISliderQuery
    {
        private readonly ShopContext _shopContext;

        public SlideQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<SliderQueryModel> GetSlider()
        {
            return _shopContext.Sliders
                .Where(x => x.IsRemoved == false)
                .Select(x => new SliderQueryModel
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    BtnText = x.BtnText,
                    Heading = x.Heading,
                    UrlLink = x.UrlLink,
                    Title = x.Title,
                    Text=x.Text

                })
                .ToList();
        }
    }
}
