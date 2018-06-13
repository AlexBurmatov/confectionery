using ICSSoft.STORMNET;
using ICSSoft.STORMNET.Web.Controls;
using ICSSoft.STORMNET.Web.AjaxControls;
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
using ICSSoft.STORMNET.FunctionalLanguage;
using ICSSoft.STORMNET.Web.Tools.WGEFeatures;
using ICSSoft.STORMNET.Business;
using System;

namespace IIS.АСУ_Кондитерская.forms.Reports
{
    public partial class MaxProfit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MSSQLDataService ds = new MSSQLDataService();
            ds.CustomizationString = "SERVER=ALEX;Trusted_connection=yes;DATABASE=dbconf;";
            var res = ds.ExecuteNonQuery(@"select строка.Продукт_m0, sum(строка.Количество*Продукт.Цена) Прибыль
from СтрокаЗаказа строка left join Продукт on строка.Продукт_m0 = Продукт.primaryKey
group by строка.Продукт_m0
order by 2");
        }
    }
}