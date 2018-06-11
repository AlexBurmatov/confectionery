﻿/*flexberryautogenerated="false"*/
namespace IIS.АСУ_Кондитерская
{
    using System;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Windows.Forms;
    using Resources;

    public partial class ЗаказL : BaseListForm<Заказ>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ЗаказL() : base(Заказ.Views.ЗаказL)
        {
            EditPage = ЗаказE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Zakaz/ZakazL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
            IDataService ds = DataServiceProvider.DataService;
            ExternalLangDef ld = ExternalLangDef.LanguageDef;
            if (Context.User.IsInRole("Продавец"))
            {
                // Определяем текущего пользователя
                var currentUser = Context.User.Identity.Name;
                var lcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Продавец), "ПродавецL");
                lcs.LimitFunction = ld.GetFunction(ld.funcEQ,
                    new VariableDef(ld.StringType, Information.ExtractPropertyPath<Продавец>(x => x.Логин)), currentUser);
                var manager = ds.LoadObjects(lcs)[0] as Продавец;
                WebObjectListView1.LimitFunction = ld.GetFunction(ld.funcEQ, 
                    new VariableDef(ld.StringType, Information.ExtractPropertyPath<Заказ>(z => z.ТорговаяТочка.Адрес)), 
                    manager.ТорговаяТочка.Адрес);
            }
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
