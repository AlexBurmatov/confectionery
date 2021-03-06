﻿/*flexberryautogenerated="false"*/
namespace IIS.АСУ_Кондитерская
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ТорговаяТочкаL : BaseListForm<ТорговаяТочка>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ТорговаяТочкаL() : base(ТорговаяТочка.Views.ТорговаяТочкаL)
        {
            EditPage = ТорговаяТочкаE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/TorgovayaTochka/TorgovayaTochkaL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
            if (Context.User.IsInRole("Продавец"))
            {
                this.Response.Redirect(ТорговаяТочкаE.FormPath);
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
