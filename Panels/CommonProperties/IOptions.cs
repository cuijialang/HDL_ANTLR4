using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Schematix.CommonProperties
{
    public interface IOptions
    {
        /// <summary>
        /// Сохранение изменений
        /// </summary>
        /// <param name="options"></param>
        void Accept(Options options);

        /// <summary>
        /// Передача параметров диалоговому окну
        /// </summary>
        /// <param name="options"></param>
        void LoadData(Options options);

        /// <summary>
        /// Установка значений по-умолчанию
        /// </summary>
        void SetDefault();
    }
}
