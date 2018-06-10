﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    /// Продукт.
    /// </summary>
    // *** Start programmer edit section *** (Продукт CustomAttributes)

    // *** End programmer edit section *** (Продукт CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("ПродуктE", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "Масса as \'Масса (г)\'",
            "Цена as \'Цена\'",
            "СрокГодности as \'Срок годности (ч)\'",
            "Статус as \'Статус\'",
            "Описание as \'Описание\'"})]
    [View("ПродуктL", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "Масса as \'Масса (г)\'",
            "Цена as \'Цена\'",
            "СрокГодности as \'Срок годности (ч)\'",
            "Статус as \'Статус\'",
            "Описание as \'Описание\'"})]
    public class Продукт : ICSSoft.STORMNET.DataObject
    {
        
        private int fКод;
        
        private string fНаименование;
        
        private double fМасса;
        
        private double fЦена;
        
        private int fСрокГодности;
        
        private IIS.АСУ_Кондитерская.СтатусПродукта fСтатус;
        
        private string fОписание;
        
        // *** Start programmer edit section *** (Продукт CustomMembers)

        // *** End programmer edit section *** (Продукт CustomMembers)

        
        /// <summary>
        /// Код.
        /// </summary>
        // *** Start programmer edit section *** (Продукт.Код CustomAttributes)

        // *** End programmer edit section *** (Продукт.Код CustomAttributes)
        [NotNull()]
        public virtual int Код
        {
            get
            {
                // *** Start programmer edit section *** (Продукт.Код Get start)

                // *** End programmer edit section *** (Продукт.Код Get start)
                int result = this.fКод;
                // *** Start programmer edit section *** (Продукт.Код Get end)

                // *** End programmer edit section *** (Продукт.Код Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Продукт.Код Set start)

                // *** End programmer edit section *** (Продукт.Код Set start)
                this.fКод = value;
                // *** Start programmer edit section *** (Продукт.Код Set end)

                // *** End programmer edit section *** (Продукт.Код Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Продукт.Наименование CustomAttributes)

        // *** End programmer edit section *** (Продукт.Наименование CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Продукт.Наименование Get start)

                // *** End programmer edit section *** (Продукт.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Продукт.Наименование Get end)

                // *** End programmer edit section *** (Продукт.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Продукт.Наименование Set start)

                // *** End programmer edit section *** (Продукт.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Продукт.Наименование Set end)

                // *** End programmer edit section *** (Продукт.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Масса.
        /// </summary>
        // *** Start programmer edit section *** (Продукт.Масса CustomAttributes)

        // *** End programmer edit section *** (Продукт.Масса CustomAttributes)
        [NotNull()]
        public virtual double Масса
        {
            get
            {
                // *** Start programmer edit section *** (Продукт.Масса Get start)

                // *** End programmer edit section *** (Продукт.Масса Get start)
                double result = this.fМасса;
                // *** Start programmer edit section *** (Продукт.Масса Get end)

                // *** End programmer edit section *** (Продукт.Масса Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Продукт.Масса Set start)

                // *** End programmer edit section *** (Продукт.Масса Set start)
                this.fМасса = value;
                // *** Start programmer edit section *** (Продукт.Масса Set end)

                // *** End programmer edit section *** (Продукт.Масса Set end)
            }
        }
        
        /// <summary>
        /// Цена.
        /// </summary>
        // *** Start programmer edit section *** (Продукт.Цена CustomAttributes)

        // *** End programmer edit section *** (Продукт.Цена CustomAttributes)
        [NotNull()]
        public virtual double Цена
        {
            get
            {
                // *** Start programmer edit section *** (Продукт.Цена Get start)

                // *** End programmer edit section *** (Продукт.Цена Get start)
                double result = this.fЦена;
                // *** Start programmer edit section *** (Продукт.Цена Get end)

                // *** End programmer edit section *** (Продукт.Цена Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Продукт.Цена Set start)

                // *** End programmer edit section *** (Продукт.Цена Set start)
                this.fЦена = value;
                // *** Start programmer edit section *** (Продукт.Цена Set end)

                // *** End programmer edit section *** (Продукт.Цена Set end)
            }
        }
        
        /// <summary>
        /// СрокГодности.
        /// </summary>
        // *** Start programmer edit section *** (Продукт.СрокГодности CustomAttributes)

        // *** End programmer edit section *** (Продукт.СрокГодности CustomAttributes)
        [NotNull()]
        public virtual int СрокГодности
        {
            get
            {
                // *** Start programmer edit section *** (Продукт.СрокГодности Get start)

                // *** End programmer edit section *** (Продукт.СрокГодности Get start)
                int result = this.fСрокГодности;
                // *** Start programmer edit section *** (Продукт.СрокГодности Get end)

                // *** End programmer edit section *** (Продукт.СрокГодности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Продукт.СрокГодности Set start)

                // *** End programmer edit section *** (Продукт.СрокГодности Set start)
                this.fСрокГодности = value;
                // *** Start programmer edit section *** (Продукт.СрокГодности Set end)

                // *** End programmer edit section *** (Продукт.СрокГодности Set end)
            }
        }
        
        /// <summary>
        /// Статус.
        /// </summary>
        // *** Start programmer edit section *** (Продукт.Статус CustomAttributes)

        // *** End programmer edit section *** (Продукт.Статус CustomAttributes)
        [NotNull()]
        public virtual IIS.АСУ_Кондитерская.СтатусПродукта Статус
        {
            get
            {
                // *** Start programmer edit section *** (Продукт.Статус Get start)

                // *** End programmer edit section *** (Продукт.Статус Get start)
                IIS.АСУ_Кондитерская.СтатусПродукта result = this.fСтатус;
                // *** Start programmer edit section *** (Продукт.Статус Get end)

                // *** End programmer edit section *** (Продукт.Статус Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Продукт.Статус Set start)

                // *** End programmer edit section *** (Продукт.Статус Set start)
                this.fСтатус = value;
                // *** Start programmer edit section *** (Продукт.Статус Set end)

                // *** End programmer edit section *** (Продукт.Статус Set end)
            }
        }
        
        /// <summary>
        /// Описание.
        /// </summary>
        // *** Start programmer edit section *** (Продукт.Описание CustomAttributes)

        // *** End programmer edit section *** (Продукт.Описание CustomAttributes)
        [StrLen(255)]
        public virtual string Описание
        {
            get
            {
                // *** Start programmer edit section *** (Продукт.Описание Get start)

                // *** End programmer edit section *** (Продукт.Описание Get start)
                string result = this.fОписание;
                // *** Start programmer edit section *** (Продукт.Описание Get end)

                // *** End programmer edit section *** (Продукт.Описание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Продукт.Описание Set start)

                // *** End programmer edit section *** (Продукт.Описание Set start)
                this.fОписание = value;
                // *** Start programmer edit section *** (Продукт.Описание Set end)

                // *** End programmer edit section *** (Продукт.Описание Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПродуктE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПродуктE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПродуктE", typeof(IIS.АСУ_Кондитерская.Продукт));
                }
            }
            
            /// <summary>
            /// "ПродуктL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПродуктL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПродуктL", typeof(IIS.АСУ_Кондитерская.Продукт));
                }
            }
        }
    }
}
