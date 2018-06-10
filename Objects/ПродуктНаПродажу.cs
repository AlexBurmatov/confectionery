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
    /// Продукт в наличии.
    /// </summary>
    // *** Start programmer edit section *** (ПродуктНаПродажу CustomAttributes)

    // *** End programmer edit section *** (ПродуктНаПродажу CustomAttributes)
    [AutoAltered()]
    [Caption("Продукт в наличии")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПродуктНаПродажуE", new string[] {
            "Продукт as \'Продукт\'",
            "Продукт.Наименование as \'Наименование\'",
            "Поступило as \'Поступило\'",
            "Осталось as \'Осталось\'",
            "ДатаИзг as \'Дата изготовления\'",
            "ДатаУничтожения",
            "ТорговаяТочка"}, Hidden=new string[] {
            "Продукт.Наименование",
            "ДатаУничтожения",
            "ТорговаяТочка"})]
    [MasterViewDefineAttribute("ПродуктНаПродажуE", "Продукт", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    public class ПродуктНаПродажу : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаИзг;
        
        private int fПоступило;
        
        private int fОсталось;
        
        private System.DateTime? fДатаУничтожения;
        
        private IIS.АСУ_Кондитерская.Продукт fПродукт;
        
        private IIS.АСУ_Кондитерская.ТорговаяТочка fТорговаяТочка;
        
        // *** Start programmer edit section *** (ПродуктНаПродажу CustomMembers)

        // *** End programmer edit section *** (ПродуктНаПродажу CustomMembers)

        
        /// <summary>
        /// ДатаИзг.
        /// </summary>
        // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаИзг CustomAttributes)

        // *** End programmer edit section *** (ПродуктНаПродажу.ДатаИзг CustomAttributes)
        public virtual System.DateTime ДатаИзг
        {
            get
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаИзг Get start)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаИзг Get start)
                System.DateTime result = this.fДатаИзг;
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаИзг Get end)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаИзг Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаИзг Set start)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаИзг Set start)
                this.fДатаИзг = value;
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаИзг Set end)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаИзг Set end)
            }
        }
        
        /// <summary>
        /// Поступило.
        /// </summary>
        // *** Start programmer edit section *** (ПродуктНаПродажу.Поступило CustomAttributes)

        // *** End programmer edit section *** (ПродуктНаПродажу.Поступило CustomAttributes)
        public virtual int Поступило
        {
            get
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.Поступило Get start)

                // *** End programmer edit section *** (ПродуктНаПродажу.Поступило Get start)
                int result = this.fПоступило;
                // *** Start programmer edit section *** (ПродуктНаПродажу.Поступило Get end)

                // *** End programmer edit section *** (ПродуктНаПродажу.Поступило Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.Поступило Set start)

                // *** End programmer edit section *** (ПродуктНаПродажу.Поступило Set start)
                this.fПоступило = value;
                // *** Start programmer edit section *** (ПродуктНаПродажу.Поступило Set end)

                // *** End programmer edit section *** (ПродуктНаПродажу.Поступило Set end)
            }
        }
        
        /// <summary>
        /// Осталось.
        /// </summary>
        // *** Start programmer edit section *** (ПродуктНаПродажу.Осталось CustomAttributes)

        // *** End programmer edit section *** (ПродуктНаПродажу.Осталось CustomAttributes)
        public virtual int Осталось
        {
            get
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.Осталось Get start)

                // *** End programmer edit section *** (ПродуктНаПродажу.Осталось Get start)
                int result = this.fОсталось;
                // *** Start programmer edit section *** (ПродуктНаПродажу.Осталось Get end)

                // *** End programmer edit section *** (ПродуктНаПродажу.Осталось Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.Осталось Set start)

                // *** End programmer edit section *** (ПродуктНаПродажу.Осталось Set start)
                this.fОсталось = value;
                // *** Start programmer edit section *** (ПродуктНаПродажу.Осталось Set end)

                // *** End programmer edit section *** (ПродуктНаПродажу.Осталось Set end)
            }
        }
        
        /// <summary>
        /// ДатаУничтожения.
        /// </summary>
        // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения CustomAttributes)

        // *** End programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения CustomAttributes)
        public virtual System.DateTime? ДатаУничтожения
        {
            get
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Get start)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Get start)
                System.DateTime? result = this.fДатаУничтожения;
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Get end)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Set start)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Set start)
                this.fДатаУничтожения = value;
                // *** Start programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Set end)

                // *** End programmer edit section *** (ПродуктНаПродажу.ДатаУничтожения Set end)
            }
        }
        
        /// <summary>
        /// Продукт в наличии.
        /// </summary>
        // *** Start programmer edit section *** (ПродуктНаПродажу.Продукт CustomAttributes)

        // *** End programmer edit section *** (ПродуктНаПродажу.Продукт CustomAttributes)
        [PropertyStorage(new string[] {
                "Продукт"})]
        [NotNull()]
        public virtual IIS.АСУ_Кондитерская.Продукт Продукт
        {
            get
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.Продукт Get start)

                // *** End programmer edit section *** (ПродуктНаПродажу.Продукт Get start)
                IIS.АСУ_Кондитерская.Продукт result = this.fПродукт;
                // *** Start programmer edit section *** (ПродуктНаПродажу.Продукт Get end)

                // *** End programmer edit section *** (ПродуктНаПродажу.Продукт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.Продукт Set start)

                // *** End programmer edit section *** (ПродуктНаПродажу.Продукт Set start)
                this.fПродукт = value;
                // *** Start programmer edit section *** (ПродуктНаПродажу.Продукт Set end)

                // *** End programmer edit section *** (ПродуктНаПродажу.Продукт Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУ_Кондитерская.ТорговаяТочка.
        /// </summary>
        // *** Start programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка CustomAttributes)

        // *** End programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ТорговаяТочка"})]
        public virtual IIS.АСУ_Кондитерская.ТорговаяТочка ТорговаяТочка
        {
            get
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Get start)

                // *** End programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Get start)
                IIS.АСУ_Кондитерская.ТорговаяТочка result = this.fТорговаяТочка;
                // *** Start programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Get end)

                // *** End programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Set start)

                // *** End programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Set start)
                this.fТорговаяТочка = value;
                // *** Start programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Set end)

                // *** End programmer edit section *** (ПродуктНаПродажу.ТорговаяТочка Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПродуктНаПродажуE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПродуктНаПродажуE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПродуктНаПродажуE", typeof(IIS.АСУ_Кондитерская.ПродуктНаПродажу));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ПродуктНаПродажу.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfПродуктНаПродажу CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfПродуктНаПродажу CustomAttributes)
    public class DetailArrayOfПродуктНаПродажу : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfПродуктНаПродажу members)

        // *** End programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfПродуктНаПродажу members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ПродуктНаПродажу by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ПродуктНаПродажу.
        /// </summary>
        public DetailArrayOfПродуктНаПродажу(IIS.АСУ_Кондитерская.ТорговаяТочка fТорговаяТочка) : 
                base(typeof(ПродуктНаПродажу), ((ICSSoft.STORMNET.DataObject)(fТорговаяТочка)))
        {
        }
        
        public IIS.АСУ_Кондитерская.ПродуктНаПродажу this[int index]
        {
            get
            {
                return ((IIS.АСУ_Кондитерская.ПродуктНаПродажу)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУ_Кондитерская.ПродуктНаПродажу dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
