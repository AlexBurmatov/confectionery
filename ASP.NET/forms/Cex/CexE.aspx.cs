﻿/*flexberryautogenerated="false"*/

namespace IIS.АСУ_Кондитерская
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Business;

    public partial class ЦехE : BaseEditForm<Цех>
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ЦехE()
            : base(Цех.Views.ЦехE)
        {
        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Cex/CexE.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {

        }

        /// <summary>
        /// Здесь лучше всего писать бизнес-логику, оперируя только объектом данных.
        /// </summary>
        protected override void PreApplyToControls()
        {
            var ds = DataServiceProvider.DataService;
            var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Цех), "ЦехE");
            var objs = ds.LoadObjects(lcs);
            if (objs.Length!=0)
            {
                DataObject = (Цех)objs[0];
            }
            else
            {
                DataObject = new Цех() { Номер = 1, Адрес="ул. Пермская, 26" };
                ds.UpdateObject(DataObject);
            }
        }

        /// <summary>
        /// Здесь лучше всего изменять свойства контролов на странице,
        /// которые не обрабатываются WebBinder.
        /// </summary>
        protected override void PostApplyToControls()
        {
            Page.Validate();
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }

        /// <summary>
        /// Валидация объекта для сохранения.
        /// </summary>
        /// <returns>true - продолжать сохранение, иначе - прекратить.</returns>
        protected override bool PreSaveObject()
        {
            return base.PreSaveObject();
        }

        /// <summary>
        /// Нетривиальная логика сохранения объекта.
        /// </summary>
        /// <returns>Объект данных, который сохранился.</returns>
        protected override DataObject SaveObject()
        {
            return base.SaveObject();
        }
    }
}