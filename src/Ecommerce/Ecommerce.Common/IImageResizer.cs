using SixLabors.ImageSharp;

namespace Ecommerce.Common
{
    public interface IImageResizer
    {
        string ImageResize(Image img, int MaxWidth, int MaxHeight);
    }
}
