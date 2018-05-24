﻿/*flexberryautogenerated="true"*/
namespace IIS.АСУ_Кондитерская
{
    using System;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Web.Controls;
    using NewPlatform.Flexberry.Security;
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
            // в случае, если страницу пытается открыть Продавец, 
            // то его перенаправляем на страницу с Торговой точкой, на которой он работает
            
            var ds = DataServiceProvider.DataService;
            var s = ds.SecurityManager;
            var manager = new NewPlatform.Flexberry.Security.UserManager(ds,new Md5PasswordHasher());
            var roles = manager.GetRolesOfUser(Context.User.Identity.Name);
            foreach(var role in roles)
            {
                if (role.Equals("Продавец"))
                {
                    Context.Response.Redirect("~/forms/TorgovayaTochka/TorgovayaTochkaE.aspx");
                    break;
                }
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
