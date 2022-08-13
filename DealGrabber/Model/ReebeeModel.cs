using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealGrabber.Model
{
    public class ReebeeModel
    {
        public Itemsearch itemSearch { get; set; }
    }

    public class Itemsearch
    {
        public Search[] search { get; set; }
    }

    public class Search
    {
        public Store store { get; set; }
        public Item item { get; set; }
        public int searchResultTypeID { get; set; }
    }

    public class Store
    {
        public string storeName { get; set; }
        public int storeID { get; set; }
    }

    public class Item
    {
        public float score { get; set; }
        public int itemID { get; set; }
        public int itemVersion { get; set; }
        public int pageID { get; set; }
        public int flyerID { get; set; }
        public int pageNumber { get; set; }
        public int statusID { get; set; }
        public string dateValid { get; set; }
        public string dateExpired { get; set; }
        public float xul { get; set; }
        public float yul { get; set; }
        public float xlr { get; set; }
        public float ylr { get; set; }
        public float xulFocus { get; set; }
        public float yulFocus { get; set; }
        public float xlrFocus { get; set; }
        public float ylrFocus { get; set; }
        public string titleEn { get; set; }
        public string descriptionEn { get; set; }
        public string descriptionFr { get; set; }
        public string sku { get; set; }
        public string itemUrlEn { get; set; }
        public string itemUrlFr { get; set; }
        public string urlTitleEn { get; set; }
        public string urlTitleFr { get; set; }
        public int itemClickActionID { get; set; }
        public int priority { get; set; }
        public Priceinfo priceInfo { get; set; }
        public Promotion[] promotion { get; set; }
        public string priceDescriptionEn { get; set; }
        public string priceDescriptionFr { get; set; }
        public Asset[] asset { get; set; }
        public string titleFr { get; set; }
    }

    public class Priceinfo
    {
        public decimal? price { get; set; }
        public Itemunit itemUnit { get; set; }
        public string priceDescriptionEn { get; set; }
        public string priceDescriptionFr { get; set; }
        public string salePriceDescriptionEn { get; set; }
        public string salePriceDescriptionFr { get; set; }
        public float priceMax { get; set; }
        public string dealDescriptionEn { get; set; }
    }

    public class Itemunit
    {
        public int itemUnitID { get; set; }
        public string itemUnitFr { get; set; }
        public string itemUnitEn { get; set; }
    }

    public class Promotion
    {
        public int promoID { get; set; }
        public string promoTitleEn { get; set; }
        public string promoTitleFr { get; set; }
        public string promoDescEn { get; set; }
        public string promoDescFr { get; set; }
        public int promoGroupID { get; set; }
        public string promoGroupNameEn { get; set; }
        public string promoGroupNameFr { get; set; }
        public int promoGroupShow { get; set; }
    }

    public class Asset
    {
        public string type { get; set; }
        public int version { get; set; }
        public int assetTypeID { get; set; }
        public int itemAssetID { get; set; }
        public string url { get; set; }
        public Contenttype[] contentType { get; set; }
    }

    public class Contenttype
    {
        public string extension { get; set; }
        public string type { get; set; }
        public Metadata[] metadata { get; set; }
    }

    public class Metadata
    {
        public string width { get; set; }
        public string height { get; set; }
    }
}
