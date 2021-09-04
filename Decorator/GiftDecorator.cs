using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
  //  Decorator class implements the component interface and it has a HAS-A relationship with the component interface.
  //  The component variable should be accessible to the child decorator classes, so we will make this variable protected.
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
