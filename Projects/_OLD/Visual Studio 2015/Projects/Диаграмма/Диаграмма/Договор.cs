using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Диаграмма
{
    class Договор : Форма_клиентов
    {
        private int Номер_договора;
        private DateTime Дата_страхования;
        private int Срок_страхования;

        public void Занести_в_БД()
        {
            throw new System.NotImplementedException();
        }
    }
}
