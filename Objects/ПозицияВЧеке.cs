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
    /// Позиция в чеке.
    /// </summary>
    // *** Start programmer edit section *** (ПозицияВЧеке CustomAttributes)

    // *** End programmer edit section *** (ПозицияВЧеке CustomAttributes)
    [AutoAltered()]
    [Caption("Позиция в чеке")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПозицияВЧекеE", new string[] {
            "Продукт as \'Продукт\'",
            "Продукт.Наименование as \'Наименование\'",
            "Количество as \'Количество\'",
            "Вес as \'Вес\'",
            "Цена as \'Цена\'",
            "Сумма as \'Сумма\'"}, Hidden=new string[] {
            "Продукт.Наименование"})]
    [MasterViewDefineAttribute("ПозицияВЧекеE", "Продукт", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    public class ПозицияВЧеке : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private double fВес;
        
        private double fЦена;
        
        private IIS.АСУ_Кондитерская.Продукт fПродукт;
        
        private IIS.АСУ_Кондитерская.Чек fЧек;
        
        // *** Start programmer edit section *** (ПозицияВЧеке CustomMembers)

        // *** End programmer edit section *** (ПозицияВЧеке CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (ПозицияВЧеке.Количество CustomAttributes)

        // *** End programmer edit section *** (ПозицияВЧеке.Количество CustomAttributes)
        [NotNull()]
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Количество Get start)

                // *** End programmer edit section *** (ПозицияВЧеке.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (ПозицияВЧеке.Количество Get end)

                // *** End programmer edit section *** (ПозицияВЧеке.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Количество Set start)

                // *** End programmer edit section *** (ПозицияВЧеке.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (ПозицияВЧеке.Количество Set end)

                // *** End programmer edit section *** (ПозицияВЧеке.Количество Set end)
            }
        }
        
        /// <summary>
        /// Вес.
        /// </summary>
        // *** Start programmer edit section *** (ПозицияВЧеке.Вес CustomAttributes)

        // *** End programmer edit section *** (ПозицияВЧеке.Вес CustomAttributes)
        [NotNull()]
        public virtual double Вес
        {
            get
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Вес Get start)

                // *** End programmer edit section *** (ПозицияВЧеке.Вес Get start)
                double result = this.fВес;
                // *** Start programmer edit section *** (ПозицияВЧеке.Вес Get end)

                // *** End programmer edit section *** (ПозицияВЧеке.Вес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Вес Set start)

                // *** End programmer edit section *** (ПозицияВЧеке.Вес Set start)
                this.fВес = value;
                // *** Start programmer edit section *** (ПозицияВЧеке.Вес Set end)

                // *** End programmer edit section *** (ПозицияВЧеке.Вес Set end)
            }
        }
        
        /// <summary>
        /// Цена.
        /// </summary>
        // *** Start programmer edit section *** (ПозицияВЧеке.Цена CustomAttributes)

        // *** End programmer edit section *** (ПозицияВЧеке.Цена CustomAttributes)
        [NotNull()]
        public virtual double Цена
        {
            get
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Цена Get start)

                // *** End programmer edit section *** (ПозицияВЧеке.Цена Get start)
                double result = this.fЦена;
                // *** Start programmer edit section *** (ПозицияВЧеке.Цена Get end)

                // *** End programmer edit section *** (ПозицияВЧеке.Цена Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Цена Set start)

                // *** End programmer edit section *** (ПозицияВЧеке.Цена Set start)
                this.fЦена = value;
                // *** Start programmer edit section *** (ПозицияВЧеке.Цена Set end)

                // *** End programmer edit section *** (ПозицияВЧеке.Цена Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (ПозицияВЧеке.Сумма CustomAttributes)

        // *** End programmer edit section *** (ПозицияВЧеке.Сумма CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual double Сумма
        {
            get
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Сумма Get)
                return 0;
                // *** End programmer edit section *** (ПозицияВЧеке.Сумма Get)
            }
            set
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Сумма Set)

                // *** End programmer edit section *** (ПозицияВЧеке.Сумма Set)
            }
        }
        
        /// <summary>
        /// Позиция в чеке.
        /// </summary>
        // *** Start programmer edit section *** (ПозицияВЧеке.Продукт CustomAttributes)

        // *** End programmer edit section *** (ПозицияВЧеке.Продукт CustomAttributes)
        [NotNull()]
        public virtual IIS.АСУ_Кондитерская.Продукт Продукт
        {
            get
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Продукт Get start)

                // *** End programmer edit section *** (ПозицияВЧеке.Продукт Get start)
                IIS.АСУ_Кондитерская.Продукт result = this.fПродукт;
                // *** Start programmer edit section *** (ПозицияВЧеке.Продукт Get end)

                // *** End programmer edit section *** (ПозицияВЧеке.Продукт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Продукт Set start)

                // *** End programmer edit section *** (ПозицияВЧеке.Продукт Set start)
                this.fПродукт = value;
                // *** Start programmer edit section *** (ПозицияВЧеке.Продукт Set end)

                // *** End programmer edit section *** (ПозицияВЧеке.Продукт Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУ_Кондитерская.Чек.
        /// </summary>
        // *** Start programmer edit section *** (ПозицияВЧеке.Чек CustomAttributes)

        // *** End programmer edit section *** (ПозицияВЧеке.Чек CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.АСУ_Кондитерская.Чек Чек
        {
            get
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Чек Get start)

                // *** End programmer edit section *** (ПозицияВЧеке.Чек Get start)
                IIS.АСУ_Кондитерская.Чек result = this.fЧек;
                // *** Start programmer edit section *** (ПозицияВЧеке.Чек Get end)

                // *** End programmer edit section *** (ПозицияВЧеке.Чек Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПозицияВЧеке.Чек Set start)

                // *** End programmer edit section *** (ПозицияВЧеке.Чек Set start)
                this.fЧек = value;
                // *** Start programmer edit section *** (ПозицияВЧеке.Чек Set end)

                // *** End programmer edit section *** (ПозицияВЧеке.Чек Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПозицияВЧекеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПозицияВЧекеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПозицияВЧекеE", typeof(IIS.АСУ_Кондитерская.ПозицияВЧеке));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ПозицияВЧеке.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfПозицияВЧеке CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfПозицияВЧеке CustomAttributes)
    public class DetailArrayOfПозицияВЧеке : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfПозицияВЧеке members)

        // *** End programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfПозицияВЧеке members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ПозицияВЧеке by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ПозицияВЧеке.
        /// </summary>
        public DetailArrayOfПозицияВЧеке(IIS.АСУ_Кондитерская.Чек fЧек) : 
                base(typeof(ПозицияВЧеке), ((ICSSoft.STORMNET.DataObject)(fЧек)))
        {
        }
        
        public IIS.АСУ_Кондитерская.ПозицияВЧеке this[int index]
        {
            get
            {
                return ((IIS.АСУ_Кондитерская.ПозицияВЧеке)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУ_Кондитерская.ПозицияВЧеке dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
