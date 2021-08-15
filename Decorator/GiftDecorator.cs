using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
   public class GiftDecorator : IGiftComponent
    {
        protected IGiftComponent giftComponent;
        public GiftDecorator(IGiftComponent giftComponent)
        {
            this.giftComponent = giftComponent;
        }

        public virtual double GetCost()
        {
            return giftComponent.GetCost();
        }

        public virtual string PackGiftItem()
        {
           return giftComponent.PackGiftItem();
        }
    }
}
