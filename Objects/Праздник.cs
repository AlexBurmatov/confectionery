﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУ_Кондитерская
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Праздник.
    /// </summary>
    // *** Start programmer edit section *** (Праздник CustomAttributes)

    // *** End programmer edit section *** (Праздник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПраздникE", new string[] {
            "Дата as \'Дата\'",
            "Название as \'Название\'"})]
    [AssociatedDetailViewAttribute("ПраздникE", "ПродуктКПразднику", "ПродуктКПраздникуE", true, "", "Продукт к празднику", true, new string[] {
            ""})]
    [View("ПраздникL", new string[] {
            "Дата as \'Дата\'",
            "Название as \'Название\'"})]
    public class Праздник : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private string fНазвание;
        
        private IIS.АСУ_Кондитерская.DetailArrayOfПродуктКПразднику fПродуктКПразднику;
        
        // *** Start programmer edit section *** (Праздник CustomMembers)

        // *** End programmer edit section *** (Праздник CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Праздник.Дата CustomAttributes)

        // *** End programmer edit section *** (Праздник.Дата CustomAttributes)
        [NotNull()]
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Праздник.Дата Get start)

                // *** End programmer edit section *** (Праздник.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Праздник.Дата Get end)

                // *** End programmer edit section *** (Праздник.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Праздник.Дата Set start)

                // *** End programmer edit section *** (Праздник.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Праздник.Дата Set end)

                // *** End programmer edit section *** (Праздник.Дата Set end)
            }
        }
        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (Праздник.Название CustomAttributes)

        // *** End programmer edit section *** (Праздник.Название CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (Праздник.Название Get start)

                // *** End programmer edit section *** (Праздник.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (Праздник.Название Get end)

                // *** End programmer edit section *** (Праздник.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Праздник.Название Set start)

                // *** End programmer edit section *** (Праздник.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (Праздник.Название Set end)

                // *** End programmer edit section *** (Праздник.Название Set end)
            }
        }
        
        /// <summary>
        /// Праздник.
        /// </summary>
        // *** Start programmer edit section *** (Праздник.ПродуктКПразднику CustomAttributes)

        // *** End programmer edit section *** (Праздник.ПродуктКПразднику CustomAttributes)
        public virtual IIS.АСУ_Кондитерская.DetailArrayOfПродуктКПразднику ПродуктКПразднику
        {
            get
            {
                // *** Start programmer edit section *** (Праздник.ПродуктКПразднику Get start)

                // *** End programmer edit section *** (Праздник.ПродуктКПразднику Get start)
                if ((this.fПродуктКПразднику == null))
                {
                    this.fПродуктКПразднику = new IIS.АСУ_Кондитерская.DetailArrayOfПродуктКПразднику(this);
                }
                IIS.АСУ_Кондитерская.DetailArrayOfПродуктКПразднику result = this.fПродуктКПразднику;
                // *** Start programmer edit section *** (Праздник.ПродуктКПразднику Get end)

                // *** End programmer edit section *** (Праздник.ПродуктКПразднику Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Праздник.ПродуктКПразднику Set start)

                // *** End programmer edit section *** (Праздник.ПродуктКПразднику Set start)
                this.fПродуктКПразднику = value;
                // *** Start programmer edit section *** (Праздник.ПродуктКПразднику Set end)

                // *** End programmer edit section *** (Праздник.ПродуктКПразднику Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПраздникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПраздникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПраздникE", typeof(IIS.АСУ_Кондитерская.Праздник));
                }
            }
            
            /// <summary>
            /// "ПраздникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПраздникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПраздникL", typeof(IIS.АСУ_Кондитерская.Праздник));
                }
            }
        }
    }
}
