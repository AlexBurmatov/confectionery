﻿/*flexberryautogenerated="false"*/

namespace IIS.АСУ_Кондитерская
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Web.Tools.WGEFeatures;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
    using ICSSoft.STORMNET.Business;

    public partial class ЗаказE : BaseEditForm<Заказ>
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ЗаказE()
            : base(Заказ.Views.ЗаказE)
        {
        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Zakaz/ZakazE.aspx"; }
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
            SQLWhereLanguageDef ld = SQLWhereLanguageDef.LanguageDef;
            if (Context.User.IsInRole("Продавец") && this.DataObject == null)
            {
                // Определяем текущего пользователя
                var currentUser = Context.User.Identity.Name;
                IDataService ds = DataServiceProvider.DataService;
                var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Продавец), "ПродавецL");                
                lcs.LimitFunction = ld.GetFunction(ld.funcEQ,
                    new VariableDef(ld.StringType, Information.ExtractPropertyPath<Продавец>(x => x.Логин)), currentUser);
                var manager = ds.LoadObjects(lcs)[0] as Продавец;

                // Устанавливаем текущего продавца в поле заказа
                this.DataObject = new Заказ();
                this.DataObject.ТорговаяТочка = manager.ТорговаяТочка;
                ctrlТорговаяТочка.Enabled = false;
            }

            ctrlСтрокаЗаказа.AddLookUpSettings(Information.ExtractPropertyPath<СтрокаЗаказа>(r => r.Продукт), new LookUpSetting
            {
                LimitFunction = ld.GetFunction(ld.funcEQ,
                    new VariableDef(ld.StringType, Information.ExtractPropertyPath<Продукт>(r => r.Статус)), "В продаже"),
                ColumnsSort = new ColumnsSortDef[] { new ColumnsSortDef("Код", SortOrder.Asc) }                
            });
            if (DataObject.Состояние == СостояниеЗаказа.Оплаченный)
            {
                ctrlСостояние.Enabled = false;
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