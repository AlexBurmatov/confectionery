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
    /// Строка заказа.
    /// </summary>
    // *** Start programmer edit section *** (СтрокаЗаказа CustomAttributes)

    // *** End programmer edit section *** (СтрокаЗаказа CustomAttributes)
    [AutoAltered()]
    [Caption("Строка заказа")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СтрокаЗаказаE", new string[] {
            "Продукт as \'Продукт\'",
            "Продукт.Наименование as \'Наименование\'",
            "Количество as \'Количество\'",
            "Заказ"}, Hidden=new string[] {
            "Продукт.Наименование",
            "Заказ"})]
    [MasterViewDefineAttribute("СтрокаЗаказаE", "Продукт", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    public class СтрокаЗаказа : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private IIS.АСУ_Кондитерская.Продукт fПродукт;
        
        private IIS.АСУ_Кондитерская.Заказ fЗаказ;
        
        // *** Start programmer edit section *** (СтрокаЗаказа CustomMembers)

        // *** End programmer edit section *** (СтрокаЗаказа CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Количество CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Количество CustomAttributes)
        [NotNull()]
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Set end)
            }
        }
        
        /// <summary>
        /// Строка заказа.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Продукт CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Продукт CustomAttributes)
        [NotNull()]
        public virtual IIS.АСУ_Кондитерская.Продукт Продукт
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Продукт Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Продукт Get start)
                IIS.АСУ_Кондитерская.Продукт result = this.fПродукт;
                // *** Start programmer edit section *** (СтрокаЗаказа.Продукт Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Продукт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Продукт Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Продукт Set start)
                this.fПродукт = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Продукт Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Продукт Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУ_Кондитерская.Заказ.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Заказ CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Заказ CustomAttributes)
        [Agregator()]
        [NotNull()]
        [TypeUsage(new string[] {
                "IIS.АСУ_Кондитерская.Заказ",
                "IIS.АСУ_Кондитерская.ИндивидуальныйЗаказ"})]
        public virtual IIS.АСУ_Кондитерская.Заказ Заказ
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Get start)
                IIS.АСУ_Кондитерская.Заказ result = this.fЗаказ;
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Set start)
                this.fЗаказ = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СтрокаЗаказаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СтрокаЗаказаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СтрокаЗаказаE", typeof(IIS.АСУ_Кондитерская.СтрокаЗаказа));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of СтрокаЗаказа.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfСтрокаЗаказа CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfСтрокаЗаказа CustomAttributes)
    public class DetailArrayOfСтрокаЗаказа : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfСтрокаЗаказа members)
        [AggregationFunction(null,"Количество")]
        public int CountProduct()
        {
            int count = 0;
            foreach(СтрокаЗаказа x in this)
            {
                count += x.Количество;
            }
            return count;
        }
        // *** End programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfСтрокаЗаказа members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type СтрокаЗаказа by index.
        /// </summary>
        /// <summary>
        /// Adds object with type СтрокаЗаказа.
        /// </summary>
        public DetailArrayOfСтрокаЗаказа(IIS.АСУ_Кондитерская.Заказ fЗаказ) : 
                base(typeof(СтрокаЗаказа), ((ICSSoft.STORMNET.DataObject)(fЗаказ)))
        {
        }
        
        public IIS.АСУ_Кондитерская.СтрокаЗаказа this[int index]
        {
            get
            {
                return ((IIS.АСУ_Кондитерская.СтрокаЗаказа)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУ_Кондитерская.СтрокаЗаказа dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
