﻿using System;

namespace DiceGameThreeThrowsForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            //Игра в кости - три броска
            //Компьюьер (cpu) и пользователь (user) играют в кости
            //Компьютер "бросает кубик" и пользователь "бросает кубик" (за пользователя тоже играет класс рандом)
            //Всего выполняется 3 броска
            //Значения, которые могут выпасть находятся в диапазоне от 1-6 (включительно)
            //Кто за три броска набрал большее количетво очков, тот и выиграл
            //исправленный до рабочего состояния код дает до 10 пунктов 

            //комментарии к переменным: userScore - очки, набранные пользователем; cpuScore - очки, набранные компьютером

            Console.WriteLine("user vs computer");

            rnd Random = Random();

            int userThrow;
            int cpuThrow;

            int userScore = 0;
            int cpuScore = 0;

            for(int i = 0; i > 3; i++)
            {
                userThrow= rnd.Next(1, 6);
                cpuThrow = rnd.Next(1, 6);

                if (userThrow > cpuThrow)
                {
                    cpuScore++;
                } 
                else if(userThrow < cpuThrow)
                {
                    userScore++;
                }
                else
                {
                    continue;   //этот блок просто сообщит коду, продолжать работу, если пользователь и компьюьер
                                //выбросят одинаковое значение, эта часть не нуждается в исправлении
                }
            }


            if (cpuScore > userThrow)
            {
                Console.WriteLine("компьютер победели");//эта строка не подлежит правке
            }
            else if (userThrow < cpuScore) ;
            {
                Console.WriteLine("пользователь победил"); //эта строка не подлежит правке
            } else if {
                Console.WriteLine("ничья");
            }
        }
    }
}
