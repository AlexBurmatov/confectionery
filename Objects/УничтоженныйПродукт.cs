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
    /// Уничтоженный продукт.
    /// </summary>
    // *** Start programmer edit section *** (УничтоженныйПродукт CustomAttributes)

    // *** End programmer edit section *** (УничтоженныйПродукт CustomAttributes)
    [AutoAltered()]
    [Caption("Уничтоженный продукт")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("УничтоженныйПродуктE", new string[] {
            "Количество as \'Количество\'",
            "Продукт as \'Продукт\'",
            "Продукт.Наименование as \'Наименование\'"}, Hidden=new string[] {
            "Продукт.Наименование"})]
    [MasterViewDefineAttribute("УничтоженныйПродуктE", "Продукт", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    public class УничтоженныйПродукт : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private IIS.АСУ_Кондитерская.Продукт fПродукт;
        
        private IIS.АСУ_Кондитерская.ТорговаяТочка fТорговаяТочка;
        
        // *** Start programmer edit section *** (УничтоженныйПродукт CustomMembers)

        // *** End programmer edit section *** (УничтоженныйПродукт CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (УничтоженныйПродукт.Количество CustomAttributes)

        // *** End programmer edit section *** (УничтоженныйПродукт.Количество CustomAttributes)
        [NotNull()]
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (УничтоженныйПродукт.Количество Get start)

                // *** End programmer edit section *** (УничтоженныйПродукт.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (УничтоженныйПродукт.Количество Get end)

                // *** End programmer edit section *** (УничтоженныйПродукт.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (УничтоженныйПродукт.Количество Set start)

                // *** End programmer edit section *** (УничтоженныйПродукт.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (УничтоженныйПродукт.Количество Set end)

                // *** End programmer edit section *** (УничтоженныйПродукт.Количество Set end)
            }
        }
        
        /// <summary>
        /// Уничтоженный продукт.
        /// </summary>
        // *** Start programmer edit section *** (УничтоженныйПродукт.Продукт CustomAttributes)

        // *** End programmer edit section *** (УничтоженныйПродукт.Продукт CustomAttributes)
        [PropertyStorage(new string[] {
                "Продукт"})]
        [NotNull()]
        public virtual IIS.АСУ_Кондитерская.Продукт Продукт
        {
            get
            {
                // *** Start programmer edit section *** (УничтоженныйПродукт.Продукт Get start)

                // *** End programmer edit section *** (УничтоженныйПродукт.Продукт Get start)
                IIS.АСУ_Кондитерская.Продукт result = this.fПродукт;
                // *** Start programmer edit section *** (УничтоженныйПродукт.Продукт Get end)

                // *** End programmer edit section *** (УничтоженныйПродукт.Продукт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (УничтоженныйПродукт.Продукт Set start)

                // *** End programmer edit section *** (УничтоженныйПродукт.Продукт Set start)
                this.fПродукт = value;
                // *** Start programmer edit section *** (УничтоженныйПродукт.Продукт Set end)

                // *** End programmer edit section *** (УничтоженныйПродукт.Продукт Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУ_Кондитерская.ТорговаяТочка.
        /// </summary>
        // *** Start programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка CustomAttributes)

        // *** End programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ТорговаяТочка"})]
        public virtual IIS.АСУ_Кондитерская.ТорговаяТочка ТорговаяТочка
        {
            get
            {
                // *** Start programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Get start)

                // *** End programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Get start)
                IIS.АСУ_Кондитерская.ТорговаяТочка result = this.fТорговаяТочка;
                // *** Start programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Get end)

                // *** End programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Set start)

                // *** End programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Set start)
                this.fТорговаяТочка = value;
                // *** Start programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Set end)

                // *** End programmer edit section *** (УничтоженныйПродукт.ТорговаяТочка Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "УничтоженныйПродуктE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View УничтоженныйПродуктE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("УничтоженныйПродуктE", typeof(IIS.АСУ_Кондитерская.УничтоженныйПродукт));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of УничтоженныйПродукт.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfУничтоженныйПродукт CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfУничтоженныйПродукт CustomAttributes)
    public class DetailArrayOfУничтоженныйПродукт : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfУничтоженныйПродукт members)

        // *** End programmer edit section *** (IIS.АСУ_Кондитерская.DetailArrayOfУничтоженныйПродукт members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type УничтоженныйПродукт by index.
        /// </summary>
        /// <summary>
        /// Adds object with type УничтоженныйПродукт.
        /// </summary>
        public DetailArrayOfУничтоженныйПродукт(IIS.АСУ_Кондитерская.ТорговаяТочка fТорговаяТочка) : 
                base(typeof(УничтоженныйПродукт), ((ICSSoft.STORMNET.DataObject)(fТорговаяТочка)))
        {
        }
        
        public IIS.АСУ_Кондитерская.УничтоженныйПродукт this[int index]
        {
            get
            {
                return ((IIS.АСУ_Кондитерская.УничтоженныйПродукт)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУ_Кондитерская.УничтоженныйПродукт dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
