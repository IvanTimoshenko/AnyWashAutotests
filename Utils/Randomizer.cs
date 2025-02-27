﻿using AnyWashAutotests.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests
{
    /// <summary>
    /// Класс - рандомизатор
    /// </summary>
    public class Randomizer
    {
        Random random = new Random();

        /// <summary> Метод для получения случайного гос. номера </summary>
        /// <param name="list"> Список гос. номеров машин </param>
        /// <returns> гос. номер (string) </returns>
        public string GetRandomCarNumber(List<string> list)
        {
            return list[random.Next(0, list.Count - 1)];
        }

        /// <summary> Метод для получения случайного типа услуги </summary>
        /// <param name="list"> Список доступных услуг </param>
        /// <returns> индекс типа услуги </returns>
        public int GetRandomService(List<IWebElement> list)
        {
            return random.Next(1, list.Count + 1);
        }

        /// <summary> Метод для получения случайной char </summary>
        /// <param name="list"> Список char </param>
        /// <returns> случайная char </returns>
        public char GetRandomChar(List<char> list)
        {
            return list[random.Next(0, list.Count - 1)];
        }

        /// <summary> Метод для получения случайной int </summary>
        /// <param name="list"> Список int </param>
        /// <returns> случайная int </returns>
        public int GetRandomInt(List<int> list)
        {
            return list[random.Next(0, list.Count - 1)];
        }

        /// <summary> метод для получения случайной int </summary>
        /// <param name="minValue"> мин. значение </param>
        /// <param name="maxValue"> макс. значение </param>
        /// <returns> случайную int </returns>
        public int Randomize(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        /// <summary> метод для получения случайной int </summary>
        /// <param name="maxValue"> макс. значение </param>
        /// <returns> случайную int </returns>
        public int Randomize(int maxValue)
        {
            return random.Next(0, maxValue);
        }
    }
}
