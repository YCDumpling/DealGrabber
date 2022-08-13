using DealGrabber.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebPWrapper;

namespace DealGrabber.ViewModel
{
    public class ReebeeViewModel
    {
        public List<ReebeeItemViewModel> ReebeeItems;

        public ReebeeViewModel()
        {
            ReebeeItems = new List<ReebeeItemViewModel>();
        }

    }

    public class ReebeeItemViewModel
    {
        public string StoreName { get; set; }
        public string ItemName { get; set; }
        public DateTime DateValid { get; set; }
        public DateTime DateExpired { get; set; }

        public Image Image { get; set; }
        public string SaleDescription { get; set; }

        public decimal Price { get; set; }

        public ReebeeItemViewModel(Search item)
        {
            StoreName = item.store.storeName;
            ItemName = item.item.titleEn;
            DateValid = DateTime.Parse(item.item.dateValid);
            DateExpired = DateTime.Parse(item.item.dateExpired);
            SaleDescription = item.item.priceInfo.salePriceDescriptionEn;
            // Format picture:
            var pictureUrl = item.item.asset[0].url
                .Replace("<width>", item.item.asset[0].contentType[0].metadata[0].width)
                .Replace("<height>", item.item.asset[0].contentType[0].metadata[0].height)
                + item.item.asset[0].contentType[0].extension;

            Image = GetImageFromUrl(pictureUrl);

            if (item.item.priceInfo != null)
            {
                Price = item.item.priceInfo.price.GetValueOrDefault();
            }
            
        }

        public Image GetImageFromUrl(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response =  client.GetAsync(url).Result;
                var content =  response.Content.ReadAsByteArrayAsync().Result;
                using (WebP webp = new WebP())
                {
                    //var Image = webp.Decode(content);
                    var Image = webp.GetThumbnailFast(content, 250, 450);
                    return Image;
                }
            }
        }
    }
}
