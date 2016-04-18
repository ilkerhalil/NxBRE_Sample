using System;

namespace NxBRE_Sample
{
    public class Shop
    {
        public string ShopCode { get; set; }

        public string VKorg { get; set; }

        public override string ToString()
        {
            
            return $"ShopCode: {ShopCode}, VKorg: {VKorg}";
        }

        
    }
}