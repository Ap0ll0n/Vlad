using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GoodVision
    //интерфейс нешего проекта, где записаны прототипы всех методов проекта
{
    interface GoodVisionInterface
    {
		
        void Create_account(ref UserClass User);//функция для создания аккаунта
        void Clear_account(ref UserClass User);//удалить аккаунт
        //void SerializeXML(ref Users userList);
        //bool Enter_account( UserClass User);//войти в аккаунт
        //void Get_Stats(ref UserClass  User);//узнать статистику пользователя

		void Test_vision_with_letters(ref UserClass User);//не требует пояснения
        void Test_vision_with_circles(ref UserClass User);//это тоже
		void Add_to_file(ref UserClass User); //записать данные проверки в файл
       // void Get_help();//получить хелпу
    }
}
