using System;
using System.Collections;
using System.Diagnostics;
using NxBRE.FlowEngine;
using NxBRE.FlowEngine.Factories;
using NxBRE.FlowEngine.IO;
using NxBRE.Util;

namespace NxBRE_Sample
{
    public class ShopFactory
    {
        private readonly IFlowEngine flowEngine;

        public ShopFactory()
        {
            var aXMLFile = "ShopRule.xbre";
            flowEngine = new BREFactoryConsole(SourceLevels.ActivityTracing, SourceLevels.Warning).NewBRE(new XBusinessRulesFileDriver(aXMLFile));
            if (flowEngine == null) throw new System.Exception("BRE Not Properly Initialized!");

            flowEngine.RuleContext.SetFactory("SetShop", new BRERuleFactory(SetShop));

        }

        public void Execute(ref Shop shop)
        {

            flowEngine.RuleContext.SetObject("CurrentShop", shop);
            if (!flowEngine.Process()) throw new Exception();
            shop = flowEngine.RuleContext.GetResult("CurrentShop").Result as Shop;
        }

        public object SetShop(IBRERuleContext aBrc, IDictionary aMap, object aStep)
        {
            var shop = aBrc.GetObject("CurrentShop") as Shop;
            var vkorg = (string)Reflection.CastValue(aMap["vKorg"], typeof(string));
            if (shop == null) return null;
            shop.VKorg = vkorg;
            return shop;
        }


    }
}