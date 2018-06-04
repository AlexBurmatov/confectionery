﻿/*flexberryautogenerated="false"*/

namespace IIS.АСУ_Кондитерская
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using System.Linq;
    using ICSSoft.STORMNET.Business.LINQProvider;
    using ICSSoft.STORMNET.Windows.Forms;
    using ICSSoft.STORMNET.Web.Tools.WGEFeatures;

    public partial class ЧекE : BaseEditForm<Чек>
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ЧекE()
            : base(Чек.Views.ЧекE)
        {
        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/CHek/CHekE.aspx"; }
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
            if (Context.User.IsInRole("Продавец"))
            {
                if (this.DataObject == null)
                {
                    // Определяем текущего пользователя
                    var currentUser = Context.User.Identity.Name;
                    IDataService ds = DataServiceProvider.DataService;
                    var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Продавец), "ПродавецL");
                    SQLWhereLanguageDef ld = SQLWhereLanguageDef.LanguageDef;
                    lcs.LimitFunction = ld.GetFunction(ld.funcEQ,
                        new VariableDef(ld.StringType, Information.ExtractPropertyPath<Продавец>(x => x.Логин)), currentUser);
                    var manager = ds.LoadObjects(lcs)[0] as Продавец;

                    // Устанавливаем текущего продавца в поле заказа
                    this.DataObject = new Чек();
                    this.DataObject.Продавец = manager;
                    this.DataObject.ТорговаяТочка = manager.ТорговаяТочка;

                    // Фильтруем список индивидуальных заказов в соотв. с торговой точкой, на которой работает текущий продавец
                    IQueryable<ИндивидуальныйЗаказ> limit =
                        ds.Query<ИндивидуальныйЗаказ>(ИндивидуальныйЗаказ.Views.ИндивидуальныйЗаказE).Where(order =>
                        order.ТорговаяТочка.__PrimaryKey.Equals(manager.ТорговаяТочка.__PrimaryKey) && order.Состояние.Equals("Выполненный"));
                    Function limitfunc = LinqToLcs.GetLcs(limit.Expression, ИндивидуальныйЗаказ.Views.ИндивидуальныйЗаказE).LimitFunction;

                    ctrlИндивидуальныйЗаказ.MasterViewName = ИндивидуальныйЗаказ.Views.ИндивидуальныйЗаказE.Name;
                    ctrlИндивидуальныйЗаказ.LimitFunction = limitfunc;
                }
                ctrlПродавец.Enabled = false;
                ctrlТорговаяТочка.Enabled = false;
                ctrlИндивидуальныйЗаказ.Enabled = false;
                if (this.DataObject.GetStatus() == ObjectStatus.Created)
                    ctrlИндивидуальныйЗаказ.Enabled = true;
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


        protected void ctrlИндивидуальныйЗаказ_DataBinding(object sender, System.EventArgs e)
        {
            var order = ((MasterEditorAjaxDropDown)sender).Object as ИндивидуальныйЗаказ;
            if (order == null)
                return;

            IDataService ds = DataServiceProvider.DataService;
            foreach (var point in order.СтрокаЗаказа)
            {
                ds.LoadObject((DataObject)point);
            }


            /*
            var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(СтрокаЗаказа), "СтрокаЗаказаE");
            ExternalLangDef ld = ExternalLangDef.LanguageDef;
            lcs.LimitFunction = ld.GetFunction(ld.funcEQ,
                new VariableDef(ld.GuidType, Information.ExtractPropertyPath<СтрокаЗаказа>(x => x.)), currentUser);*/
        }
    }
}