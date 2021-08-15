using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /* The base Decorator class follows the same interface as the other
       components. The primary purpose of these class is to define the wrapping
       interface for all concrete decorators.
    */
    public class PurpleWrapper : GiftDecorator
    {
        public PurpleWrapper(IGiftComponent giftComponent) : base(giftComponent)
        { }
        public override double GetCost()
        {
            return base.GetCost() + 1;
        }
        public override string PackGiftItem()
        {
            return $"{base.PackGiftItem()} Purple Wrapper Added";
        }
    }
    public class BlueRibbon : GiftDecorator
    {
        public BlueRibbon(IGiftComponent giftComponent) : base(giftComponent)
        { }
        public override double GetCost()
        {
            return base.GetCost() + 1;
        }
        public override string PackGiftItem()
        {
            return  $"{base.PackGiftItem()} Blue Ribbon Added";
        }
    }
}
