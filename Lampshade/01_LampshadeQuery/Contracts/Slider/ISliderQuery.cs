using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Slider
{
    public interface ISliderQuery
    {
        List<SliderQueryModel> GetSlider();
    }
}
