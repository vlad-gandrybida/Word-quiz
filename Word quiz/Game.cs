using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_quiz
{
    public class Game
    {
        public Level Level_1 = new Level
        {
            Words = new List<Word>
            {
                new Word
                {
                    Answer = "Факт",
                    Discription = "Дійсна, не вигадана подія, дійсне явище; те, що сталося, відбулося насправді."
                },
                new Word
                {
                    Answer = "Двері",
                    Discription = "Отвір у стіні для входу і виходу."
                },
                new Word
                {
                    Answer = "Країна",
                    Discription = "Територія, що становить єдність із погляду історії, природних умов, населення тощо."
                },
                new Word
                {
                    Answer = "Пустеля",
                    Discription = "Великий (звич. посушливий) простір з бідною рослинністю або позбавлений рослинності."
                },
                new Word
                {
                    Answer = "Вітер",
                    Discription = "Більший або менший рух потоку повітря в горизонтальному напрямі. "
                },
                new Word
                {
                    Answer = "Олівець",
                    Discription = "Тоненька паличка графіту або сухої фарби у дерев'яній оправі, якою пишуть, креслять, малюють."
                },
                new Word
                {
                    Answer = "Вікно",
                    Discription = "Отвір для світла й повітря в стіні приміщення (хати, вагона тощо), куди вставлена рама з шибками."
                },
                new Word
                {
                    Answer = "Смартфон",
                    Discription = "Стільниковий телефон із можливістю виконання додаткових застосунків та доступом до Інтернету."
                },
                new Word
                {
                    Answer = "Школа",
                    Discription = "Навчальний заклад, який здійснює загальну освіту і виховання молодого покоління."
                },
                new Word
                {
                    Answer = "Унівеситет",
                    Discription = "Вищий навчальний заклад, наукова установа з різними гуманітарними та природничо-математичними факультетами."
                },
            }
        };
        public Level Level_2 = new Level
        {
            Words = new List<Word>
            {
                new Word
                {
                    Answer = "Сонце",
                    Discription = "Центральне небесне світило сонячної «системи, що має форму гігантської розжареної кулі, яка випромінює світло й тепло."
                },
                new Word
                {
                    Answer = "Імпічмент",
                    Discription = "Процедура притягнення до суду та припинення повноважень посадових осіб держави (перев. президента)."
                },
                new Word
                {
                    Answer = "Автомобіль",
                    Discription = "Самохідна машина з двигуном внутрішнього згоряння для перевезення пасажирів і вантажів по безрейкових дорогах."
                },
                new Word
                {
                    Answer = "Резонанс",
                    Discription = "Явище різкого зростання амплітуди коливань у коливальній системі, що настає при певній частоті зовнішнього впливу на цю систему."
                },
                new Word
                {
                    Answer = "Тінь",
                    Discription = "Темний відбиток на чому-небудь від предмета, освітленого з протилежного боку. "
                }
            }
        };
        public Level Level_3 = new Level
        {
            Words = new List<Word>
            {
                new Word
                {
                    Answer = "Світло",
                    Discription = "Промениста енергія, що випромінюється яким-небудь тілом, сприймається зором і робить видимим навколишнє."
                },
                new Word
                {
                    Answer = "Словник",
                    Discription = "Книга, в якій в алфавітному чи тематичному порядку подано слова якоїсь мови (з тлумаченням, перекладом на іншу мову і т. ін.)."
                },
                new Word
                {
                    Answer = "Веб-сайт",
                    Discription = "Сукупність взаємопов'язаних посиланнями та змістом веб-сторінок з метою поширення чи обміну інформацією"
                }
            }
        };

        public int CheckAnswer(string answer)
        {
            if (Level == 1)
            {
                var res = Level_1.CheckAnswer(answer, CurrentQuestion);
                if (res == 2) return -1;
                if (res != 1) return 0;
                Points += res*2;
                return 1;
            }
            else if (Level == 2)
            {
                var res = Level_2.CheckAnswer(answer, CurrentQuestion);
                if (res == 2) return -1;
                if (res != 1) return 0;
                Points += res * 4;
                return 1;
            }
            else
            {
                var res = Level_3.CheckAnswer(answer, CurrentQuestion);
                if (res == 2) return -1;
                if (res != 1) return 0;
                Points += res * 6;
                return 1;
            }
        }

        public int Level { get => Points < 10 ? 1 : Points < 20 ? 2 : 3; }
        public int Points = 0;
        public int CurrentQuestion = 0;

        internal void Help()
        {
            if(Level == 1)
            {
                Level_1.Help(CurrentQuestion);
            }
            else if (Level == 2)
            {
                Level_2.Help(CurrentQuestion);
            }
            else
            {
                Level_3.Help(CurrentQuestion);
            }
        }
    }
}
