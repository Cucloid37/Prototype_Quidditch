using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    
    
    public class FlyerFactory : Factory, IFlyerFactory
    {
        private AssetReference _assetReference;
       
        
        public virtual IFlyer CreateFlyer(FlyerType type)
        {
            _assetReference = _peaceDescriptions.FlyerDescription.DictAsset[type];
            GameObject flyer = CreateWithTask(_peaceDescriptions.FlyerDescription.GetView(_assetReference));
            FlyerView view = flyer.AddComponent<FlyerView>();
            FlyerModel model = _peaceDescriptions.FlyerDescription.GetModel;
            Broom broom = new Broom();                              // todo брать Broom и MagicWand из _description
            MagicWand magicWand = new MagicWand();                 //
            IFlyer _presenter = new Flyer();                      // todo это какой-то костыль или норм?
                                                                 
            switch (type)
            {
                case FlyerType.Hunter:
                    _presenter = new HunterPresenter(model, view, broom, magicWand);
                    break;
                case FlyerType.Seeker:
                    _presenter = new SeekerPresenter(model, view, broom, magicWand);
                    break;
                case FlyerType.Beater:
                    _presenter = new BeaterPresenter(model, view, broom, magicWand);
                    break;
                case FlyerType.Keeper:
                    _presenter = new KeeperPresenter(model, view, broom, magicWand);
                    break;
            }

            return _presenter;
        }
        
    }
}