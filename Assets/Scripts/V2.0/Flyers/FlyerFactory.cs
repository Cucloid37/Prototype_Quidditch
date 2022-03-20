using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    
    
    public sealed class FlyerFactory : IFlyerFactory, IDisposable
    {
        private readonly Factory _factory;
        private readonly Descriptions _descriptions;
        private readonly GameObject flyers = new GameObject("Flyers");
        
        private GameObject referenceBeater;
        private GameObject referenceKeeper;
        private GameObject referenceSeeker;
        private GameObject referenceHunter;
        private GameObject prefabSquare;
        private GameObject prefabRing;

        public SubscriptionProperty<bool> IsAllLoad;
        public GameObject PrefabSquare => prefabSquare;
        public GameObject PrefabRing => prefabRing;

        public FlyerFactory(Factory factory, Descriptions descriptions)
        {
            _factory = factory;
            _descriptions = descriptions;
        }

        public async void LoadView()
        {
            referenceBeater = await _descriptions.GetFlyerDescription.GetView(_descriptions.GetFlyerDescription.PrefabBeater);
            referenceHunter = await _descriptions.GetFlyerDescription.GetView(_descriptions.GetFlyerDescription.PrefabHunter);
            referenceKeeper = await _descriptions.GetFlyerDescription.GetView(_descriptions.GetFlyerDescription.PrefabKeeper);
            referenceSeeker = await _descriptions.GetFlyerDescription.GetView(_descriptions.GetFlyerDescription.PrefabSeeker);

            prefabSquare = await _descriptions.SquareDescription.GetView();
            prefabRing = await _descriptions.RingDescription.GetView();

            if (referenceBeater != null && referenceHunter != null && referenceKeeper != null && referenceSeeker != null
            && prefabSquare != null)
            {
                /*referenceBeater.SetActive(false);
                referenceSeeker.SetActive(false);
                referenceKeeper.SetActive(false);
                referenceHunter.SetActive(false);
                prefabSquare.SetActive(false);*/

                // IsAllLoad.Value = true;
            }
            else 
                Debug.LogError("Мы что-то не загрузили");
        }

        public IFlyer CreateFlyer(FlyerType type)
        {
            if (referenceBeater == null || referenceHunter == null || referenceKeeper == null || referenceSeeker == null)
            {
                new NullReferenceException($"Flyer is null: {referenceBeater.GetHashCode()}, {referenceHunter.GetHashCode()}, " +
                                           $"{referenceKeeper.GetHashCode()}, {referenceSeeker.GetHashCode()}");
            }
           
            FlyerModel model = _descriptions.GetFlyerDescription.GetModel;
            Broom broom = new Broom();                              // todo брать Broom и MagicWand откуда-то
            MagicWand magicWand = new MagicWand();                 // Вероятнее всего в FlyersInitialization
                                                                  // todo это костыль
            model.SetBroom(broom);
            model.SetWand(magicWand);

            GameObject go;
            IFlyer _presenter = new Flyer();
            
            switch (type)
            {
                case FlyerType.Hunter:
                    go = _factory.CreateWithGo(referenceHunter);
                    _presenter = new HunterPresenter(model, go.AddComponent<FlyerView>(), type);
                    break;
                case FlyerType.Seeker:
                    go = _factory.CreateWithGo(referenceSeeker);
                    _presenter = new SeekerPresenter(model, go.AddComponent<FlyerView>(), type);
                    break;
                case FlyerType.Beater:
                    go = _factory.CreateWithGo(referenceBeater);
                    _presenter = new BeaterPresenter(model, go.AddComponent<FlyerView>(), type);
                    break;
                case FlyerType.Keeper:
                    go = _factory.CreateWithGo(referenceKeeper);
                    _presenter = new KeeperPresenter(model, go.AddComponent<FlyerView>(), type);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            
            model.SetView(go.GetComponent<FlyerView>());
            go.gameObject.SetActive(true);
            go.transform.SetParent(flyers.transform);
            
            return _presenter;
        }

        public void Dispose()
        {
            referenceBeater.SetActive(true);
            referenceSeeker.SetActive(true);
            referenceKeeper.SetActive(true);
            referenceHunter.SetActive(true);
            prefabSquare.SetActive(true);
        }
    }
}