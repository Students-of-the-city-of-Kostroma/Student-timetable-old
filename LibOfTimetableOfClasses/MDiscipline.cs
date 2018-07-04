﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
     public class MDiscipline
    {
        /// <summary>
        /// Перечисление полей объекта модели Дисциплина
        /// </summary>
        public enum Keys { Id = 0, Name = 1, Code = 2 }
        /// <summary>
        /// Идентификатор ID
        /// </summary>
        Guid id;
        /// <summary>
        /// Название дисциплины
        /// </summary>
        string name;
        /// <summary>
        /// Код дисциплины
        /// </summary>
        string code;

        /// <summary>
        /// Возвращает значение перечисления
        /// </summary>
        /// <param ключ="key"></param>
        /// <returns></returns>
        public object this[Keys key]
        {
            get
            {
                switch (key)
                {
                    case Keys.Id: return Id;
                    case Keys.Name: return Name;
                    case Keys.Code: return Code;
                    default: return null;
                }
            }
        }

        /// <summary>
        /// Возвращает или задает значение ID
        /// </summary>
        public Guid Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение Name - название
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение Code - код
        /// </summary>
        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        
    }
}
