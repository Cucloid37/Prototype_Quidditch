using System.Collections.Generic;
using V2._0.Predicates;

namespace V2._0
{
    public class MoveController
    {
        //todo ведёт проверку на предикаты?

        public MoveController()
        {
            
        }

        public void SelectFlyer(IFlyer flyer)
        {
            flyer.IsCanMove.IsSelectedFlyer.Value = true;
            // flyer.LoadUI() ||  или где-то ещё вызывать метод загрузки характеристик view.LoadUI(IFlyer)
        }

        public void UnSelectFlyer(IFlyer flyer)
        {
            flyer.IsCanMove.IsSelectedFlyer.Value = false;
        }
    }
}